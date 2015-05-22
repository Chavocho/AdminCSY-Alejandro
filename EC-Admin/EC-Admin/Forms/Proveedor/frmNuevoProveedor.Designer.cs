namespace EC_Admin.Forms
{
    partial class frmNuevoProveedor
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
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblELimiteCredito = new System.Windows.Forms.Label();
            this.cboTipoCredito = new System.Windows.Forms.ComboBox();
            this.lblETipoCredito = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblECorreo = new System.Windows.Forms.Label();
            this.lblETelefono02 = new System.Windows.Forms.Label();
            this.lblELada02 = new System.Windows.Forms.Label();
            this.lblETelefono01 = new System.Windows.Forms.Label();
            this.txtLada02 = new System.Windows.Forms.TextBox();
            this.txtTelefono02 = new System.Windows.Forms.TextBox();
            this.txtLada01 = new System.Windows.Forms.TextBox();
            this.txtTelefono01 = new System.Windows.Forms.TextBox();
            this.lblELada01 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblECP = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEEstado = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblECiudad = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblEColonia = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.lblENumInt = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.lblENumExt = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblECalle = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblERFC = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblERazonSocial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblECBeneficiario = new System.Windows.Forms.Label();
            this.lblCSucursal = new System.Windows.Forms.Label();
            this.lblCBeneficiario = new System.Windows.Forms.Label();
            this.lblECSucursal = new System.Windows.Forms.Label();
            this.lblECNumCuenta = new System.Windows.Forms.Label();
            this.lblCBanco = new System.Windows.Forms.Label();
            this.lblCNumCuenta = new System.Windows.Forms.Label();
            this.lblECBanco = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.White;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLimiteCredito.Location = new System.Drawing.Point(542, 262);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(259, 29);
            this.txtLimiteCredito.TabIndex = 35;
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCredito_KeyPress);
            // 
            // lblELimiteCredito
            // 
            this.lblELimiteCredito.AutoSize = true;
            this.lblELimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELimiteCredito.Location = new System.Drawing.Point(539, 241);
            this.lblELimiteCredito.Name = "lblELimiteCredito";
            this.lblELimiteCredito.Size = new System.Drawing.Size(110, 18);
            this.lblELimiteCredito.TabIndex = 34;
            this.lblELimiteCredito.Text = "Límite de crédito";
            // 
            // cboTipoCredito
            // 
            this.cboTipoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoCredito.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoCredito.FormattingEnabled = true;
            this.cboTipoCredito.Items.AddRange(new object[] {
            "Sin Crédito",
            "Con Crédito"});
            this.cboTipoCredito.Location = new System.Drawing.Point(277, 262);
            this.cboTipoCredito.Name = "cboTipoCredito";
            this.cboTipoCredito.Size = new System.Drawing.Size(259, 29);
            this.cboTipoCredito.TabIndex = 33;
            this.cboTipoCredito.SelectedIndexChanged += new System.EventHandler(this.cboTipoCredito_SelectedIndexChanged);
            // 
            // lblETipoCredito
            // 
            this.lblETipoCredito.AutoSize = true;
            this.lblETipoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoCredito.Location = new System.Drawing.Point(274, 241);
            this.lblETipoCredito.Name = "lblETipoCredito";
            this.lblETipoCredito.Size = new System.Drawing.Size(99, 18);
            this.lblETipoCredito.TabIndex = 32;
            this.lblETipoCredito.Text = "Tipo de crédito";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(12, 262);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 31;
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(9, 241);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(121, 18);
            this.lblECorreo.TabIndex = 30;
            this.lblECorreo.Text = "Correo electrónico";
            // 
            // lblETelefono02
            // 
            this.lblETelefono02.AutoSize = true;
            this.lblETelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono02.Location = new System.Drawing.Point(600, 183);
            this.lblETelefono02.Name = "lblETelefono02";
            this.lblETelefono02.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono02.TabIndex = 28;
            this.lblETelefono02.Text = "Teléfono";
            // 
            // lblELada02
            // 
            this.lblELada02.AutoSize = true;
            this.lblELada02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada02.Location = new System.Drawing.Point(539, 183);
            this.lblELada02.Name = "lblELada02";
            this.lblELada02.Size = new System.Drawing.Size(38, 18);
            this.lblELada02.TabIndex = 26;
            this.lblELada02.Text = "Lada";
            // 
            // lblETelefono01
            // 
            this.lblETelefono01.AutoSize = true;
            this.lblETelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono01.Location = new System.Drawing.Point(335, 183);
            this.lblETelefono01.Name = "lblETelefono01";
            this.lblETelefono01.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono01.TabIndex = 24;
            this.lblETelefono01.Text = "Teléfono";
            // 
            // txtLada02
            // 
            this.txtLada02.BackColor = System.Drawing.Color.White;
            this.txtLada02.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLada02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLada02.Location = new System.Drawing.Point(542, 204);
            this.txtLada02.Name = "txtLada02";
            this.txtLada02.Size = new System.Drawing.Size(55, 29);
            this.txtLada02.TabIndex = 27;
            this.txtLada02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtTelefono02
            // 
            this.txtTelefono02.BackColor = System.Drawing.Color.White;
            this.txtTelefono02.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono02.Location = new System.Drawing.Point(603, 204);
            this.txtTelefono02.Name = "txtTelefono02";
            this.txtTelefono02.Size = new System.Drawing.Size(198, 29);
            this.txtTelefono02.TabIndex = 29;
            this.txtTelefono02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtLada01
            // 
            this.txtLada01.BackColor = System.Drawing.Color.White;
            this.txtLada01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLada01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLada01.Location = new System.Drawing.Point(277, 204);
            this.txtLada01.Name = "txtLada01";
            this.txtLada01.Size = new System.Drawing.Size(55, 29);
            this.txtLada01.TabIndex = 23;
            this.txtLada01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // txtTelefono01
            // 
            this.txtTelefono01.BackColor = System.Drawing.Color.White;
            this.txtTelefono01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono01.Location = new System.Drawing.Point(338, 204);
            this.txtTelefono01.Name = "txtTelefono01";
            this.txtTelefono01.Size = new System.Drawing.Size(198, 29);
            this.txtTelefono01.TabIndex = 25;
            this.txtTelefono01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // lblELada01
            // 
            this.lblELada01.AutoSize = true;
            this.lblELada01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada01.Location = new System.Drawing.Point(274, 183);
            this.lblELada01.Name = "lblELada01";
            this.lblELada01.Size = new System.Drawing.Size(38, 18);
            this.lblELada01.TabIndex = 22;
            this.lblELada01.Text = "Lada";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCP.Location = new System.Drawing.Point(12, 204);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(259, 29);
            this.txtCP.TabIndex = 21;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // lblECP
            // 
            this.lblECP.AutoSize = true;
            this.lblECP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECP.Location = new System.Drawing.Point(9, 183);
            this.lblECP.Name = "lblECP";
            this.lblECP.Size = new System.Drawing.Size(92, 18);
            this.lblECP.TabIndex = 20;
            this.lblECP.Text = "Código postal";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEstado.Location = new System.Drawing.Point(542, 146);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(259, 29);
            this.txtEstado.TabIndex = 19;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEstado.Location = new System.Drawing.Point(539, 125);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(50, 18);
            this.lblEEstado.TabIndex = 18;
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
            this.txtCiudad.TabIndex = 17;
            // 
            // lblECiudad
            // 
            this.lblECiudad.AutoSize = true;
            this.lblECiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECiudad.Location = new System.Drawing.Point(274, 125);
            this.lblECiudad.Name = "lblECiudad";
            this.lblECiudad.Size = new System.Drawing.Size(51, 18);
            this.lblECiudad.TabIndex = 16;
            this.lblECiudad.Text = "Ciudad";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtColonia.Location = new System.Drawing.Point(12, 146);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(259, 29);
            this.txtColonia.TabIndex = 15;
            // 
            // lblEColonia
            // 
            this.lblEColonia.AutoSize = true;
            this.lblEColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEColonia.Location = new System.Drawing.Point(9, 125);
            this.lblEColonia.Name = "lblEColonia";
            this.lblEColonia.Size = new System.Drawing.Size(54, 18);
            this.lblEColonia.TabIndex = 14;
            this.lblEColonia.Text = "Colonia";
            // 
            // txtNumInt
            // 
            this.txtNumInt.BackColor = System.Drawing.Color.White;
            this.txtNumInt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumInt.Location = new System.Drawing.Point(675, 88);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(126, 29);
            this.txtNumInt.TabIndex = 13;
            // 
            // lblENumInt
            // 
            this.lblENumInt.AutoSize = true;
            this.lblENumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumInt.Location = new System.Drawing.Point(670, 67);
            this.lblENumInt.Name = "lblENumInt";
            this.lblENumInt.Size = new System.Drawing.Size(105, 18);
            this.lblENumInt.TabIndex = 12;
            this.lblENumInt.Text = "Número interior";
            // 
            // txtNumExt
            // 
            this.txtNumExt.BackColor = System.Drawing.Color.White;
            this.txtNumExt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumExt.Location = new System.Drawing.Point(542, 88);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(127, 29);
            this.txtNumExt.TabIndex = 11;
            // 
            // lblENumExt
            // 
            this.lblENumExt.AutoSize = true;
            this.lblENumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumExt.Location = new System.Drawing.Point(539, 67);
            this.lblENumExt.Name = "lblENumExt";
            this.lblENumExt.Size = new System.Drawing.Size(108, 18);
            this.lblENumExt.TabIndex = 10;
            this.lblENumExt.Text = "Número exterior";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCalle.Location = new System.Drawing.Point(277, 88);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(259, 29);
            this.txtCalle.TabIndex = 9;
            // 
            // lblECalle
            // 
            this.lblECalle.AutoSize = true;
            this.lblECalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECalle.Location = new System.Drawing.Point(274, 67);
            this.lblECalle.Name = "lblECalle";
            this.lblECalle.Size = new System.Drawing.Size(37, 18);
            this.lblECalle.TabIndex = 8;
            this.lblECalle.Text = "Calle";
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.White;
            this.txtRFC.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRFC.Location = new System.Drawing.Point(12, 88);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(259, 29);
            this.txtRFC.TabIndex = 7;
            // 
            // lblERFC
            // 
            this.lblERFC.AutoSize = true;
            this.lblERFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERFC.Location = new System.Drawing.Point(9, 67);
            this.lblERFC.Name = "lblERFC";
            this.lblERFC.Size = new System.Drawing.Size(34, 18);
            this.lblERFC.TabIndex = 6;
            this.lblERFC.Text = "RFC";
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
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRazonSocial.Location = new System.Drawing.Point(542, 30);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(259, 29);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblERazonSocial
            // 
            this.lblERazonSocial.AutoSize = true;
            this.lblERazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERazonSocial.Location = new System.Drawing.Point(539, 9);
            this.lblERazonSocial.Name = "lblERazonSocial";
            this.lblERazonSocial.Size = new System.Drawing.Size(84, 18);
            this.lblERazonSocial.TabIndex = 4;
            this.lblERazonSocial.Text = "Razón social";
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
            this.btnAceptar.Location = new System.Drawing.Point(651, 375);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblECBeneficiario);
            this.groupBox1.Controls.Add(this.lblCSucursal);
            this.groupBox1.Controls.Add(this.lblCBeneficiario);
            this.groupBox1.Controls.Add(this.lblECSucursal);
            this.groupBox1.Controls.Add(this.lblECNumCuenta);
            this.groupBox1.Controls.Add(this.lblCBanco);
            this.groupBox1.Controls.Add(this.lblCNumCuenta);
            this.groupBox1.Controls.Add(this.lblECBanco);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 72);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cuenta";
            // 
            // lblECBeneficiario
            // 
            this.lblECBeneficiario.AutoSize = true;
            this.lblECBeneficiario.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECBeneficiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECBeneficiario.Location = new System.Drawing.Point(382, 18);
            this.lblECBeneficiario.Name = "lblECBeneficiario";
            this.lblECBeneficiario.Size = new System.Drawing.Size(84, 18);
            this.lblECBeneficiario.TabIndex = 42;
            this.lblECBeneficiario.Text = "Beneficiario:";
            // 
            // lblCSucursal
            // 
            this.lblCSucursal.AutoSize = true;
            this.lblCSucursal.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCSucursal.Location = new System.Drawing.Point(472, 41);
            this.lblCSucursal.Name = "lblCSucursal";
            this.lblCSucursal.Size = new System.Drawing.Size(23, 18);
            this.lblCSucursal.TabIndex = 45;
            this.lblCSucursal.Text = "---";
            // 
            // lblCBeneficiario
            // 
            this.lblCBeneficiario.AutoSize = true;
            this.lblCBeneficiario.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCBeneficiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCBeneficiario.Location = new System.Drawing.Point(472, 18);
            this.lblCBeneficiario.Name = "lblCBeneficiario";
            this.lblCBeneficiario.Size = new System.Drawing.Size(23, 18);
            this.lblCBeneficiario.TabIndex = 43;
            this.lblCBeneficiario.Text = "---";
            // 
            // lblECSucursal
            // 
            this.lblECSucursal.AutoSize = true;
            this.lblECSucursal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECSucursal.Location = new System.Drawing.Point(402, 41);
            this.lblECSucursal.Name = "lblECSucursal";
            this.lblECSucursal.Size = new System.Drawing.Size(64, 18);
            this.lblECSucursal.TabIndex = 44;
            this.lblECSucursal.Text = "Sucursal:";
            // 
            // lblECNumCuenta
            // 
            this.lblECNumCuenta.AutoSize = true;
            this.lblECNumCuenta.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECNumCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECNumCuenta.Location = new System.Drawing.Point(6, 18);
            this.lblECNumCuenta.Name = "lblECNumCuenta";
            this.lblECNumCuenta.Size = new System.Drawing.Size(109, 18);
            this.lblECNumCuenta.TabIndex = 38;
            this.lblECNumCuenta.Text = "Núm. de cuenta:";
            // 
            // lblCBanco
            // 
            this.lblCBanco.AutoSize = true;
            this.lblCBanco.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCBanco.Location = new System.Drawing.Point(121, 41);
            this.lblCBanco.Name = "lblCBanco";
            this.lblCBanco.Size = new System.Drawing.Size(23, 18);
            this.lblCBanco.TabIndex = 41;
            this.lblCBanco.Text = "---";
            // 
            // lblCNumCuenta
            // 
            this.lblCNumCuenta.AutoSize = true;
            this.lblCNumCuenta.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCNumCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCNumCuenta.Location = new System.Drawing.Point(121, 18);
            this.lblCNumCuenta.Name = "lblCNumCuenta";
            this.lblCNumCuenta.Size = new System.Drawing.Size(23, 18);
            this.lblCNumCuenta.TabIndex = 39;
            this.lblCNumCuenta.Text = "---";
            // 
            // lblECBanco
            // 
            this.lblECBanco.AutoSize = true;
            this.lblECBanco.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECBanco.Location = new System.Drawing.Point(64, 41);
            this.lblECBanco.Name = "lblECBanco";
            this.lblECBanco.Size = new System.Drawing.Size(51, 18);
            this.lblECBanco.TabIndex = 40;
            this.lblECBanco.Text = "Banco:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(193, 375);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(150, 46);
            this.btnQuitar.TabIndex = 57;
            this.btnQuitar.Text = "Quitar datos de cuenta";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Location = new System.Drawing.Point(12, 375);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(175, 46);
            this.btnCuenta.TabIndex = 56;
            this.btnCuenta.Text = "Asignar cuenta bancaria";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // frmNuevoProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 433);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.lblELimiteCredito);
            this.Controls.Add(this.cboTipoCredito);
            this.Controls.Add(this.lblETipoCredito);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblECorreo);
            this.Controls.Add(this.lblETelefono02);
            this.Controls.Add(this.lblELada02);
            this.Controls.Add(this.lblETelefono01);
            this.Controls.Add(this.txtLada02);
            this.Controls.Add(this.txtTelefono02);
            this.Controls.Add(this.txtLada01);
            this.Controls.Add(this.txtTelefono01);
            this.Controls.Add(this.lblELada01);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblECP);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEEstado);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblECiudad);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.lblEColonia);
            this.Controls.Add(this.txtNumInt);
            this.Controls.Add(this.lblENumInt);
            this.Controls.Add(this.txtNumExt);
            this.Controls.Add(this.lblENumExt);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblECalle);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.lblERFC);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblERazonSocial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblENombre);
            this.Controls.Add(this.lblESucursal);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevoProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar nuevo proveedor";
            this.Load += new System.EventHandler(this.frmNuevoProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label lblELimiteCredito;
        private System.Windows.Forms.ComboBox cboTipoCredito;
        private System.Windows.Forms.Label lblETipoCredito;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblECorreo;
        private System.Windows.Forms.Label lblETelefono02;
        private System.Windows.Forms.Label lblELada02;
        private System.Windows.Forms.Label lblETelefono01;
        private System.Windows.Forms.TextBox txtLada02;
        private System.Windows.Forms.TextBox txtTelefono02;
        private System.Windows.Forms.TextBox txtLada01;
        private System.Windows.Forms.TextBox txtTelefono01;
        private System.Windows.Forms.Label lblELada01;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblECP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblECiudad;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblEColonia;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label lblENumInt;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label lblENumExt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblECalle;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblERFC;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblERazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblECBeneficiario;
        private System.Windows.Forms.Label lblCSucursal;
        private System.Windows.Forms.Label lblCBeneficiario;
        private System.Windows.Forms.Label lblECSucursal;
        private System.Windows.Forms.Label lblECNumCuenta;
        private System.Windows.Forms.Label lblCBanco;
        private System.Windows.Forms.Label lblCNumCuenta;
        private System.Windows.Forms.Label lblECBanco;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCuenta;
    }
}