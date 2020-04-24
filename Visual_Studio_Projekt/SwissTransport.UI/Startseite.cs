using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using com.sun.rowset.@internal;

namespace SwissTransport.UI
{

    public partial class Startseite : Form
    {
        // Public Variabel
        // int um zwischen An un abfahrtszeit wechseln zu können. (bt_dep_arr)
        int arr_dep;
        //  int um die Funktion Spätere Verbindungen zu ermöglichen.
        int later_conn;

        // bool um die richtigkeit des Strings zu überprüfen.
        bool str_comp;

        // Erstellen einer Stationen Form.
        Stationen stationen = new Stationen();
        ///////////////////

        public Startseite()
        {
            InitializeComponent();

            // Ändern des tp_connection Formats um die Zeit ändern zu können.
            tp_connection.Format = DateTimePickerFormat.Time;
            tp_connection.ShowUpDown = true;

            // Int arr_dep auf 0 Stellen -> Abfahrtszeit ist der Standart.
            arr_dep = 0;

            // Int later_conn auf 4(Standartwert Stellen).
            later_conn = 4;

            // listbox nach forne bringen
            lst_To.BringToFront();

            // Setzen der boolean auf false.
            str_comp = false;

            txt_to_mail = null;
        }




        private void bt_to_Station_Click(object sender, EventArgs e)
        {
            stationen.Show();
        }

        private void dGV_Connections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Lässt die Autovorschläge unter der Textbox erscheinen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Input(object sender, KeyPressEventArgs e)
        {
            if (sender == txt_From)
            {
                lst_From.Visible = true;
                var transport = new Transport();
                var stations = new Stations();
                stations = transport.GetStations(txt_From.Text);
                lst_From.DataSource = stations.StationList;
                lst_From.DisplayMember = "Name";

                // Reset des boolean str_comp.
                str_comp = false;
            }
            else if (sender == txt_To)
            {
                lst_To.Visible = true;
                var transport = new Transport();
                var stations = new Stations();
                stations = transport.GetStations(txt_To.Text);
                lst_To.DataSource = stations.StationList;
                lst_To.DisplayMember = "Name";

                // Reset des boolean str_comp.
                str_comp = false;
            }
            else
            {
                MessageBox.Show("Ungültiger Sender.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Fügt den angeklikten Wert, der Vorschläge, in die dazugehörige Textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Select(object sender, EventArgs e)
        {
            if (sender == lst_From)
            {
                Station selected = lst_From.SelectedItem as Station;
                txt_From.Text = selected.Name;
                lst_From.Visible = false;

                // Boolean wird auf true gesetzt da der String jetzt ganz und eindeutig ist.
                str_comp = true;
            }
            else if (sender == lst_To)
            {
                Station selected = lst_To.SelectedItem as Station;
                txt_To.Text = selected.Name;
                lst_To.Visible = false;

                // Boolean wird auf true gesetzt da der String jetzt ganz und eindeutig ist.
                str_comp = true;
            }
            else
            {
                MessageBox.Show("Ungültiger Sender.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_dep_arr_Click(object sender, EventArgs e)
        {
            if (arr_dep == 1)
            {
                arr_dep = 0;
                bt_dep_arr.Text = "Abfahrtszeit";
            }
            else if (arr_dep == 0)
            {
                arr_dep = 1;
                bt_dep_arr.Text = "Ankunftszeit";
            }
        }

        private void bt_later_conn_Click(object sender, EventArgs e)
        {
            if (later_conn < 16)
            {
                later_conn += 4;
                fill_in_Data();
            }
            else
            {
                MessageBox.Show("Ändern sie die Abfahrtszeit oder Ankunftszeit um Spätere verbindungen anzeigen zu lassen.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fill_in_Data()
        {
            if (str_comp == false)
            {
                MessageBox.Show("Bitte zuerst eine Station auswählen.", "Falsche Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Löschen der vorher vorhandenen Daten um Platz zu schaffen
                dGV_Connections.DataSource = null;
                dGV_Connections.Rows.Clear();

                // Zeit und Datum zusammenfügen
                DateTime selected_DateTime = dt_connection.Value.Date + tp_connection.Value.TimeOfDay;

                var transport = new Transport();
                var connections = transport.GetConnections(txt_From.Text, txt_To.Text, selected_DateTime, arr_dep, later_conn);

                List<ConnectionPoint> ConnectionPoint_from = new List<ConnectionPoint>();
                List<ConnectionPoint> ConnectionPoint_to = new List<ConnectionPoint>();

                var index = 0;
                foreach (var connection in connections.ConnectionList)
                {
                    ConnectionPoint_from.Add(connection.From);
                    ConnectionPoint_to.Add(connection.To);

                    //Einfügen der Daten in den Data Grid View und Formatierung der Uhrzeit und des Datums.
                    dGV_Connections.Rows.Add(
                        ConnectionPoint_from[index].Departure.Substring(2, Math.Min(ConnectionPoint_from[index].Departure.Length, 8)) + " | " +
                        ConnectionPoint_from[index].Departure.Substring(11, Math.Min(ConnectionPoint_from[index].Departure.Length, 5)) + "Uhr" +
                        " - " + ConnectionPoint_to[index].Arrival.Substring(11, Math.Min(ConnectionPoint_to[index].Arrival.Length, 5)) + "Uhr",
                    ConnectionPoint_from[index].Station.Name + " - " + ConnectionPoint_to[index].Station.Name,
                    connection.Duration.Substring(3, Math.Min(Duration.MaxInputLength, 2)) + "h " +
                    connection.Duration.Substring(6, Math.Min(Duration.MaxInputLength, 2)) + "min");

                    index += 1;
                }
            }
        }

        private void bt_reverse_Click(object sender, EventArgs e)
        {
            var save_text = txt_From.Text;
            txt_From.Text = txt_To.Text;
            txt_To.Text = save_text;
        }

        private void bt_search_connection_Click(object sender, EventArgs e)
        {
            later_conn = 4;
            fill_in_Data();
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
                    list.Add("Ab / An \t\t\t\t" + "  " +
                                    "Von / Bis \t\t\t\t" + "  " +
                                    "Dauer" + "\n");
                    mm.Body = list[0];

                    int index = 1;
                    foreach (DataGridViewRow rows in dGV_Connections.Rows)
                    {
                        if ((rows.Cells["Mailing"].Value) == null)
                        {
                            continue;
                        }

                        if ((bool)rows.Cells["Mailing"].Value == true)
                        {
                            list.Add(rows.Cells["Dep_Arr"].Value.ToString() + "  " +
                                rows.Cells["From_To"].Value.ToString() + "  " +
                                rows.Cells["Duration"].Value.ToString() + "\n");

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

        private void Startseite_Load(object sender, EventArgs e)
        {

        }
    }
}