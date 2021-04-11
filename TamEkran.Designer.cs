
namespace FilmArsivi
{
    partial class Tamekran
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
            this.wb2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wb2
            // 
            this.wb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb2.Location = new System.Drawing.Point(0, 0);
            this.wb2.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb2.Name = "wb2";
            this.wb2.Size = new System.Drawing.Size(477, 383);
            this.wb2.TabIndex = 0;
            // 
            // Tamekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 383);
            this.Controls.Add(this.wb2);
            this.Name = "Tamekran";
            this.Text = "Full";
            this.Load += new System.EventHandler(this.Tamekran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb2;
    }
}