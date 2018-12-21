namespace AppSwissTransport
{
    partial class Maps
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
            this.webGoogle = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webGoogle
            // 
            this.webGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webGoogle.Location = new System.Drawing.Point(0, 0);
            this.webGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGoogle.Name = "webGoogle";
            this.webGoogle.ScriptErrorsSuppressed = true;
            this.webGoogle.Size = new System.Drawing.Size(1904, 1041);
            this.webGoogle.TabIndex = 0;
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.webGoogle);
            this.Name = "Maps";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.Maps_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webGoogle;
    }
}