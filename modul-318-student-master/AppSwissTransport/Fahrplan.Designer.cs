namespace AppSwissTransport
{
    partial class Fahrplan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.dgvFahrplan = new System.Windows.Forms.DataGridView();
            this.cbAbfahrt = new System.Windows.Forms.ComboBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.cbAnkunft = new System.Windows.Forms.ComboBox();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnVon = new System.Windows.Forms.Button();
            this.btnNach = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnMapsSearch = new System.Windows.Forms.Button();
            this.btnNearby = new System.Windows.Forms.Button();
            this.linkStandortMaps = new System.Windows.Forms.LinkLabel();
            this.linkStationMaps = new System.Windows.Forms.LinkLabel();
            this.gbSuche = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbVerbindungen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrplan)).BeginInit();
            this.gbSuche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(31, 47);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(89, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von (Abfahrtsort):";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(31, 81);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(99, 13);
            this.lblNach.TabIndex = 2;
            this.lblNach.Text = "Nach (Ankunftsort):";
            // 
            // dgvFahrplan
            // 
            this.dgvFahrplan.AllowUserToAddRows = false;
            this.dgvFahrplan.AllowUserToDeleteRows = false;
            this.dgvFahrplan.AllowUserToResizeColumns = false;
            this.dgvFahrplan.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            this.dgvFahrplan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFahrplan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFahrplan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFahrplan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFahrplan.Location = new System.Drawing.Point(111, 177);
            this.dgvFahrplan.Name = "dgvFahrplan";
            this.dgvFahrplan.ReadOnly = true;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvFahrplan.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFahrplan.Size = new System.Drawing.Size(656, 139);
            this.dgvFahrplan.TabIndex = 8;
            // 
            // cbAbfahrt
            // 
            this.cbAbfahrt.FormattingEnabled = true;
            this.cbAbfahrt.Location = new System.Drawing.Point(150, 44);
            this.cbAbfahrt.Name = "cbAbfahrt";
            this.cbAbfahrt.Size = new System.Drawing.Size(130, 21);
            this.cbAbfahrt.TabIndex = 1;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(111, 123);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(283, 24);
            this.btnSuche.TabIndex = 7;
            this.btnSuche.Text = "Verbindungen Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // cbAnkunft
            // 
            this.cbAnkunft.FormattingEnabled = true;
            this.cbAnkunft.Location = new System.Drawing.Point(150, 81);
            this.cbAnkunft.Name = "cbAnkunft";
            this.cbAnkunft.Size = new System.Drawing.Size(130, 21);
            this.cbAnkunft.TabIndex = 3;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(130, 328);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(127, 33);
            this.btnAbfahrtstafel.TabIndex = 9;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.btnAbfahrtstafel_Click);
            // 
            // btnVon
            // 
            this.btnVon.Location = new System.Drawing.Point(308, 42);
            this.btnVon.Name = "btnVon";
            this.btnVon.Size = new System.Drawing.Size(75, 23);
            this.btnVon.TabIndex = 2;
            this.btnVon.Text = "Suchen";
            this.btnVon.UseVisualStyleBackColor = true;
            this.btnVon.Click += new System.EventHandler(this.btnVon_Click);
            // 
            // btnNach
            // 
            this.btnNach.Location = new System.Drawing.Point(308, 81);
            this.btnNach.Name = "btnNach";
            this.btnNach.Size = new System.Drawing.Size(75, 23);
            this.btnNach.TabIndex = 4;
            this.btnNach.Text = "Suchen";
            this.btnNach.UseVisualStyleBackColor = true;
            this.btnNach.Click += new System.EventHandler(this.btnNach_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(537, 328);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 21);
            this.txtMail.TabIndex = 12;
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(537, 354);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(152, 33);
            this.btnMail.TabIndex = 13;
            this.btnMail.Text = "Fahrplan per Email senden";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMapsSearch
            // 
            this.btnMapsSearch.Location = new System.Drawing.Point(386, 16);
            this.btnMapsSearch.Name = "btnMapsSearch";
            this.btnMapsSearch.Size = new System.Drawing.Size(147, 23);
            this.btnMapsSearch.TabIndex = 0;
            this.btnMapsSearch.Text = "Ort auf der Karte anzeigen";
            this.btnMapsSearch.UseVisualStyleBackColor = true;
            this.btnMapsSearch.Click += new System.EventHandler(this.btnMapsSearch_Click);
            // 
            // btnNearby
            // 
            this.btnNearby.Location = new System.Drawing.Point(335, 328);
            this.btnNearby.Name = "btnNearby";
            this.btnNearby.Size = new System.Drawing.Size(137, 33);
            this.btnNearby.TabIndex = 10;
            this.btnNearby.Text = "Stationen in der Nähe";
            this.btnNearby.UseVisualStyleBackColor = true;
            this.btnNearby.Click += new System.EventHandler(this.btnNearby_Click);
            // 
            // linkStandortMaps
            // 
            this.linkStandortMaps.AutoSize = true;
            this.linkStandortMaps.Location = new System.Drawing.Point(325, 374);
            this.linkStandortMaps.Name = "linkStandortMaps";
            this.linkStandortMaps.Size = new System.Drawing.Size(147, 13);
            this.linkStandortMaps.TabIndex = 11;
            this.linkStandortMaps.TabStop = true;
            this.linkStandortMaps.Text = "Standort im Browser anzeigen";
            this.linkStandortMaps.Click += new System.EventHandler(this.linkStandortMaps_Click);
            // 
            // linkStationMaps
            // 
            this.linkStationMaps.AutoSize = true;
            this.linkStationMaps.Location = new System.Drawing.Point(383, 42);
            this.linkStationMaps.Name = "linkStationMaps";
            this.linkStationMaps.Size = new System.Drawing.Size(140, 13);
            this.linkStationMaps.TabIndex = 0;
            this.linkStationMaps.TabStop = true;
            this.linkStationMaps.Text = "Station im Browser anzeigen";
            this.linkStationMaps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStationMaps_LinkClicked);
            // 
            // gbSuche
            // 
            this.gbSuche.Controls.Add(this.dtpTime);
            this.gbSuche.Controls.Add(this.lblTime);
            this.gbSuche.Controls.Add(this.lblDate);
            this.gbSuche.Controls.Add(this.linkStationMaps);
            this.gbSuche.Controls.Add(this.dtpDate);
            this.gbSuche.Controls.Add(this.btnMapsSearch);
            this.gbSuche.Location = new System.Drawing.Point(12, 26);
            this.gbSuche.Name = "gbSuche";
            this.gbSuche.Size = new System.Drawing.Size(761, 145);
            this.gbSuche.TabIndex = 15;
            this.gbSuche.TabStop = false;
            this.gbSuche.Text = "Suche :";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(618, 52);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(70, 20);
            this.dtpTime.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(554, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 13);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Zeit";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(554, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Datum :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(618, 19);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // gbVerbindungen
            // 
            this.gbVerbindungen.Location = new System.Drawing.Point(12, 170);
            this.gbVerbindungen.Name = "gbVerbindungen";
            this.gbVerbindungen.Size = new System.Drawing.Size(761, 152);
            this.gbVerbindungen.TabIndex = 16;
            this.gbVerbindungen.TabStop = false;
            this.gbVerbindungen.Text = "Verbindungen :";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 405);
            this.Controls.Add(this.linkStandortMaps);
            this.Controls.Add(this.btnNearby);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnNach);
            this.Controls.Add(this.btnVon);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.cbAnkunft);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.cbAbfahrt);
            this.Controls.Add(this.dgvFahrplan);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.gbSuche);
            this.Controls.Add(this.gbVerbindungen);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrplan)).EndInit();
            this.gbSuche.ResumeLayout(false);
            this.gbSuche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.DataGridView dgvFahrplan;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.ComboBox cbAnkunft;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnVon;
        private System.Windows.Forms.Button btnNach;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnMapsSearch;
        protected System.Windows.Forms.ComboBox cbAbfahrt;
        private System.Windows.Forms.Button btnNearby;
        private System.Windows.Forms.LinkLabel linkStandortMaps;
        private System.Windows.Forms.LinkLabel linkStationMaps;
        private System.Windows.Forms.GroupBox gbSuche;
        private System.Windows.Forms.GroupBox gbVerbindungen;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

