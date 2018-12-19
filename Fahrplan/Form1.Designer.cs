namespace Fahrplan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl1 = new System.Windows.Forms.Panel();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.webGoogleMaps = new System.Windows.Forms.WebBrowser();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtNach = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnSearchMaps = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.gbSearch2 = new System.Windows.Forms.GroupBox();
            this.gbSearch3 = new System.Windows.Forms.GroupBox();
            this.lbxVon2 = new System.Windows.Forms.ListBox();
            this.lbxVon = new System.Windows.Forms.ListBox();
            this.lbxStation = new System.Windows.Forms.ListBox();
            this.lbxNach = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVon2 = new System.Windows.Forms.Label();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblAbfahrtstafel = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblLaden = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtgVerbindungen = new System.Windows.Forms.DataGridView();
            this.dtgVerbindungen2 = new System.Windows.Forms.DataGridView();
            this.btnVon2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnSuche3 = new System.Windows.Forms.Button();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVS = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.btnMaps = new System.Windows.Forms.Button();
            this.pbAbfahrtstafel_Zug = new System.Windows.Forms.PictureBox();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.pnl1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.gbSearch2.SuspendLayout();
            this.gbSearch3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgVerbindungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dtgVerbindungen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbAbfahrtstafel_Zug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.gbResult);
            this.pnl1.Controls.Add(this.gbSearch);
            this.pnl1.Location = new System.Drawing.Point(58, 91);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(923, 672);
            this.pnl1.TabIndex = 7;
            // 
            // gbResult
            // 
            this.gbResult.Location = new System.Drawing.Point(4, 182);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(923, 462);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Ausgabe";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.webGoogleMaps);
            this.gbSearch.Controls.Add(this.txtVon);
            this.gbSearch.Controls.Add(this.txtStation);
            this.gbSearch.Controls.Add(this.txtNach);
            this.gbSearch.Controls.Add(this.txtEmail);
            this.gbSearch.Controls.Add(this.pbAbfahrtstafel_Zug);
            this.gbSearch.Controls.Add(this.pbSwitch);
            this.gbSearch.Controls.Add(this.btnSuche);
            this.gbSearch.Controls.Add(this.btnSearchMaps);
            this.gbSearch.Controls.Add(this.btnEmail);
            this.gbSearch.Location = new System.Drawing.Point(4, 11);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(916, 164);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Suche";
            // 
            // webGoogleMaps
            // 
            this.webGoogleMaps.Location = new System.Drawing.Point(14, 181);
            this.webGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGoogleMaps.Name = "webGoogleMaps";
            this.webGoogleMaps.ScriptErrorsSuppressed = true;
            this.webGoogleMaps.Size = new System.Drawing.Size(691, 462);
            this.webGoogleMaps.TabIndex = 5;
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(6, 40);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(200, 20);
            this.txtVon.TabIndex = 4;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(6, 40);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(200, 20);
            this.txtStation.TabIndex = 13;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // txtNach
            // 
            this.txtNach.Location = new System.Drawing.Point(250, 40);
            this.txtNach.Name = "txtNach";
            this.txtNach.Size = new System.Drawing.Size(200, 20);
            this.txtNach.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(591, 112);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(672, 44);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(129, 23);
            this.btnSuche.TabIndex = 13;
            this.btnSuche.Text = "Verbindung Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // btnSearchMaps
            // 
            this.btnSearchMaps.Location = new System.Drawing.Point(672, 73);
            this.btnSearchMaps.Name = "btnSearchMaps";
            this.btnSearchMaps.Size = new System.Drawing.Size(129, 23);
            this.btnSearchMaps.TabIndex = 10;
            this.btnSearchMaps.Text = "Google Maps";
            this.btnSearchMaps.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmail.Location = new System.Drawing.Point(672, 132);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(129, 23);
            this.btnEmail.TabIndex = 12;
            this.btnEmail.Text = "Per Email senden";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.gbSearch2);
            this.pnl2.Controls.Add(this.btnSuche3);
            this.pnl2.Controls.Add(this.pnl3);
            this.pnl2.Location = new System.Drawing.Point(58, 102);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(519, 614);
            this.pnl2.TabIndex = 10;
            // 
            // gbSearch2
            // 
            this.gbSearch2.Controls.Add(this.gbSearch3);
            this.gbSearch2.Location = new System.Drawing.Point(12, 102);
            this.gbSearch2.Name = "gbSearch2";
            this.gbSearch2.Size = new System.Drawing.Size(502, 164);
            this.gbSearch2.TabIndex = 3;
            this.gbSearch2.TabStop = false;
            this.gbSearch2.Text = "Suche";
            // 
            // gbSearch3
            // 
            this.gbSearch3.Controls.Add(this.lbxVon2);
            this.gbSearch3.Controls.Add(this.lbxVon);
            this.gbSearch3.Controls.Add(this.lbxStation);
            this.gbSearch3.Controls.Add(this.lbxNach);
            this.gbSearch3.Controls.Add(this.lblTime);
            this.gbSearch3.Controls.Add(this.lblVon2);
            this.gbSearch3.Controls.Add(this.lblVon);
            this.gbSearch3.Controls.Add(this.lblAbfahrtstafel);
            this.gbSearch3.Controls.Add(this.lblStation);
            this.gbSearch3.Controls.Add(this.lblNach);
            this.gbSearch3.Controls.Add(this.lblLaden);
            this.gbSearch3.Controls.Add(this.lblDate);
            this.gbSearch3.Controls.Add(this.dtpTime);
            this.gbSearch3.Controls.Add(this.dtpDate);
            this.gbSearch3.Controls.Add(this.dtgVerbindungen);
            this.gbSearch3.Controls.Add(this.dtgVerbindungen2);
            this.gbSearch3.Controls.Add(this.btnVon2);
            this.gbSearch3.Controls.Add(this.btnSearch2);
            this.gbSearch3.Location = new System.Drawing.Point(8, 11);
            this.gbSearch3.Name = "gbSearch3";
            this.gbSearch3.Size = new System.Drawing.Size(887, 164);
            this.gbSearch3.TabIndex = 4;
            this.gbSearch3.TabStop = false;
            this.gbSearch3.Text = "Suche";
            // 
            // lbxVon2
            // 
            this.lbxVon2.FormattingEnabled = true;
            this.lbxVon2.Location = new System.Drawing.Point(9, 59);
            this.lbxVon2.Name = "lbxVon2";
            this.lbxVon2.Size = new System.Drawing.Size(200, 95);
            this.lbxVon2.TabIndex = 0;
            this.lbxVon2.Visible = false;
            // 
            // lbxVon
            // 
            this.lbxVon.FormattingEnabled = true;
            this.lbxVon.Location = new System.Drawing.Point(7, 60);
            this.lbxVon.Name = "lbxVon";
            this.lbxVon.Size = new System.Drawing.Size(200, 95);
            this.lbxVon.TabIndex = 0;
            this.lbxVon.Visible = false;
            // 
            // lbxStation
            // 
            this.lbxStation.FormattingEnabled = true;
            this.lbxStation.Location = new System.Drawing.Point(6, 59);
            this.lbxStation.Name = "lbxStation";
            this.lbxStation.Size = new System.Drawing.Size(200, 95);
            this.lbxStation.TabIndex = 9;
            this.lbxStation.Visible = false;
            this.lbxStation.DoubleClick += new System.EventHandler(this.lbx_3_start_DoubleClick);
            // 
            // lbxNach
            // 
            this.lbxNach.FormattingEnabled = true;
            this.lbxNach.Location = new System.Drawing.Point(250, 59);
            this.lbxNach.Name = "lbxNach";
            this.lbxNach.Size = new System.Drawing.Size(200, 95);
            this.lbxNach.TabIndex = 0;
            this.lbxNach.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(131, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Zeit :";
            // 
            // lblVon2
            // 
            this.lblVon2.AutoSize = true;
            this.lblVon2.Location = new System.Drawing.Point(9, 24);
            this.lblVon2.Name = "lblVon2";
            this.lblVon2.Size = new System.Drawing.Size(32, 13);
            this.lblVon2.TabIndex = 2;
            this.lblVon2.Text = "Von :";
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(6, 24);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(35, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von : ";
            // 
            // lblAbfahrtstafel
            // 
            this.lblAbfahrtstafel.AutoSize = true;
            this.lblAbfahrtstafel.Location = new System.Drawing.Point(100, 28);
            this.lblAbfahrtstafel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbfahrtstafel.Name = "lblAbfahrtstafel";
            this.lblAbfahrtstafel.Size = new System.Drawing.Size(66, 13);
            this.lblAbfahrtstafel.TabIndex = 5;
            this.lblAbfahrtstafel.Text = "Abfahrtstafel";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(6, 24);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(46, 13);
            this.lblStation.TabIndex = 2;
            this.lblStation.Text = "Station :";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(250, 24);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(33, 13);
            this.lblNach.TabIndex = 0;
            this.lblNach.Text = "Nach";
            // 
            // lblLaden
            // 
            this.lblLaden.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom)
                                                        | System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLaden.AutoSize = true;
            this.lblLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLaden.Location = new System.Drawing.Point(359, 165);
            this.lblLaden.Name = "lblLaden";
            this.lblLaden.Size = new System.Drawing.Size(98, 31);
            this.lblLaden.TabIndex = 1;
            this.lblLaden.Text = "Lädt...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Datum :";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(131, 92);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(75, 20);
            this.dtpTime.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(6, 92);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(119, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // dtgVerbindungen
            // 
            this.dtgVerbindungen.AllowUserToAddRows = false;
            this.dtgVerbindungen.AllowUserToDeleteRows = false;
            this.dtgVerbindungen.AllowUserToResizeRows = false;
            this.dtgVerbindungen.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom)
                                                        | System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVerbindungen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVerbindungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgVerbindungen.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVerbindungen.Cursor = System.Windows.Forms.Cursors.No;
            this.dtgVerbindungen.Location = new System.Drawing.Point(13, 18);
            this.dtgVerbindungen.Margin = new System.Windows.Forms.Padding(2);
            this.dtgVerbindungen.Name = "dtgVerbindungen";
            this.dtgVerbindungen.ReadOnly = true;
            this.dtgVerbindungen.Size = new System.Drawing.Size(911, 305);
            this.dtgVerbindungen.TabIndex = 0;
            // 
            // dtgVerbindungen2
            // 
            this.dtgVerbindungen2.AllowUserToAddRows = false;
            this.dtgVerbindungen2.AllowUserToDeleteRows = false;
            this.dtgVerbindungen2.AllowUserToResizeRows = false;
            this.dtgVerbindungen2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom)
                                                        | System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVerbindungen2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgVerbindungen2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgVerbindungen2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVerbindungen2.Cursor = System.Windows.Forms.Cursors.No;
            this.dtgVerbindungen2.Location = new System.Drawing.Point(9, 24);
            this.dtgVerbindungen2.Name = "dtgVerbindungen2";
            this.dtgVerbindungen2.ReadOnly = true;
            this.dtgVerbindungen2.Size = new System.Drawing.Size(481, 263);
            this.dtgVerbindungen2.TabIndex = 0;
            // 
            // btnVon2
            // 
            this.btnVon2.BackColor = System.Drawing.SystemColors.Window;
            this.btnVon2.Location = new System.Drawing.Point(379, 71);
            this.btnVon2.Name = "btnVon2";
            this.btnVon2.Size = new System.Drawing.Size(129, 23);
            this.btnVon2.TabIndex = 11;
            this.btnVon2.UseVisualStyleBackColor = false;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(350, 39);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(129, 23);
            this.btnSearch2.TabIndex = 12;
            this.btnSearch2.Text = "Abfahrtstafel anzeigen";
            this.btnSearch2.UseVisualStyleBackColor = true;
            // 
            // btnSuche3
            // 
            this.btnSuche3.Location = new System.Drawing.Point(370, 30);
            this.btnSuche3.Name = "btnSuche3";
            this.btnSuche3.Size = new System.Drawing.Size(129, 23);
            this.btnSuche3.TabIndex = 14;
            this.btnSuche3.Text = "Stationen zeigen";
            this.btnSuche3.UseVisualStyleBackColor = true;
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(58, 102);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(923, 665);
            this.pnl3.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(805, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 53);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnVS
            // 
            this.btnVS.Location = new System.Drawing.Point(116, 12);
            this.btnVS.Name = "btnVS";
            this.btnVS.Size = new System.Drawing.Size(146, 53);
            this.btnVS.TabIndex = 5;
            this.btnVS.Text = "Verbindung suchen";
            this.btnVS.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(338, 12);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(146, 53);
            this.btnAbfahrtstafel.TabIndex = 6;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(565, 12);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(146, 53);
            this.btnMaps.TabIndex = 9;
            this.btnMaps.Text = "Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            // 
            // pbAbfahrtstafel_Zug
            // 
            this.pbAbfahrtstafel_Zug.Image = global::Fahrplan.Properties.Resources.zug_symbol;
            this.pbAbfahrtstafel_Zug.Location = new System.Drawing.Point(21, 11);
            this.pbAbfahrtstafel_Zug.Margin = new System.Windows.Forms.Padding(2);
            this.pbAbfahrtstafel_Zug.Name = "pbAbfahrtstafel_Zug";
            this.pbAbfahrtstafel_Zug.Size = new System.Drawing.Size(75, 81);
            this.pbAbfahrtstafel_Zug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbfahrtstafel_Zug.TabIndex = 15;
            this.pbAbfahrtstafel_Zug.TabStop = false;
            // 
            // pbSwitch
            // 
            this.pbSwitch.Image = ((System.Drawing.Image) (resources.GetObject("pbSwitch.Image")));
            this.pbSwitch.Location = new System.Drawing.Point(213, 32);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(28, 31);
            this.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSwitch.TabIndex = 14;
            this.pbSwitch.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1068, 773);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnVS);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1084, 812);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1084, 812);
            this.Name = "Form1";
            this.Text = "Fahrplan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl1.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.gbSearch2.ResumeLayout(false);
            this.gbSearch3.ResumeLayout(false);
            this.gbSearch3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgVerbindungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dtgVerbindungen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbAbfahrtstafel_Zug)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbSwitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.PictureBox pbAbfahrtstafel_Zug;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button btnSearchMaps;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.GroupBox gbSearch2;
        private System.Windows.Forms.GroupBox gbSearch3;
        private System.Windows.Forms.ListBox lbxVon2;
        private System.Windows.Forms.ListBox lbxVon;
        private System.Windows.Forms.ListBox lbxStation;
        private System.Windows.Forms.ListBox lbxNach;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVon2;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblAbfahrtstafel;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblLaden;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dtgVerbindungen;
        private System.Windows.Forms.DataGridView dtgVerbindungen2;
        private System.Windows.Forms.Button btnVon2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnSuche3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVS;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.WebBrowser webGoogleMaps;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.TextBox txtNach;

        private System.Windows.Forms.TextBox txtEmail;
          
    }

}

