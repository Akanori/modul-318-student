namespace SwissTransport.UI
{
    partial class Startseite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.bt_Search_Connection = new System.Windows.Forms.Button();
            this.dt_connection = new System.Windows.Forms.DateTimePicker();
            this.bt_to_Station = new System.Windows.Forms.Button();
            this.dGV_Connections = new System.Windows.Forms.DataGridView();
            this.Dep_Arr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mailing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lst_To = new System.Windows.Forms.ListBox();
            this.lst_From = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_connection = new System.Windows.Forms.DateTimePicker();
            this.bt_dep_arr = new System.Windows.Forms.Button();
            this.bt_later_conn = new System.Windows.Forms.Button();
            this.bt_reverse = new System.Windows.Forms.Button();
            this.bt_mail = new System.Windows.Forms.Button();
            this.txt_to_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Connections)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(12, 68);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(180, 20);
            this.txt_From.TabIndex = 0;
            this.txt_From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On_Input);
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(279, 66);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(180, 20);
            this.txt_To.TabIndex = 1;
            this.txt_To.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.On_Input);
            // 
            // bt_Search_Connection
            // 
            this.bt_Search_Connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Search_Connection.Location = new System.Drawing.Point(463, 64);
            this.bt_Search_Connection.Name = "bt_Search_Connection";
            this.bt_Search_Connection.Size = new System.Drawing.Size(120, 23);
            this.bt_Search_Connection.TabIndex = 3;
            this.bt_Search_Connection.Text = "Verbindung Suchen";
            this.bt_Search_Connection.UseVisualStyleBackColor = true;
            this.bt_Search_Connection.Click += new System.EventHandler(this.bt_search_connection_Click);
            // 
            // dt_connection
            // 
            this.dt_connection.Location = new System.Drawing.Point(12, 108);
            this.dt_connection.Name = "dt_connection";
            this.dt_connection.Size = new System.Drawing.Size(180, 20);
            this.dt_connection.TabIndex = 4;
            // 
            // bt_to_Station
            // 
            this.bt_to_Station.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_to_Station.Location = new System.Drawing.Point(12, 12);
            this.bt_to_Station.Name = "bt_to_Station";
            this.bt_to_Station.Size = new System.Drawing.Size(75, 23);
            this.bt_to_Station.TabIndex = 6;
            this.bt_to_Station.Text = "Stationen";
            this.bt_to_Station.UseVisualStyleBackColor = true;
            this.bt_to_Station.Click += new System.EventHandler(this.bt_to_Station_Click);
            // 
            // dGV_Connections
            // 
            this.dGV_Connections.AllowUserToAddRows = false;
            this.dGV_Connections.AllowUserToDeleteRows = false;
            this.dGV_Connections.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dGV_Connections.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGV_Connections.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGV_Connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Connections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dep_Arr,
            this.From_To,
            this.Duration,
            this.Mailing});
            this.dGV_Connections.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGV_Connections.Location = new System.Drawing.Point(12, 208);
            this.dGV_Connections.MaximumSize = new System.Drawing.Size(573, 192);
            this.dGV_Connections.MinimumSize = new System.Drawing.Size(573, 192);
            this.dGV_Connections.Name = "dGV_Connections";
            this.dGV_Connections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV_Connections.Size = new System.Drawing.Size(573, 192);
            this.dGV_Connections.TabIndex = 7;
            this.dGV_Connections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Connections_CellContentClick);
            // 
            // Dep_Arr
            // 
            this.Dep_Arr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dep_Arr.HeaderText = "Ab / An";
            this.Dep_Arr.MinimumWidth = 100;
            this.Dep_Arr.Name = "Dep_Arr";
            this.Dep_Arr.ReadOnly = true;
            // 
            // From_To
            // 
            this.From_To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_To.HeaderText = "Von / Bis";
            this.From_To.Name = "From_To";
            this.From_To.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Dauer";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Mailing
            // 
            this.Mailing.HeaderText = "Mail";
            this.Mailing.Name = "Mailing";
            // 
            // lst_To
            // 
            this.lst_To.FormattingEnabled = true;
            this.lst_To.Location = new System.Drawing.Point(279, 92);
            this.lst_To.MaximumSize = new System.Drawing.Size(180, 108);
            this.lst_To.MinimumSize = new System.Drawing.Size(180, 108);
            this.lst_To.Name = "lst_To";
            this.lst_To.Size = new System.Drawing.Size(180, 108);
            this.lst_To.TabIndex = 8;
            this.lst_To.Visible = false;
            this.lst_To.Click += new System.EventHandler(this.On_Select);
            // 
            // lst_From
            // 
            this.lst_From.FormattingEnabled = true;
            this.lst_From.Location = new System.Drawing.Point(12, 92);
            this.lst_From.MaximumSize = new System.Drawing.Size(180, 108);
            this.lst_From.MinimumSize = new System.Drawing.Size(180, 108);
            this.lst_From.Name = "lst_From";
            this.lst_From.Size = new System.Drawing.Size(180, 108);
            this.lst_From.TabIndex = 9;
            this.lst_From.Visible = false;
            this.lst_From.Click += new System.EventHandler(this.On_Select);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bis";
            // 
            // tp_connection
            // 
            this.tp_connection.Location = new System.Drawing.Point(198, 108);
            this.tp_connection.Name = "tp_connection";
            this.tp_connection.Size = new System.Drawing.Size(75, 20);
            this.tp_connection.TabIndex = 12;
            // 
            // bt_dep_arr
            // 
            this.bt_dep_arr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_dep_arr.Location = new System.Drawing.Point(279, 105);
            this.bt_dep_arr.Name = "bt_dep_arr";
            this.bt_dep_arr.Size = new System.Drawing.Size(75, 23);
            this.bt_dep_arr.TabIndex = 13;
            this.bt_dep_arr.Text = "Abfahrtszeit";
            this.bt_dep_arr.UseVisualStyleBackColor = true;
            this.bt_dep_arr.Click += new System.EventHandler(this.bt_dep_arr_Click);
            // 
            // bt_later_conn
            // 
            this.bt_later_conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_later_conn.Location = new System.Drawing.Point(454, 415);
            this.bt_later_conn.Name = "bt_later_conn";
            this.bt_later_conn.Size = new System.Drawing.Size(129, 23);
            this.bt_later_conn.TabIndex = 14;
            this.bt_later_conn.Text = "Spätere Verbindungen";
            this.bt_later_conn.UseVisualStyleBackColor = true;
            this.bt_later_conn.Click += new System.EventHandler(this.bt_later_conn_Click);
            // 
            // bt_reverse
            // 
            this.bt_reverse.BackColor = System.Drawing.Color.White;
            this.bt_reverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_reverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_reverse.Image = global::SwissTransport.UI.Properties.Resources.switch1;
            this.bt_reverse.Location = new System.Drawing.Point(198, 64);
            this.bt_reverse.Name = "bt_reverse";
            this.bt_reverse.Size = new System.Drawing.Size(75, 36);
            this.bt_reverse.TabIndex = 2;
            this.bt_reverse.UseVisualStyleBackColor = false;
            this.bt_reverse.Click += new System.EventHandler(this.bt_reverse_Click);
            // 
            // bt_mail
            // 
            this.bt_mail.Location = new System.Drawing.Point(201, 416);
            this.bt_mail.Name = "bt_mail";
            this.bt_mail.Size = new System.Drawing.Size(90, 23);
            this.bt_mail.TabIndex = 19;
            this.bt_mail.Text = "Auswahl Mailen";
            this.bt_mail.UseVisualStyleBackColor = true;
            this.bt_mail.Click += new System.EventHandler(this.bt_mail_Click);
            // 
            // txt_to_mail
            // 
            this.txt_to_mail.Location = new System.Drawing.Point(15, 418);
            this.txt_to_mail.Name = "txt_to_mail";
            this.txt_to_mail.Size = new System.Drawing.Size(180, 20);
            this.txt_to_mail.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mailadresse";
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_to_mail);
            this.Controls.Add(this.bt_mail);
            this.Controls.Add(this.bt_later_conn);
            this.Controls.Add(this.bt_dep_arr);
            this.Controls.Add(this.tp_connection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_From);
            this.Controls.Add(this.lst_To);
            this.Controls.Add(this.dGV_Connections);
            this.Controls.Add(this.bt_to_Station);
            this.Controls.Add(this.dt_connection);
            this.Controls.Add(this.bt_Search_Connection);
            this.Controls.Add(this.bt_reverse);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.txt_From);
            this.MaximumSize = new System.Drawing.Size(611, 489);
            this.MinimumSize = new System.Drawing.Size(611, 489);
            this.Name = "Startseite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.Startseite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Connections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Button bt_reverse;
        private System.Windows.Forms.Button bt_Search_Connection;
        private System.Windows.Forms.DateTimePicker dt_connection;
        private System.Windows.Forms.Button bt_to_Station;
        private System.Windows.Forms.DataGridView dGV_Connections;
        private System.Windows.Forms.ListBox lst_To;
        private System.Windows.Forms.ListBox lst_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tp_connection;
        private System.Windows.Forms.Button bt_dep_arr;
        private System.Windows.Forms.Button bt_later_conn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dep_Arr;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Mailing;
        private System.Windows.Forms.Button bt_mail;
        private System.Windows.Forms.TextBox txt_to_mail;
        private System.Windows.Forms.Label label3;
    }
}

