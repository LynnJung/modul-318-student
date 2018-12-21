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
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.dgvFahrplan = new System.Windows.Forms.DataGridView();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbVerbindungen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFahrplan)).BeginInit();
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
            this.dgvFahrplan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFahrplan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFahrplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFahrplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.dgvFahrplan.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFahrplan.Location = new System.Drawing.Point(111, 177);
            this.dgvFahrplan.Name = "dgvFahrplan";
            this.dgvFahrplan.ReadOnly = true;
            this.dgvFahrplan.Size = new System.Drawing.Size(341, 139);
            this.dgvFahrplan.TabIndex = 4;
            // 
            // Abfahrt
            // 
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            this.Abfahrt.ReadOnly = true;
            // 
            // Ankunft
            // 
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            this.Ankunft.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
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
            this.btnSuche.TabIndex = 5;
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
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(111, 328);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(127, 33);
            this.btnAbfahrtstafel.TabIndex = 6;
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
            this.txtMail.Location = new System.Drawing.Point(504, 301);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 21);
            this.txtMail.TabIndex = 7;
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(504, 328);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(152, 33);
            this.btnMail.TabIndex = 8;
            this.btnMail.Text = "Fahrplan per Email senden";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMapsSearch
            // 
            this.btnMapsSearch.Location = new System.Drawing.Point(418, 42);
            this.btnMapsSearch.Name = "btnMapsSearch";
            this.btnMapsSearch.Size = new System.Drawing.Size(147, 23);
            this.btnMapsSearch.TabIndex = 11;
            this.btnMapsSearch.Text = "Ort auf der Karte anzeigen";
            this.btnMapsSearch.UseVisualStyleBackColor = true;
            this.btnMapsSearch.Click += new System.EventHandler(this.btnMapsSearch_Click);
            // 
            // btnNearby
            // 
            this.btnNearby.Location = new System.Drawing.Point(308, 328);
            this.btnNearby.Name = "btnNearby";
            this.btnNearby.Size = new System.Drawing.Size(137, 33);
            this.btnNearby.TabIndex = 12;
            this.btnNearby.Text = "Stationen in der Nähe";
            this.btnNearby.UseVisualStyleBackColor = true;
            this.btnNearby.Click += new System.EventHandler(this.btnNearby_Click);
            // 
            // linkStandortMaps
            // 
            this.linkStandortMaps.AutoSize = true;
            this.linkStandortMaps.Location = new System.Drawing.Point(305, 364);
            this.linkStandortMaps.Name = "linkStandortMaps";
            this.linkStandortMaps.Size = new System.Drawing.Size(147, 13);
            this.linkStandortMaps.TabIndex = 13;
            this.linkStandortMaps.TabStop = true;
            this.linkStandortMaps.Text = "Standort im Browser anzeigen";
            // 
            // linkStationMaps
            // 
            this.linkStationMaps.AutoSize = true;
            this.linkStationMaps.Location = new System.Drawing.Point(415, 68);
            this.linkStationMaps.Name = "linkStationMaps";
            this.linkStationMaps.Size = new System.Drawing.Size(140, 13);
            this.linkStationMaps.TabIndex = 14;
            this.linkStationMaps.TabStop = true;
            this.linkStationMaps.Text = "Station im Browser anzeigen";
            this.linkStationMaps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStationMaps_LinkClicked);
            // 
            // gbSuche
            // 
            this.gbSuche.Location = new System.Drawing.Point(12, 26);
            this.gbSuche.Name = "gbSuche";
            this.gbSuche.Size = new System.Drawing.Size(652, 145);
            this.gbSuche.TabIndex = 15;
            this.gbSuche.TabStop = false;
            this.gbSuche.Text = "Suche :";
            // 
            // gbVerbindungen
            // 
            this.gbVerbindungen.Location = new System.Drawing.Point(12, 170);
            this.gbVerbindungen.Name = "gbVerbindungen";
            this.gbVerbindungen.Size = new System.Drawing.Size(486, 152);
            this.gbVerbindungen.TabIndex = 16;
            this.gbVerbindungen.TabStop = false;
            this.gbVerbindungen.Text = "Verbindungen :";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 391);
            this.Controls.Add(this.linkStationMaps);
            this.Controls.Add(this.linkStandortMaps);
            this.Controls.Add(this.btnNearby);
            this.Controls.Add(this.btnMapsSearch);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnMapsSearch;
        protected System.Windows.Forms.ComboBox cbAbfahrt;
        private System.Windows.Forms.Button btnNearby;
        private System.Windows.Forms.LinkLabel linkStandortMaps;
        private System.Windows.Forms.LinkLabel linkStationMaps;
        private System.Windows.Forms.GroupBox gbSuche;
        private System.Windows.Forms.GroupBox gbVerbindungen;
    }
}

