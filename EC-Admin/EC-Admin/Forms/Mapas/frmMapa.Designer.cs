namespace EC_Admin.Forms
{
    partial class frmMapa
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
            this.wbrMapa = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbrMapa
            // 
            this.wbrMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrMapa.Location = new System.Drawing.Point(0, 0);
            this.wbrMapa.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrMapa.Name = "wbrMapa";
            this.wbrMapa.Size = new System.Drawing.Size(884, 561);
            this.wbrMapa.TabIndex = 0;
            // 
            // frmMapa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.wbrMapa);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapas";
            this.Shown += new System.EventHandler(this.frmMapa_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbrMapa;
    }
}