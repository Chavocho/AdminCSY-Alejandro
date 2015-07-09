namespace EC_Admin.Forms
{
    partial class frmDetalleProductoDevolucion
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
            this.pcbProducto = new System.Windows.Forms.PictureBox();
            this.lblECodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblEMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbProducto
            // 
            this.pcbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbProducto.Enabled = false;
            this.pcbProducto.Location = new System.Drawing.Point(12, 70);
            this.pcbProducto.Name = "pcbProducto";
            this.pcbProducto.Size = new System.Drawing.Size(200, 200);
            this.pcbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProducto.TabIndex = 38;
            this.pcbProducto.TabStop = false;
            // 
            // lblECodigo
            // 
            this.lblECodigo.AutoSize = true;
            this.lblECodigo.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblECodigo.Location = new System.Drawing.Point(12, 9);
            this.lblECodigo.Name = "lblECodigo";
            this.lblECodigo.Size = new System.Drawing.Size(65, 22);
            this.lblECodigo.TabIndex = 39;
            this.lblECodigo.Text = "Código";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblCodigo.Location = new System.Drawing.Point(12, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 22);
            this.lblCodigo.TabIndex = 40;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblMarca.Location = new System.Drawing.Point(377, 36);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 22);
            this.lblMarca.TabIndex = 42;
            // 
            // lblEMarca
            // 
            this.lblEMarca.AutoSize = true;
            this.lblEMarca.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEMarca.Location = new System.Drawing.Point(377, 9);
            this.lblEMarca.Name = "lblEMarca";
            this.lblEMarca.Size = new System.Drawing.Size(57, 22);
            this.lblEMarca.TabIndex = 41;
            this.lblEMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblPrecio.Location = new System.Drawing.Point(223, 97);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 22);
            this.lblPrecio.TabIndex = 44;
            // 
            // lblEPrecio
            // 
            this.lblEPrecio.AutoSize = true;
            this.lblEPrecio.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEPrecio.Location = new System.Drawing.Point(223, 70);
            this.lblEPrecio.Name = "lblEPrecio";
            this.lblEPrecio.Size = new System.Drawing.Size(58, 22);
            this.lblEPrecio.TabIndex = 43;
            this.lblEPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblDescripcion.Location = new System.Drawing.Point(377, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(438, 173);
            this.lblDescripcion.TabIndex = 46;
            // 
            // lblEDescripcion
            // 
            this.lblEDescripcion.AutoSize = true;
            this.lblEDescripcion.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEDescripcion.Location = new System.Drawing.Point(377, 70);
            this.lblEDescripcion.Name = "lblEDescripcion";
            this.lblEDescripcion.Size = new System.Drawing.Size(99, 22);
            this.lblEDescripcion.TabIndex = 45;
            this.lblEDescripcion.Text = "Descripción";
            // 
            // frmDetalleProductoDevolucion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 282);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblEDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblEPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblEMarca);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblECodigo);
            this.Controls.Add(this.pcbProducto);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetalleProductoDevolucion";
            this.Text = "Detalles de producto - ";
            this.Load += new System.EventHandler(this.frmDetalleProductoDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbProducto;
        private System.Windows.Forms.Label lblECodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblEMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEDescripcion;
    }
}