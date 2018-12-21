namespace AppSwissTransport
{
    partial class Standortmaps
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
            this.webStandortMaps = new System.Windows.Forms.WebBrowser();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webStandortMaps
            // 
            this.webStandortMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webStandortMaps.Location = new System.Drawing.Point(0, 0);
            this.webStandortMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webStandortMaps.Name = "webStandortMaps";
            this.webStandortMaps.ScriptErrorsSuppressed = true;
            this.webStandortMaps.Size = new System.Drawing.Size(1904, 1041);
            this.webStandortMaps.TabIndex = 0;
            this.webStandortMaps.Url = new System.Uri("https://www.google.ch/maps/search/transit+stop+nearby/", System.UriKind.Absolute);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1704, 988);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1481, 988);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Standortmaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.webStandortMaps);
            this.Name = "Standortmaps";
            this.Text = "Standortmaps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webStandortMaps;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
    }
}