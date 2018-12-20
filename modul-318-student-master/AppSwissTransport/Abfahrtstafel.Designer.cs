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
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAbfahrtsTafel)).BeginInit();
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
            // 
            // dgrdAbfahrtsTafel
            // 
            this.dgrdAbfahrtsTafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdAbfahrtsTafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ankunftsort,
            this.Abfahrtszeit});
            this.dgrdAbfahrtsTafel.Location = new System.Drawing.Point(94, 146);
            this.dgrdAbfahrtsTafel.Name = "dgrdAbfahrtsTafel";
            this.dgrdAbfahrtsTafel.Size = new System.Drawing.Size(286, 150);
            this.dgrdAbfahrtsTafel.TabIndex = 2;
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
            this.btnSuche.Location = new System.Drawing.Point(136, 106);
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
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 375);
            this.Controls.Add(this.btnAutoFill);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.dgrdAbfahrtsTafel);
            this.Controls.Add(this.cbAbfahrt);
            this.Controls.Add(this.lblVon);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAbfahrtsTafel)).EndInit();
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
    }
}