namespace SwissTransport.UI
{
    partial class Stationen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Station = new System.Windows.Forms.TextBox();
            this.bt_search_Station = new System.Windows.Forms.Button();
            this.lst_Stations = new System.Windows.Forms.ListBox();
            this.dGV_Station = new System.Windows.Forms.DataGridView();
            this.transportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mailing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_station = new System.Windows.Forms.DateTimePicker();
            this.dt_station = new System.Windows.Forms.DateTimePicker();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_see_on_map = new System.Windows.Forms.Button();
            this.bt_mail = new System.Windows.Forms.Button();
            this.txt_to_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Station)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Station
            // 
            this.txt_Station.Location = new System.Drawing.Point(39, 61);
            this.txt_Station.Name = "txt_Station";
            this.txt_Station.Size = new System.Drawing.Size(182, 20);
            this.txt_Station.TabIndex = 0;
            this.txt_Station.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On_Input);
            // 
            // bt_search_Station
            // 
            this.bt_search_Station.Location = new System.Drawing.Point(227, 59);
            this.bt_search_Station.Name = "bt_search_Station";
            this.bt_search_Station.Size = new System.Drawing.Size(93, 23);
            this.bt_search_Station.TabIndex = 1;
            this.bt_search_Station.Text = "Station Suchen";
            this.bt_search_Station.UseVisualStyleBackColor = true;
            this.bt_search_Station.Click += new System.EventHandler(this.bt_search_Station_Click);
            // 
            // lst_Stations
            // 
            this.lst_Stations.FormattingEnabled = true;
            this.lst_Stations.Location = new System.Drawing.Point(39, 87);
            this.lst_Stations.Name = "lst_Stations";
            this.lst_Stations.Size = new System.Drawing.Size(182, 108);
            this.lst_Stations.TabIndex = 2;
            this.lst_Stations.Visible = false;
            this.lst_Stations.Click += new System.EventHandler(this.On_Select);
            // 
            // dGV_Station
            // 
            this.dGV_Station.AllowUserToAddRows = false;
            this.dGV_Station.AllowUserToDeleteRows = false;
            this.dGV_Station.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Station.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportation,
            this.Depart,
            this.Direction,
            this.Mailing});
            this.dGV_Station.Location = new System.Drawing.Point(12, 215);
            this.dGV_Station.Name = "dGV_Station";
            this.dGV_Station.Size = new System.Drawing.Size(571, 192);
            this.dGV_Station.TabIndex = 3;
            // 
            // transportation
            // 
            this.transportation.HeaderText = "Transportmittel";
            this.transportation.MinimumWidth = 100;
            this.transportation.Name = "transportation";
            this.transportation.ReadOnly = true;
            // 
            // Depart
            // 
            this.Depart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Depart.HeaderText = "Abfahrtszeit";
            this.Depart.MinimumWidth = 100;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direction.HeaderText = "Richtung";
            this.Direction.MinimumWidth = 100;
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // Mailing
            // 
            this.Mailing.HeaderText = "Mail";
            this.Mailing.MinimumWidth = 50;
            this.Mailing.Name = "Mailing";
            this.Mailing.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Station";
            // 
            // tp_station
            // 
            this.tp_station.Location = new System.Drawing.Point(227, 105);
            this.tp_station.Name = "tp_station";
            this.tp_station.Size = new System.Drawing.Size(93, 20);
            this.tp_station.TabIndex = 13;
            // 
            // dt_station
            // 
            this.dt_station.Location = new System.Drawing.Point(39, 105);
            this.dt_station.Name = "dt_station";
            this.dt_station.Size = new System.Drawing.Size(182, 20);
            this.dt_station.TabIndex = 14;
            // 
            // bt_home
            // 
            this.bt_home.BackColor = System.Drawing.SystemColors.WindowText;
            this.bt_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_home.Image = global::SwissTransport.UI.Properties.Resources.Home;
            this.bt_home.Location = new System.Drawing.Point(12, 12);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(30, 30);
            this.bt_home.TabIndex = 15;
            this.bt_home.UseVisualStyleBackColor = false;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_see_on_map
            // 
            this.bt_see_on_map.Location = new System.Drawing.Point(422, 422);
            this.bt_see_on_map.Name = "bt_see_on_map";
            this.bt_see_on_map.Size = new System.Drawing.Size(161, 23);
            this.bt_see_on_map.TabIndex = 17;
            this.bt_see_on_map.Text = "Station auf der Karte Ansehen";
            this.bt_see_on_map.UseVisualStyleBackColor = true;
            this.bt_see_on_map.Click += new System.EventHandler(this.bt_see_on_map_Click);
            // 
            // bt_mail
            // 
            this.bt_mail.Location = new System.Drawing.Point(198, 422);
            this.bt_mail.Name = "bt_mail";
            this.bt_mail.Size = new System.Drawing.Size(90, 23);
            this.bt_mail.TabIndex = 18;
            this.bt_mail.Text = "Auswahl Mailen";
            this.bt_mail.UseVisualStyleBackColor = true;
            this.bt_mail.Click += new System.EventHandler(this.bt_mail_Click);
            // 
            // txt_to_mail
            // 
            this.txt_to_mail.Location = new System.Drawing.Point(12, 424);
            this.txt_to_mail.Name = "txt_to_mail";
            this.txt_to_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_to_mail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mailadresse";
            // 
            // Stationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_to_mail);
            this.Controls.Add(this.bt_mail);
            this.Controls.Add(this.bt_see_on_map);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.dt_station);
            this.Controls.Add(this.tp_station);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_Station);
            this.Controls.Add(this.lst_Stations);
            this.Controls.Add(this.bt_search_Station);
            this.Controls.Add(this.txt_Station);
            this.MaximumSize = new System.Drawing.Size(611, 489);
            this.MinimumSize = new System.Drawing.Size(611, 489);
            this.Name = "Stationen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stationen";
            this.Load += new System.EventHandler(this.Stationen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Station)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Station;
        private System.Windows.Forms.Button bt_search_Station;
        private System.Windows.Forms.ListBox lst_Stations;
        private System.Windows.Forms.DataGridView dGV_Station;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tp_station;
        private System.Windows.Forms.DateTimePicker dt_station;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mailing;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_see_on_map;
        private System.Windows.Forms.Button bt_mail;
        private System.Windows.Forms.TextBox txt_to_mail;
        private System.Windows.Forms.Label label3;
    }
}