namespace EC_Admin.Forms
{
    partial class frmEditarTrabajador
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblECP = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEEstado = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblECiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblEDireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblECorreo = new System.Windows.Forms.Label();
            this.lblECelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblETelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.lblEPuesto = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblEApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.lblENumNomina = new System.Windows.Forms.Label();
            this.txtNumNomina = new System.Windows.Forms.TextBox();
            this.cboCamaras = new System.Windows.Forms.ComboBox();
            this.btnCamara = new System.Windows.Forms.Button();
            this.btnHuella = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblInfoImagen = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblESueldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(651, 446);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCP.Location = new System.Drawing.Point(542, 204);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(259, 29);
            this.txtCP.TabIndex = 23;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // lblECP
            // 
            this.lblECP.AutoSize = true;
            this.lblECP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECP.Location = new System.Drawing.Point(539, 183);
            this.lblECP.Name = "lblECP";
            this.lblECP.Size = new System.Drawing.Size(92, 18);
            this.lblECP.TabIndex = 22;
            this.lblECP.Text = "Código postal";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEstado.Location = new System.Drawing.Point(277, 204);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(259, 29);
            this.txtEstado.TabIndex = 21;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEstado.Location = new System.Drawing.Point(274, 183);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(50, 18);
            this.lblEEstado.TabIndex = 20;
            this.lblEEstado.Text = "Estado";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCiudad.Location = new System.Drawing.Point(12, 204);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(259, 29);
            this.txtCiudad.TabIndex = 19;
            // 
            // lblECiudad
            // 
            this.lblECiudad.AutoSize = true;
            this.lblECiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECiudad.Location = new System.Drawing.Point(9, 183);
            this.lblECiudad.Name = "lblECiudad";
            this.lblECiudad.Size = new System.Drawing.Size(51, 18);
            this.lblECiudad.TabIndex = 18;
            this.lblECiudad.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDireccion.Location = new System.Drawing.Point(542, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(259, 29);
            this.txtDireccion.TabIndex = 17;
            // 
            // lblEDireccion
            // 
            this.lblEDireccion.AutoSize = true;
            this.lblEDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDireccion.Location = new System.Drawing.Point(539, 125);
            this.lblEDireccion.Name = "lblEDireccion";
            this.lblEDireccion.Size = new System.Drawing.Size(66, 18);
            this.lblEDireccion.TabIndex = 16;
            this.lblEDireccion.Text = "Dirección";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(277, 146);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 15;
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(274, 125);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(121, 18);
            this.lblECorreo.TabIndex = 14;
            this.lblECorreo.Text = "Correo electrónico";
            // 
            // lblECelular
            // 
            this.lblECelular.AutoSize = true;
            this.lblECelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECelular.Location = new System.Drawing.Point(9, 125);
            this.lblECelular.Name = "lblECelular";
            this.lblECelular.Size = new System.Drawing.Size(50, 18);
            this.lblECelular.TabIndex = 12;
            this.lblECelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCelular.Location = new System.Drawing.Point(12, 146);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(259, 29);
            this.txtCelular.TabIndex = 13;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // lblETelefono
            // 
            this.lblETelefono.AutoSize = true;
            this.lblETelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono.Location = new System.Drawing.Point(539, 67);
            this.lblETelefono.Name = "lblETelefono";
            this.lblETelefono.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono.TabIndex = 10;
            this.lblETelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono.Location = new System.Drawing.Point(542, 88);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 29);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // cboPuesto
            // 
            this.cboPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPuesto.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(12, 88);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(259, 29);
            this.cboPuesto.TabIndex = 7;
            // 
            // lblEPuesto
            // 
            this.lblEPuesto.AutoSize = true;
            this.lblEPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPuesto.Location = new System.Drawing.Point(9, 67);
            this.lblEPuesto.Name = "lblEPuesto";
            this.lblEPuesto.Size = new System.Drawing.Size(51, 18);
            this.lblEPuesto.TabIndex = 6;
            this.lblEPuesto.Text = "Puesto";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtApellidos.Location = new System.Drawing.Point(542, 30);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 29);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblEApellidos
            // 
            this.lblEApellidos.AutoSize = true;
            this.lblEApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEApellidos.Location = new System.Drawing.Point(539, 9);
            this.lblEApellidos.Name = "lblEApellidos";
            this.lblEApellidos.Size = new System.Drawing.Size(64, 18);
            this.lblEApellidos.TabIndex = 4;
            this.lblEApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(277, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(274, 9);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 2;
            this.lblENombre.Text = "Nombre";
            // 
            // cboSucursal
            // 
            this.cboSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(12, 30);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(259, 29);
            this.cboSucursal.TabIndex = 1;
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESucursal.Location = new System.Drawing.Point(9, 9);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 0;
            this.lblESucursal.Text = "Sucursal";
            // 
            // lblENumNomina
            // 
            this.lblENumNomina.AutoSize = true;
            this.lblENumNomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumNomina.Location = new System.Drawing.Point(274, 67);
            this.lblENumNomina.Name = "lblENumNomina";
            this.lblENumNomina.Size = new System.Drawing.Size(125, 18);
            this.lblENumNomina.TabIndex = 8;
            this.lblENumNomina.Text = "Número de nómina";
            // 
            // txtNumNomina
            // 
            this.txtNumNomina.BackColor = System.Drawing.Color.White;
            this.txtNumNomina.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumNomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumNomina.Location = new System.Drawing.Point(277, 88);
            this.txtNumNomina.Name = "txtNumNomina";
            this.txtNumNomina.Size = new System.Drawing.Size(259, 29);
            this.txtNumNomina.TabIndex = 9;
            // 
            // cboCamaras
            // 
            this.cboCamaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamaras.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboCamaras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboCamaras.FormattingEnabled = true;
            this.cboCamaras.Location = new System.Drawing.Point(277, 449);
            this.cboCamaras.Name = "cboCamaras";
            this.cboCamaras.Size = new System.Drawing.Size(259, 29);
            this.cboCamaras.TabIndex = 30;
            // 
            // btnCamara
            // 
            this.btnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCamara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnCamara.ForeColor = System.Drawing.Color.White;
            this.btnCamara.Location = new System.Drawing.Point(174, 448);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(97, 30);
            this.btnCamara.TabIndex = 29;
            this.btnCamara.Text = "Tomar foto";
            this.btnCamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // btnHuella
            // 
            this.btnHuella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuella.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnHuella.FlatAppearance.BorderSize = 0;
            this.btnHuella.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnHuella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnHuella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuella.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnHuella.ForeColor = System.Drawing.Color.White;
            this.btnHuella.Location = new System.Drawing.Point(174, 376);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(97, 30);
            this.btnHuella.TabIndex = 27;
            this.btnHuella.Text = "Asignar huella";
            this.btnHuella.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuella.UseVisualStyleBackColor = false;
            this.btnHuella.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(174, 412);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar.TabIndex = 28;
            this.btnQuitar.Text = "Quitar imagen";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInfoImagen
            // 
            this.lblInfoImagen.AutoSize = true;
            this.lblInfoImagen.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfoImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfoImagen.Location = new System.Drawing.Point(9, 481);
            this.lblInfoImagen.Name = "lblInfoImagen";
            this.lblInfoImagen.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen.TabIndex = 26;
            this.lblInfoImagen.Text = "Clic para cambiar la imagen";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen.Location = new System.Drawing.Point(12, 322);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 33;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.White;
            this.txtSueldo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtSueldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtSueldo.Location = new System.Drawing.Point(12, 262);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(259, 29);
            this.txtSueldo.TabIndex = 25;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            // 
            // lblESueldo
            // 
            this.lblESueldo.AutoSize = true;
            this.lblESueldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESueldo.Location = new System.Drawing.Point(9, 241);
            this.lblESueldo.Name = "lblESueldo";
            this.lblESueldo.Size = new System.Drawing.Size(50, 18);
            this.lblESueldo.TabIndex = 24;
            this.lblESueldo.Text = "Sueldo";
            // 
            // frmEditarTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 504);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblESueldo);
            this.Controls.Add(this.cboCamaras);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblInfoImagen);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lblENumNomina);
            this.Controls.Add(this.txtNumNomina);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblECP);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblECiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblEDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblECorreo);
            this.Controls.Add(this.lblECelular);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblETelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.lblEPuesto);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblEApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblENombre);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.lblESucursal);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditarTrabajador";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar datos de";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarTrabajador_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblECP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblECiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblEDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblECorreo;
        private System.Windows.Forms.Label lblECelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblETelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.Label lblEPuesto;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblEApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.Label lblENumNomina;
        private System.Windows.Forms.TextBox txtNumNomina;
        private System.Windows.Forms.ComboBox cboCamaras;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblInfoImagen;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblESueldo;
    }
}