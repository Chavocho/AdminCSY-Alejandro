namespace EC_Admin
{
    partial class frmMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensaje));
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pcbIcono = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlMensaje = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).BeginInit();
            this.pnlMensaje.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.pnlImagen.Controls.Add(this.pcbIcono);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(180, 180);
            this.pnlImagen.TabIndex = 2;
            this.pnlImagen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // pcbIcono
            // 
            this.pcbIcono.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcono.Image")));
            this.pcbIcono.Location = new System.Drawing.Point(0, 0);
            this.pcbIcono.Name = "pcbIcono";
            this.pcbIcono.Size = new System.Drawing.Size(180, 180);
            this.pcbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcono.TabIndex = 0;
            this.pcbIcono.TabStop = false;
            this.pcbIcono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(6, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 18);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // pnlMensaje
            // 
            this.pnlMensaje.BackColor = System.Drawing.Color.White;
            this.pnlMensaje.Controls.Add(this.lblMensaje);
            this.pnlMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMensaje.Location = new System.Drawing.Point(180, 30);
            this.pnlMensaje.Name = "pnlMensaje";
            this.pnlMensaje.Size = new System.Drawing.Size(450, 150);
            this.pnlMensaje.TabIndex = 1;
            this.pnlMensaje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.lblCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(180, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(450, 30);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Este es un titulo";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmError_MouseDown);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCerrar.Location = new System.Drawing.Point(424, 4);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(21, 22);
            this.lblCerrar.TabIndex = 1;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            this.lblCerrar.MouseEnter += new System.EventHandler(this.lblCerrar_MouseEnter);
            this.lblCerrar.MouseLeave += new System.EventHandler(this.lblCerrar_MouseLeave);
            // 
            // frmMensaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 180);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMensaje);
            this.Controls.Add(this.pnlImagen);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMensaje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmError_Load);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcono)).EndInit();
            this.pnlMensaje.ResumeLayout(false);
            this.pnlMensaje.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.PictureBox pcbIcono;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlMensaje;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label lblTitulo;
    }
}