using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using com.sun.rowset.@internal;

namespace SwissTransport.UI
{
    public partial class Stationen : Form
    {
        // Public Variabeln
        // int um die Stationen id zu speichern.
        string id;

        // bool um die Abfrage zum öffnen des Browsers zu erleichtern.
        bool check;

        // bool um die richtigkeit des Strings zu überprüfen.
        bool str_comp;
        ///////////////////


        public Stationen()
        {
            InitializeComponent();

            // Ändern des tp_connection Formats um die Zeit ändern zu können.
            tp_station.Format = DateTimePickerFormat.Time;
            tp_station.ShowUpDown = true;

            // Listbox nach forne bringen.
            lst_Stations.BringToFront();

            // Setzen der boolean auf false.
            check = false;
            str_comp = false;
        }

        private void Stationen_Load(object sender, EventArgs e)
        {

        }

        private void bt_search_Station_Click(object sender, EventArgs e)
        {
            if (str_comp == false)
            {
                MessageBox.Show("Bitte zuerst eine Station auswählen.", "Falsche Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Löschen der vorher vorhandenen Daten um Platz zu schaffen.
                dGV_Station.DataSource = null;
                dGV_Station.Rows.Clear();


                DateTime selected_DateTime = dt_station.Value.Date + tp_station.Value.TimeOfDay;

                // Zeit und Datum zusammenfügen

                var transport = new Transport();
                var stationboard = transport.GetStationBoard(txt_Station.Text, id, selected_DateTime);


                var index = 0;
                foreach (var station in stationboard.Entries)
                {
                    var Departure = station.Stop.Departure.ToString();

                    //Einfügen der Daten in den Data Grid View und Formatierung der Uhrzeit und des Datums.
                    dGV_Station.Rows.Add(station.Category + " Nr." + station.Number, Departure.Substring(0, Math.Min(Departure.Length, 8)) + " | " +
                        Departure.Substring(11, Math.Min(Departure.Length, 5)) + "Uhr", station.To);

                    index += 1;
                }
            }
        }

        /// <summary>
        /// Fügt den angeklikten Wert, der Vorschläge, in die dazugehörige Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Select(object sender, EventArgs e)
        {
            if (sender == lst_Stations)
            {
                Station selected = lst_Stations.SelectedItem as Station;
                txt_Station.Text = selected.Name;
                id = selected.Id;
                lst_Stations.Visible = false;

                // Boolean wird auf true gesetzt da der String jetzt ganz und eindeutig ist.
                str_comp = true;
            }
            else
            {
                MessageBox.Show("Ungültiger Sender.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Lässt die Autovorschläge unter der Textbox erscheinen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Input(object sender, KeyPressEventArgs e)
        {
            if (sender == txt_Station)
            {

                // Reset des boolean str_comp.
                str_comp = false;

                lst_Stations.Visible = true;
                var transport = new Transport();
                var stations = new Stations();
                stations = transport.GetStations(txt_Station.Text);
                lst_Stations.DataSource = stations.StationList;
                lst_Stations.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Ungültiger Sender.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Öffnet ein Browserfenster um die Map anzuzueigen frägt zuvor allerdings beim ersten mal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_see_on_map_Click(object sender, EventArgs e)
        {
            if (str_comp == false)
            {
                MessageBox.Show("Bitte zuerst eine Station auswählen.", "Falsche Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check == false)
                {

                    DialogResult dialogResult = MessageBox.Show("Darf die App um die Karte anzuzeigen den Browser öffnen?", "Öffnen von Browser", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    var transport = new Transport();
                    var stations = transport.GetStations(txt_Station.Text);
                    var station = stations.StationList[0];
                    var coordinates = station.Coordinate;

                    // Einspeichern der Koordinaten um danach das , mit einem . zu tauschen weil es sonst nichts findet.
                    var X = coordinates.XCoordinate.ToString();
                    var Y = coordinates.YCoordinate.ToString();

                    //Ändern des , zu einem.


                    Process.Start("https://www.google.com/maps/search/?api=1&query=" +
                        X.Replace(",", ".") + "," + Y.Replace(",", ".") + "&zoom=200");
                }
            }
        }

        private void bt_closest_station_Click(object sender, EventArgs e)
        {
        }

        private void bt_mail_Click(object sender, EventArgs e)
        {
            if (txt_to_mail == null)
            {
                MessageBox.Show("Bitte eine gültige Mail eingeben.", "Keine Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (MailMessage mm = new MailMessage("swisstransport.app@gmail.com", txt_to_mail.Text))
                {
                    mm.Subject = "Ausgewählte ÖV Verbindungen.";

                    List<string> list = new List<string>();
                    list.Add("Transportmittel\t" + "  " +
                                    "Abfahrtszeit \t\t" + "  " +
                                    "Richtung" + "\n");
                    mm.Body = list[0];

                    int index = 1;
                    foreach (DataGridViewRow rows in dGV_Station.Rows)
                    {
                        if ((rows.Cells["Mailing"].Value) == null)
                        {
                            continue;
                        }

                        if ((bool)rows.Cells["Mailing"].Value == true)
                        {
                            list.Add(rows.Cells["transportation"].Value.ToString() + "\t\t " +
                                rows.Cells["Depart"].Value.ToString() + "  " +
                                rows.Cells["Direction"].Value.ToString() + "\n");

                            mm.Body += list[index];
                            index++;
                        }
                    }
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("swisstransport.app@gmail.com", "swisstransport69");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    MessageBox.Show("Email sent.", "Message");
                }
                txt_to_mail.Text = null;
            }
        }
    }
}
