namespace EC_Admin.Forms
{
    partial class frmContactosProveedor
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
            this.pnlContactos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlContactos
            // 
            this.pnlContactos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContactos.Location = new System.Drawing.Point(0, 0);
            this.pnlContactos.Name = "pnlContactos";
            this.pnlContactos.Size = new System.Drawing.Size(784, 262);
            this.pnlContactos.TabIndex = 0;
            // 
            // frmContactosProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 262);
            this.Controls.Add(this.pnlContactos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContactosProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos de";
            this.Load += new System.EventHandler(this.frmContactosProveedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContactos;
    }
}