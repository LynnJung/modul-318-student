namespace AppSwissTransport
{
    partial class Abfahrtstafel
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
            this.cbAbfahrt = new System.Windows.Forms.ComboBox();
            this.dgrdAbfahrtsTafel = new System.Windows.Forms.DataGridView();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.gbVerbindungen = new System.Windows.Forms.GroupBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAbfahrtsTafel)).BeginInit();
            this.gbVerbindungen.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(28, 57);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(89, 13);
            this.lblVon.TabIndex = 0;
            this.lblVon.Text = "Von (Abfahrtsort):";
            // 
            // cbAbfahrt
            // 
            this.cbAbfahrt.FormattingEnabled = true;
            this.cbAbfahrt.Location = new System.Drawing.Point(136, 57);
            this.cbAbfahrt.Name = "cbAbfahrt";
            this.cbAbfahrt.Size = new System.Drawing.Size(121, 21);
            this.cbAbfahrt.TabIndex = 0;
            this.cbAbfahrt.SelectedIndexChanged += new System.EventHandler(this.cbAbfahrt_SelectedIndexChanged);
            // 
            // dgrdAbfahrtsTafel
            // 
            this.dgrdAbfahrtsTafel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrdAbfahrtsTafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdAbfahrtsTafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ankunftsort,
            this.Abfahrtszeit});
            this.dgrdAbfahrtsTafel.Location = new System.Drawing.Point(99, 19);
            this.dgrdAbfahrtsTafel.Name = "dgrdAbfahrtsTafel";
            this.dgrdAbfahrtsTafel.Size = new System.Drawing.Size(309, 185);
            this.dgrdAbfahrtsTafel.TabIndex = 2;
            this.dgrdAbfahrtsTafel.Visible = false;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.Name = "Ankunftsort";
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(124, 85);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(121, 23);
            this.btnSuche.TabIndex = 2;
            this.btnSuche.Text = "Suche";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click_1);
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(305, 57);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(75, 23);
            this.btnAutoFill.TabIndex = 1;
            this.btnAutoFill.Text = "Ort suchen";
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Click += new System.EventHandler(this.btnAutoFill_Click);
            // 
            // gbVerbindungen
            // 
            this.gbVerbindungen.Controls.Add(this.dgrdAbfahrtsTafel);
            this.gbVerbindungen.Location = new System.Drawing.Point(12, 146);
            this.gbVerbindungen.Name = "gbVerbindungen";
            this.gbVerbindungen.Size = new System.Drawing.Size(414, 210);
            this.gbVerbindungen.TabIndex = 3;
            this.gbVerbindungen.TabStop = false;
            this.gbVerbindungen.Text = "Verbindungen";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSuche);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(560, 128);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Suche ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(451, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(451, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 375);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAutoFill);
            this.Controls.Add(this.cbAbfahrt);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbVerbindungen);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAbfahrtsTafel)).EndInit();
            this.gbVerbindungen.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.ComboBox cbAbfahrt;
        private System.Windows.Forms.DataGridView dgrdAbfahrtsTafel;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.GroupBox gbVerbindungen;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
    }
}