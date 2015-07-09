namespace EC_Admin.Forms
{
    partial class frmNuevaPromocion
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
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblECantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblEPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEFechaIni = new System.Windows.Forms.Label();
            this.chbExistencias = new System.Windows.Forms.CheckBox();
            this.lblEProducto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.lblEExistencias = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblEMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.White;
            this.txtCant.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCant.Location = new System.Drawing.Point(277, 170);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(259, 29);
            this.txtCant.TabIndex = 15;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCant_KeyPress);
            // 
            // lblECantidad
            // 
            this.lblECantidad.AutoSize = true;
            this.lblECantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECantidad.Location = new System.Drawing.Point(274, 149);
            this.lblECantidad.Name = "lblECantidad";
            this.lblECantidad.Size = new System.Drawing.Size(241, 18);
            this.lblECantidad.TabIndex = 14;
            this.lblECantidad.Text = "Cantidad de productos por promoción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPrecio.Location = new System.Drawing.Point(12, 170);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(259, 29);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblEPrecio
            // 
            this.lblEPrecio.AutoSize = true;
            this.lblEPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecio.Location = new System.Drawing.Point(9, 149);
            this.lblEPrecio.Name = "lblEPrecio";
            this.lblEPrecio.Size = new System.Drawing.Size(47, 18);
            this.lblEPrecio.TabIndex = 12;
            this.lblEPrecio.Text = "Precio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(391, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEFechaIni
            // 
            this.lblEFechaIni.AutoSize = true;
            this.lblEFechaIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaIni.Location = new System.Drawing.Point(9, 91);
            this.lblEFechaIni.Name = "lblEFechaIni";
            this.lblEFechaIni.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaIni.TabIndex = 21;
            this.lblEFechaIni.Text = "Fecha de inicio";
            // 
            // chbExistencias
            // 
            this.chbExistencias.AutoSize = true;
            this.chbExistencias.Font = new System.Drawing.Font("Corbel", 13F);
            this.chbExistencias.Location = new System.Drawing.Point(12, 62);
            this.chbExistencias.Name = "chbExistencias";
            this.chbExistencias.Size = new System.Drawing.Size(296, 26);
            this.chbExistencias.TabIndex = 22;
            this.chbExistencias.Text = "Promoción hasta agotar existencias";
            this.chbExistencias.UseVisualStyleBackColor = true;
            this.chbExistencias.CheckedChanged += new System.EventHandler(this.chbExistencias_CheckedChanged);
            // 
            // lblEProducto
            // 
            this.lblEProducto.AutoSize = true;
            this.lblEProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEProducto.Location = new System.Drawing.Point(12, 9);
            this.lblEProducto.Name = "lblEProducto";
            this.lblEProducto.Size = new System.Drawing.Size(70, 18);
            this.lblEProducto.TabIndex = 23;
            this.lblEProducto.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblProducto.Location = new System.Drawing.Point(88, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 18);
            this.lblProducto.TabIndex = 24;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(439, 30);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(97, 30);
            this.btnProducto.TabIndex = 25;
            this.btnProducto.Text = "Buscar producto";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaIni.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(12, 112);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaIni.TabIndex = 26;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(277, 112);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaFin.TabIndex = 28;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(274, 91);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 27;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // txtExistencias
            // 
            this.txtExistencias.BackColor = System.Drawing.Color.White;
            this.txtExistencias.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtExistencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtExistencias.Location = new System.Drawing.Point(12, 228);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(259, 29);
            this.txtExistencias.TabIndex = 30;
            // 
            // lblEExistencias
            // 
            this.lblEExistencias.AutoSize = true;
            this.lblEExistencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEExistencias.Location = new System.Drawing.Point(9, 207);
            this.lblEExistencias.Name = "lblEExistencias";
            this.lblEExistencias.Size = new System.Drawing.Size(75, 18);
            this.lblEExistencias.TabIndex = 29;
            this.lblEExistencias.Text = "Existencias";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblMarca.Location = new System.Drawing.Point(88, 35);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 18);
            this.lblMarca.TabIndex = 32;
            // 
            // lblEMarca
            // 
            this.lblEMarca.AutoSize = true;
            this.lblEMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEMarca.Location = new System.Drawing.Point(12, 35);
            this.lblEMarca.Name = "lblEMarca";
            this.lblEMarca.Size = new System.Drawing.Size(46, 18);
            this.lblEMarca.TabIndex = 31;
            this.lblEMarca.Text = "Marca";
            // 
            // frmNuevaPromocion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 335);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblEMarca);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.lblEExistencias);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblEFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblEProducto);
            this.Controls.Add(this.chbExistencias);
            this.Controls.Add(this.lblEFechaIni);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblECantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblEPrecio);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaPromocion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear promoción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblECantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblEPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEFechaIni;
        private System.Windows.Forms.CheckBox chbExistencias;
        private System.Windows.Forms.Label lblEProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblEFechaFin;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label lblEExistencias;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblEMarca;
    }
}