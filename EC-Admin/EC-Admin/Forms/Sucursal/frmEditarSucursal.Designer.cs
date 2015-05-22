namespace EC_Admin.Forms
{
    partial class frmEditarSucursal
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
            this.btnQuitar = new System.Windows.Forms.Button();
            this.lblInfoImagen = new System.Windows.Forms.Label();
            this.pcbLogotipo = new System.Windows.Forms.PictureBox();
            this.grbFiscal = new System.Windows.Forms.GroupBox();
            this.lblFColonia = new System.Windows.Forms.Label();
            this.lblFEstado = new System.Windows.Forms.Label();
            this.lblFCiudad = new System.Windows.Forms.Label();
            this.lblFCP = new System.Windows.Forms.Label();
            this.lblFNumInt = new System.Windows.Forms.Label();
            this.lblFNumExt = new System.Windows.Forms.Label();
            this.lblFCalle = new System.Windows.Forms.Label();
            this.btnAsignarDomicilio = new System.Windows.Forms.Button();
            this.lblEFColonia = new System.Windows.Forms.Label();
            this.lblEFEstado = new System.Windows.Forms.Label();
            this.lblEFCiudad = new System.Windows.Forms.Label();
            this.lblEFCP = new System.Windows.Forms.Label();
            this.lblEFNumInt = new System.Windows.Forms.Label();
            this.lblEFNumExt = new System.Windows.Forms.Label();
            this.lblEFCalle = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblEWeb = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblECorreo = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblEFax = new System.Windows.Forms.Label();
            this.lblETelefono02 = new System.Windows.Forms.Label();
            this.lblETelefono01 = new System.Windows.Forms.Label();
            this.txtTelefono02 = new System.Windows.Forms.TextBox();
            this.txtTelefono01 = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblEColonia = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEEstado = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblECiudad = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblECP = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.lblENumInt = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.lblENumExt = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblECalle = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblERFC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).BeginInit();
            this.grbFiscal.SuspendLayout();
            this.SuspendLayout();
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
            this.btnQuitar.Location = new System.Drawing.Point(193, 635);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar.TabIndex = 30;
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
            this.lblInfoImagen.Location = new System.Drawing.Point(9, 668);
            this.lblInfoImagen.Name = "lblInfoImagen";
            this.lblInfoImagen.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen.TabIndex = 29;
            this.lblInfoImagen.Text = "Clic para cambiar la imagen";
            // 
            // pcbLogotipo
            // 
            this.pcbLogotipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbLogotipo.Location = new System.Drawing.Point(12, 490);
            this.pcbLogotipo.Name = "pcbLogotipo";
            this.pcbLogotipo.Size = new System.Drawing.Size(175, 175);
            this.pcbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogotipo.TabIndex = 195;
            this.pcbLogotipo.TabStop = false;
            this.pcbLogotipo.Click += new System.EventHandler(this.pcbLogotipo_Click);
            // 
            // grbFiscal
            // 
            this.grbFiscal.Controls.Add(this.lblFColonia);
            this.grbFiscal.Controls.Add(this.lblFEstado);
            this.grbFiscal.Controls.Add(this.lblFCiudad);
            this.grbFiscal.Controls.Add(this.lblFCP);
            this.grbFiscal.Controls.Add(this.lblFNumInt);
            this.grbFiscal.Controls.Add(this.lblFNumExt);
            this.grbFiscal.Controls.Add(this.lblFCalle);
            this.grbFiscal.Controls.Add(this.btnAsignarDomicilio);
            this.grbFiscal.Controls.Add(this.lblEFColonia);
            this.grbFiscal.Controls.Add(this.lblEFEstado);
            this.grbFiscal.Controls.Add(this.lblEFCiudad);
            this.grbFiscal.Controls.Add(this.lblEFCP);
            this.grbFiscal.Controls.Add(this.lblEFNumInt);
            this.grbFiscal.Controls.Add(this.lblEFNumExt);
            this.grbFiscal.Controls.Add(this.lblEFCalle);
            this.grbFiscal.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFiscal.Location = new System.Drawing.Point(0, 297);
            this.grbFiscal.Name = "grbFiscal";
            this.grbFiscal.Size = new System.Drawing.Size(813, 187);
            this.grbFiscal.TabIndex = 28;
            this.grbFiscal.TabStop = false;
            this.grbFiscal.Text = "Domicilio fiscal";
            this.grbFiscal.Visible = false;
            // 
            // lblFColonia
            // 
            this.lblFColonia.AutoSize = true;
            this.lblFColonia.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFColonia.Location = new System.Drawing.Point(8, 99);
            this.lblFColonia.Name = "lblFColonia";
            this.lblFColonia.Size = new System.Drawing.Size(0, 22);
            this.lblFColonia.TabIndex = 9;
            // 
            // lblFEstado
            // 
            this.lblFEstado.AutoSize = true;
            this.lblFEstado.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFEstado.Location = new System.Drawing.Point(538, 99);
            this.lblFEstado.Name = "lblFEstado";
            this.lblFEstado.Size = new System.Drawing.Size(0, 22);
            this.lblFEstado.TabIndex = 13;
            // 
            // lblFCiudad
            // 
            this.lblFCiudad.AutoSize = true;
            this.lblFCiudad.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFCiudad.Location = new System.Drawing.Point(273, 99);
            this.lblFCiudad.Name = "lblFCiudad";
            this.lblFCiudad.Size = new System.Drawing.Size(0, 22);
            this.lblFCiudad.TabIndex = 11;
            // 
            // lblFCP
            // 
            this.lblFCP.AutoSize = true;
            this.lblFCP.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFCP.Location = new System.Drawing.Point(538, 41);
            this.lblFCP.Name = "lblFCP";
            this.lblFCP.Size = new System.Drawing.Size(0, 22);
            this.lblFCP.TabIndex = 7;
            // 
            // lblFNumInt
            // 
            this.lblFNumInt.AutoSize = true;
            this.lblFNumInt.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFNumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFNumInt.Location = new System.Drawing.Point(404, 41);
            this.lblFNumInt.Name = "lblFNumInt";
            this.lblFNumInt.Size = new System.Drawing.Size(0, 22);
            this.lblFNumInt.TabIndex = 5;
            // 
            // lblFNumExt
            // 
            this.lblFNumExt.AutoSize = true;
            this.lblFNumExt.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFNumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFNumExt.Location = new System.Drawing.Point(273, 41);
            this.lblFNumExt.Name = "lblFNumExt";
            this.lblFNumExt.Size = new System.Drawing.Size(0, 22);
            this.lblFNumExt.TabIndex = 3;
            // 
            // lblFCalle
            // 
            this.lblFCalle.AutoSize = true;
            this.lblFCalle.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblFCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblFCalle.Location = new System.Drawing.Point(8, 41);
            this.lblFCalle.Name = "lblFCalle";
            this.lblFCalle.Size = new System.Drawing.Size(0, 22);
            this.lblFCalle.TabIndex = 1;
            // 
            // btnAsignarDomicilio
            // 
            this.btnAsignarDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignarDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAsignarDomicilio.FlatAppearance.BorderSize = 0;
            this.btnAsignarDomicilio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAsignarDomicilio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAsignarDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarDomicilio.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAsignarDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnAsignarDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarDomicilio.Location = new System.Drawing.Point(651, 135);
            this.btnAsignarDomicilio.Name = "btnAsignarDomicilio";
            this.btnAsignarDomicilio.Size = new System.Drawing.Size(150, 46);
            this.btnAsignarDomicilio.TabIndex = 14;
            this.btnAsignarDomicilio.Text = "Asignar domicilio fiscal";
            this.btnAsignarDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarDomicilio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarDomicilio.UseVisualStyleBackColor = false;
            this.btnAsignarDomicilio.Click += new System.EventHandler(this.btnAsignarDomicilio_Click);
            // 
            // lblEFColonia
            // 
            this.lblEFColonia.AutoSize = true;
            this.lblEFColonia.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFColonia.Location = new System.Drawing.Point(9, 76);
            this.lblEFColonia.Name = "lblEFColonia";
            this.lblEFColonia.Size = new System.Drawing.Size(54, 18);
            this.lblEFColonia.TabIndex = 8;
            this.lblEFColonia.Text = "Colonia";
            // 
            // lblEFEstado
            // 
            this.lblEFEstado.AutoSize = true;
            this.lblEFEstado.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFEstado.Location = new System.Drawing.Point(539, 76);
            this.lblEFEstado.Name = "lblEFEstado";
            this.lblEFEstado.Size = new System.Drawing.Size(50, 18);
            this.lblEFEstado.TabIndex = 12;
            this.lblEFEstado.Text = "Estado";
            // 
            // lblEFCiudad
            // 
            this.lblEFCiudad.AutoSize = true;
            this.lblEFCiudad.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFCiudad.Location = new System.Drawing.Point(274, 76);
            this.lblEFCiudad.Name = "lblEFCiudad";
            this.lblEFCiudad.Size = new System.Drawing.Size(51, 18);
            this.lblEFCiudad.TabIndex = 10;
            this.lblEFCiudad.Text = "Ciudad";
            // 
            // lblEFCP
            // 
            this.lblEFCP.AutoSize = true;
            this.lblEFCP.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFCP.Location = new System.Drawing.Point(539, 18);
            this.lblEFCP.Name = "lblEFCP";
            this.lblEFCP.Size = new System.Drawing.Size(92, 18);
            this.lblEFCP.TabIndex = 6;
            this.lblEFCP.Text = "Código postal";
            // 
            // lblEFNumInt
            // 
            this.lblEFNumInt.AutoSize = true;
            this.lblEFNumInt.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFNumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFNumInt.Location = new System.Drawing.Point(405, 18);
            this.lblEFNumInt.Name = "lblEFNumInt";
            this.lblEFNumInt.Size = new System.Drawing.Size(105, 18);
            this.lblEFNumInt.TabIndex = 4;
            this.lblEFNumInt.Text = "Número interior";
            // 
            // lblEFNumExt
            // 
            this.lblEFNumExt.AutoSize = true;
            this.lblEFNumExt.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFNumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFNumExt.Location = new System.Drawing.Point(274, 18);
            this.lblEFNumExt.Name = "lblEFNumExt";
            this.lblEFNumExt.Size = new System.Drawing.Size(108, 18);
            this.lblEFNumExt.TabIndex = 2;
            this.lblEFNumExt.Text = "Número exterior";
            // 
            // lblEFCalle
            // 
            this.lblEFCalle.AutoSize = true;
            this.lblEFCalle.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFCalle.Location = new System.Drawing.Point(9, 18);
            this.lblEFCalle.Name = "lblEFCalle";
            this.lblEFCalle.Size = new System.Drawing.Size(37, 18);
            this.lblEFCalle.TabIndex = 0;
            this.lblEFCalle.Text = "Calle";
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
            this.btnAceptar.Location = new System.Drawing.Point(651, 630);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.Color.White;
            this.txtWeb.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtWeb.Location = new System.Drawing.Point(277, 262);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(259, 29);
            this.txtWeb.TabIndex = 27;
            // 
            // lblEWeb
            // 
            this.lblEWeb.AutoSize = true;
            this.lblEWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEWeb.Location = new System.Drawing.Point(274, 241);
            this.lblEWeb.Name = "lblEWeb";
            this.lblEWeb.Size = new System.Drawing.Size(79, 18);
            this.lblEWeb.TabIndex = 26;
            this.lblEWeb.Text = "Página web";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(12, 262);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 25;
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(9, 241);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(121, 18);
            this.lblECorreo.TabIndex = 24;
            this.lblECorreo.Text = "Correo electrónico";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.White;
            this.txtFax.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtFax.Location = new System.Drawing.Point(542, 204);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(259, 29);
            this.txtFax.TabIndex = 23;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // lblEFax
            // 
            this.lblEFax.AutoSize = true;
            this.lblEFax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFax.Location = new System.Drawing.Point(539, 183);
            this.lblEFax.Name = "lblEFax";
            this.lblEFax.Size = new System.Drawing.Size(30, 18);
            this.lblEFax.TabIndex = 22;
            this.lblEFax.Text = "Fax";
            // 
            // lblETelefono02
            // 
            this.lblETelefono02.AutoSize = true;
            this.lblETelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono02.Location = new System.Drawing.Point(274, 183);
            this.lblETelefono02.Name = "lblETelefono02";
            this.lblETelefono02.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono02.TabIndex = 20;
            this.lblETelefono02.Text = "Teléfono";
            // 
            // lblETelefono01
            // 
            this.lblETelefono01.AutoSize = true;
            this.lblETelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono01.Location = new System.Drawing.Point(9, 183);
            this.lblETelefono01.Name = "lblETelefono01";
            this.lblETelefono01.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono01.TabIndex = 18;
            this.lblETelefono01.Text = "Teléfono";
            // 
            // txtTelefono02
            // 
            this.txtTelefono02.BackColor = System.Drawing.Color.White;
            this.txtTelefono02.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono02.Location = new System.Drawing.Point(277, 204);
            this.txtTelefono02.Name = "txtTelefono02";
            this.txtTelefono02.Size = new System.Drawing.Size(259, 29);
            this.txtTelefono02.TabIndex = 21;
            this.txtTelefono02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtTelefono01
            // 
            this.txtTelefono01.BackColor = System.Drawing.Color.White;
            this.txtTelefono01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono01.Location = new System.Drawing.Point(12, 204);
            this.txtTelefono01.Name = "txtTelefono01";
            this.txtTelefono01.Size = new System.Drawing.Size(259, 29);
            this.txtTelefono01.TabIndex = 19;
            this.txtTelefono01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtColonia.Location = new System.Drawing.Point(12, 146);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(259, 29);
            this.txtColonia.TabIndex = 13;
            // 
            // lblEColonia
            // 
            this.lblEColonia.AutoSize = true;
            this.lblEColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEColonia.Location = new System.Drawing.Point(9, 125);
            this.lblEColonia.Name = "lblEColonia";
            this.lblEColonia.Size = new System.Drawing.Size(54, 18);
            this.lblEColonia.TabIndex = 12;
            this.lblEColonia.Text = "Colonia";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEstado.Location = new System.Drawing.Point(542, 146);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(259, 29);
            this.txtEstado.TabIndex = 17;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEstado.Location = new System.Drawing.Point(539, 125);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(50, 18);
            this.lblEEstado.TabIndex = 16;
            this.lblEEstado.Text = "Estado";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCiudad.Location = new System.Drawing.Point(277, 146);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(259, 29);
            this.txtCiudad.TabIndex = 15;
            // 
            // lblECiudad
            // 
            this.lblECiudad.AutoSize = true;
            this.lblECiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECiudad.Location = new System.Drawing.Point(274, 125);
            this.lblECiudad.Name = "lblECiudad";
            this.lblECiudad.Size = new System.Drawing.Size(51, 18);
            this.lblECiudad.TabIndex = 14;
            this.lblECiudad.Text = "Ciudad";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCP.Location = new System.Drawing.Point(542, 88);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(259, 29);
            this.txtCP.TabIndex = 11;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // lblECP
            // 
            this.lblECP.AutoSize = true;
            this.lblECP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECP.Location = new System.Drawing.Point(539, 67);
            this.lblECP.Name = "lblECP";
            this.lblECP.Size = new System.Drawing.Size(92, 18);
            this.lblECP.TabIndex = 10;
            this.lblECP.Text = "Código postal";
            // 
            // txtNumInt
            // 
            this.txtNumInt.BackColor = System.Drawing.Color.White;
            this.txtNumInt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumInt.Location = new System.Drawing.Point(410, 88);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(126, 29);
            this.txtNumInt.TabIndex = 9;
            // 
            // lblENumInt
            // 
            this.lblENumInt.AutoSize = true;
            this.lblENumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumInt.Location = new System.Drawing.Point(405, 67);
            this.lblENumInt.Name = "lblENumInt";
            this.lblENumInt.Size = new System.Drawing.Size(105, 18);
            this.lblENumInt.TabIndex = 8;
            this.lblENumInt.Text = "Número interior";
            // 
            // txtNumExt
            // 
            this.txtNumExt.BackColor = System.Drawing.Color.White;
            this.txtNumExt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumExt.Location = new System.Drawing.Point(277, 88);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(127, 29);
            this.txtNumExt.TabIndex = 7;
            // 
            // lblENumExt
            // 
            this.lblENumExt.AutoSize = true;
            this.lblENumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumExt.Location = new System.Drawing.Point(274, 67);
            this.lblENumExt.Name = "lblENumExt";
            this.lblENumExt.Size = new System.Drawing.Size(108, 18);
            this.lblENumExt.TabIndex = 6;
            this.lblENumExt.Text = "Número exterior";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCalle.Location = new System.Drawing.Point(12, 88);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(259, 29);
            this.txtCalle.TabIndex = 5;
            // 
            // lblECalle
            // 
            this.lblECalle.AutoSize = true;
            this.lblECalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECalle.Location = new System.Drawing.Point(9, 67);
            this.lblECalle.Name = "lblECalle";
            this.lblECalle.Size = new System.Drawing.Size(37, 18);
            this.lblECalle.TabIndex = 4;
            this.lblECalle.Text = "Calle";
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.White;
            this.txtRFC.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRFC.Location = new System.Drawing.Point(542, 30);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(259, 29);
            this.txtRFC.TabIndex = 3;
            // 
            // lblERFC
            // 
            this.lblERFC.AutoSize = true;
            this.lblERFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERFC.Location = new System.Drawing.Point(539, 9);
            this.lblERFC.Name = "lblERFC";
            this.lblERFC.Size = new System.Drawing.Size(34, 18);
            this.lblERFC.TabIndex = 2;
            this.lblERFC.Text = "RFC";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(524, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(9, 9);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 0;
            this.lblENombre.Text = "Nombre";
            // 
            // frmEditarSucursal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 688);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblInfoImagen);
            this.Controls.Add(this.pcbLogotipo);
            this.Controls.Add(this.grbFiscal);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.lblEWeb);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblECorreo);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lblEFax);
            this.Controls.Add(this.lblETelefono02);
            this.Controls.Add(this.lblETelefono01);
            this.Controls.Add(this.txtTelefono02);
            this.Controls.Add(this.txtTelefono01);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.lblEColonia);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblECiudad);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblECP);
            this.Controls.Add(this.txtNumInt);
            this.Controls.Add(this.lblENumInt);
            this.Controls.Add(this.txtNumExt);
            this.Controls.Add(this.lblENumExt);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblECalle);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblERFC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblENombre);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditarSucursal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar sucursal";
            this.Load += new System.EventHandler(this.frmEditarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).EndInit();
            this.grbFiscal.ResumeLayout(false);
            this.grbFiscal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblInfoImagen;
        private System.Windows.Forms.PictureBox pcbLogotipo;
        private System.Windows.Forms.GroupBox grbFiscal;
        private System.Windows.Forms.Label lblFColonia;
        private System.Windows.Forms.Label lblFEstado;
        private System.Windows.Forms.Label lblFCiudad;
        private System.Windows.Forms.Label lblFCP;
        private System.Windows.Forms.Label lblFNumInt;
        private System.Windows.Forms.Label lblFNumExt;
        private System.Windows.Forms.Label lblFCalle;
        private System.Windows.Forms.Button btnAsignarDomicilio;
        private System.Windows.Forms.Label lblEFColonia;
        private System.Windows.Forms.Label lblEFEstado;
        private System.Windows.Forms.Label lblEFCiudad;
        private System.Windows.Forms.Label lblEFCP;
        private System.Windows.Forms.Label lblEFNumInt;
        private System.Windows.Forms.Label lblEFNumExt;
        private System.Windows.Forms.Label lblEFCalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblEWeb;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblECorreo;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblEFax;
        private System.Windows.Forms.Label lblETelefono02;
        private System.Windows.Forms.Label lblETelefono01;
        private System.Windows.Forms.TextBox txtTelefono02;
        private System.Windows.Forms.TextBox txtTelefono01;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblEColonia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblECiudad;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblECP;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label lblENumInt;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label lblENumExt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblECalle;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblERFC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;


    }
}