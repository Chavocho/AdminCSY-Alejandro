namespace EC_Admin.Forms
{
    partial class frmIngreso
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblEBusqueda = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblENombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEHoraES = new System.Windows.Forms.Label();
            this.lblHoraES = new System.Windows.Forms.Label();
            this.lblEHoraActual = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.lblEEstatus = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.pnlInfoTrabajador = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.pnlInfoTrabajador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.Location = new System.Drawing.Point(649, 285);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(296, 29);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // lblEBusqueda
            // 
            this.lblEBusqueda.AutoSize = true;
            this.lblEBusqueda.Location = new System.Drawing.Point(301, 290);
            this.lblEBusqueda.Name = "lblEBusqueda";
            this.lblEBusqueda.Size = new System.Drawing.Size(342, 18);
            this.lblEBusqueda.TabIndex = 2;
            this.lblEBusqueda.Text = "Ingrese su número de nómina o ingrese su huella digital";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen.Location = new System.Drawing.Point(12, 12);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(255, 255);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 0;
            this.pcbImagen.TabStop = false;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblENombre.Location = new System.Drawing.Point(340, 12);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(87, 24);
            this.lblENombre.TabIndex = 1;
            this.lblENombre.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblNombre.Location = new System.Drawing.Point(433, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(261, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Héctor Alejandro Peña Gomez";
            // 
            // lblEHoraES
            // 
            this.lblEHoraES.AutoSize = true;
            this.lblEHoraES.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblEHoraES.Location = new System.Drawing.Point(273, 51);
            this.lblEHoraES.Name = "lblEHoraES";
            this.lblEHoraES.Size = new System.Drawing.Size(154, 24);
            this.lblEHoraES.TabIndex = 3;
            this.lblEHoraES.Text = "Hora de entrada:";
            // 
            // lblHoraES
            // 
            this.lblHoraES.AutoSize = true;
            this.lblHoraES.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblHoraES.Location = new System.Drawing.Point(433, 51);
            this.lblHoraES.Name = "lblHoraES";
            this.lblHoraES.Size = new System.Drawing.Size(95, 24);
            this.lblHoraES.TabIndex = 4;
            this.lblHoraES.Text = "10:00 a.m.";
            // 
            // lblEHoraActual
            // 
            this.lblEHoraActual.AutoSize = true;
            this.lblEHoraActual.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblEHoraActual.Location = new System.Drawing.Point(312, 90);
            this.lblEHoraActual.Name = "lblEHoraActual";
            this.lblEHoraActual.Size = new System.Drawing.Size(115, 24);
            this.lblEHoraActual.TabIndex = 5;
            this.lblEHoraActual.Text = "Hora actual:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblHoraActual.Location = new System.Drawing.Point(433, 90);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(95, 24);
            this.lblHoraActual.TabIndex = 6;
            this.lblHoraActual.Text = "09:47 a.m.";
            // 
            // lblEEstatus
            // 
            this.lblEEstatus.AutoSize = true;
            this.lblEEstatus.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblEEstatus.Location = new System.Drawing.Point(347, 129);
            this.lblEEstatus.Name = "lblEEstatus";
            this.lblEEstatus.Size = new System.Drawing.Size(80, 24);
            this.lblEEstatus.TabIndex = 7;
            this.lblEEstatus.Text = "Estatus:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.lblEstatus.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEstatus.ForeColor = System.Drawing.Color.White;
            this.lblEstatus.Location = new System.Drawing.Point(433, 129);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(37, 24);
            this.lblEstatus.TabIndex = 8;
            this.lblEstatus.Text = "OK";
            // 
            // pnlInfoTrabajador
            // 
            this.pnlInfoTrabajador.Controls.Add(this.lblEstatus);
            this.pnlInfoTrabajador.Controls.Add(this.lblEEstatus);
            this.pnlInfoTrabajador.Controls.Add(this.lblHoraActual);
            this.pnlInfoTrabajador.Controls.Add(this.lblEHoraActual);
            this.pnlInfoTrabajador.Controls.Add(this.lblHoraES);
            this.pnlInfoTrabajador.Controls.Add(this.lblEHoraES);
            this.pnlInfoTrabajador.Controls.Add(this.lblNombre);
            this.pnlInfoTrabajador.Controls.Add(this.lblENombre);
            this.pnlInfoTrabajador.Controls.Add(this.pcbImagen);
            this.pnlInfoTrabajador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoTrabajador.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoTrabajador.Name = "pnlInfoTrabajador";
            this.pnlInfoTrabajador.Size = new System.Drawing.Size(957, 279);
            this.pnlInfoTrabajador.TabIndex = 0;
            // 
            // frmIngreso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 326);
            this.Controls.Add(this.lblEBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.pnlInfoTrabajador);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de trabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.pnlInfoTrabajador.ResumeLayout(false);
            this.pnlInfoTrabajador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblEBusqueda;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEHoraES;
        private System.Windows.Forms.Label lblHoraES;
        private System.Windows.Forms.Label lblEHoraActual;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Label lblEEstatus;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Panel pnlInfoTrabajador;
    }
}