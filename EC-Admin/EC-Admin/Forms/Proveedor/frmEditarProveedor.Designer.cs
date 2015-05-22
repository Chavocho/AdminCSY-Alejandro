namespace EC_Admin.Forms
{
    partial class frmEditarProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEContactos = new System.Windows.Forms.Label();
            this.lblEDatosCliente = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblECBeneficiario = new System.Windows.Forms.Label();
            this.lblCSucursal = new System.Windows.Forms.Label();
            this.lblCBeneficiario = new System.Windows.Forms.Label();
            this.lblECSucursal = new System.Windows.Forms.Label();
            this.lblECNumCuenta = new System.Windows.Forms.Label();
            this.lblCBanco = new System.Windows.Forms.Label();
            this.lblCNumCuenta = new System.Windows.Forms.Label();
            this.lblECBanco = new System.Windows.Forms.Label();
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
            this.pnlContactos = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEContactos
            // 
            this.lblEContactos.AutoSize = true;
            this.lblEContactos.BackColor = System.Drawing.Color.White;
            this.lblEContactos.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEContactos.Location = new System.Drawing.Point(112, 0);
            this.lblEContactos.Name = "lblEContactos";
            this.lblEContactos.Size = new System.Drawing.Size(90, 22);
            this.lblEContactos.TabIndex = 1;
            this.lblEContactos.Text = "Contactos";
            this.lblEContactos.Click += new System.EventHandler(this.lblEContactos_Click);
            // 
            // lblEDatosCliente
            // 
            this.lblEDatosCliente.AutoSize = true;
            this.lblEDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDatosCliente.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEDatosCliente.ForeColor = System.Drawing.Color.White;
            this.lblEDatosCliente.Location = new System.Drawing.Point(0, 0);
            this.lblEDatosCliente.Name = "lblEDatosCliente";
            this.lblEDatosCliente.Size = new System.Drawing.Size(112, 22);
            this.lblEDatosCliente.TabIndex = 0;
            this.lblEDatosCliente.Text = "Datos cliente";
            this.lblEDatosCliente.Click += new System.EventHandler(this.lblEDatosCliente_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(651, 401);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.groupBox1);
            this.pnlDatos.Controls.Add(this.txtLimiteCredito);
            this.pnlDatos.Controls.Add(this.lblELimiteCredito);
            this.pnlDatos.Controls.Add(this.cboTipoCredito);
            this.pnlDatos.Controls.Add(this.lblETipoCredito);
            this.pnlDatos.Controls.Add(this.txtCorreo);
            this.pnlDatos.Controls.Add(this.lblECorreo);
            this.pnlDatos.Controls.Add(this.lblETelefono02);
            this.pnlDatos.Controls.Add(this.lblELada02);
            this.pnlDatos.Controls.Add(this.lblETelefono01);
            this.pnlDatos.Controls.Add(this.txtLada02);
            this.pnlDatos.Controls.Add(this.txtTelefono02);
            this.pnlDatos.Controls.Add(this.txtLada01);
            this.pnlDatos.Controls.Add(this.txtTelefono01);
            this.pnlDatos.Controls.Add(this.lblELada01);
            this.pnlDatos.Controls.Add(this.txtCP);
            this.pnlDatos.Controls.Add(this.lblECP);
            this.pnlDatos.Controls.Add(this.txtEstado);
            this.pnlDatos.Controls.Add(this.lblEEstado);
            this.pnlDatos.Controls.Add(this.txtCiudad);
            this.pnlDatos.Controls.Add(this.lblECiudad);
            this.pnlDatos.Controls.Add(this.txtColonia);
            this.pnlDatos.Controls.Add(this.lblEColonia);
            this.pnlDatos.Controls.Add(this.txtNumInt);
            this.pnlDatos.Controls.Add(this.lblENumInt);
            this.pnlDatos.Controls.Add(this.txtNumExt);
            this.pnlDatos.Controls.Add(this.lblENumExt);
            this.pnlDatos.Controls.Add(this.txtCalle);
            this.pnlDatos.Controls.Add(this.lblECalle);
            this.pnlDatos.Controls.Add(this.txtRFC);
            this.pnlDatos.Controls.Add(this.lblERFC);
            this.pnlDatos.Controls.Add(this.cboSucursal);
            this.pnlDatos.Controls.Add(this.txtRazonSocial);
            this.pnlDatos.Controls.Add(this.lblERazonSocial);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblENombre);
            this.pnlDatos.Controls.Add(this.lblESucursal);
            this.pnlDatos.Location = new System.Drawing.Point(0, 25);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(813, 370);
            this.pnlDatos.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 72);
            this.groupBox1.TabIndex = 44;
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
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.White;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLimiteCredito.Location = new System.Drawing.Point(542, 255);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(259, 29);
            this.txtLimiteCredito.TabIndex = 35;
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCredito_KeyPress);
            // 
            // lblELimiteCredito
            // 
            this.lblELimiteCredito.AutoSize = true;
            this.lblELimiteCredito.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblELimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELimiteCredito.Location = new System.Drawing.Point(539, 234);
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
            this.cboTipoCredito.Location = new System.Drawing.Point(277, 255);
            this.cboTipoCredito.Name = "cboTipoCredito";
            this.cboTipoCredito.Size = new System.Drawing.Size(259, 29);
            this.cboTipoCredito.TabIndex = 33;
            this.cboTipoCredito.SelectedIndexChanged += new System.EventHandler(this.cboTipoCredito_SelectedIndexChanged);
            // 
            // lblETipoCredito
            // 
            this.lblETipoCredito.AutoSize = true;
            this.lblETipoCredito.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETipoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoCredito.Location = new System.Drawing.Point(274, 234);
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
            this.txtCorreo.Location = new System.Drawing.Point(12, 255);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 31;
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(9, 234);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(121, 18);
            this.lblECorreo.TabIndex = 30;
            this.lblECorreo.Text = "Correo electrónico";
            // 
            // lblETelefono02
            // 
            this.lblETelefono02.AutoSize = true;
            this.lblETelefono02.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono02.Location = new System.Drawing.Point(600, 176);
            this.lblETelefono02.Name = "lblETelefono02";
            this.lblETelefono02.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono02.TabIndex = 28;
            this.lblETelefono02.Text = "Teléfono";
            // 
            // lblELada02
            // 
            this.lblELada02.AutoSize = true;
            this.lblELada02.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblELada02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada02.Location = new System.Drawing.Point(539, 176);
            this.lblELada02.Name = "lblELada02";
            this.lblELada02.Size = new System.Drawing.Size(38, 18);
            this.lblELada02.TabIndex = 26;
            this.lblELada02.Text = "Lada";
            // 
            // lblETelefono01
            // 
            this.lblETelefono01.AutoSize = true;
            this.lblETelefono01.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono01.Location = new System.Drawing.Point(335, 176);
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
            this.txtLada02.Location = new System.Drawing.Point(542, 197);
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
            this.txtTelefono02.Location = new System.Drawing.Point(603, 197);
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
            this.txtLada01.Location = new System.Drawing.Point(277, 197);
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
            this.txtTelefono01.Location = new System.Drawing.Point(338, 197);
            this.txtTelefono01.Name = "txtTelefono01";
            this.txtTelefono01.Size = new System.Drawing.Size(198, 29);
            this.txtTelefono01.TabIndex = 25;
            this.txtTelefono01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonos_KeyPress);
            // 
            // lblELada01
            // 
            this.lblELada01.AutoSize = true;
            this.lblELada01.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblELada01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada01.Location = new System.Drawing.Point(274, 176);
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
            this.txtCP.Location = new System.Drawing.Point(12, 197);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(259, 29);
            this.txtCP.TabIndex = 21;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // lblECP
            // 
            this.lblECP.AutoSize = true;
            this.lblECP.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECP.Location = new System.Drawing.Point(9, 176);
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
            this.txtEstado.Location = new System.Drawing.Point(542, 139);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(259, 29);
            this.txtEstado.TabIndex = 19;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEstado.Location = new System.Drawing.Point(539, 118);
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
            this.txtCiudad.Location = new System.Drawing.Point(277, 139);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(259, 29);
            this.txtCiudad.TabIndex = 17;
            // 
            // lblECiudad
            // 
            this.lblECiudad.AutoSize = true;
            this.lblECiudad.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECiudad.Location = new System.Drawing.Point(274, 118);
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
            this.txtColonia.Location = new System.Drawing.Point(12, 139);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(259, 29);
            this.txtColonia.TabIndex = 15;
            // 
            // lblEColonia
            // 
            this.lblEColonia.AutoSize = true;
            this.lblEColonia.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEColonia.Location = new System.Drawing.Point(9, 118);
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
            this.txtNumInt.Location = new System.Drawing.Point(675, 81);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(126, 29);
            this.txtNumInt.TabIndex = 13;
            // 
            // lblENumInt
            // 
            this.lblENumInt.AutoSize = true;
            this.lblENumInt.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblENumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumInt.Location = new System.Drawing.Point(670, 60);
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
            this.txtNumExt.Location = new System.Drawing.Point(542, 81);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(127, 29);
            this.txtNumExt.TabIndex = 11;
            // 
            // lblENumExt
            // 
            this.lblENumExt.AutoSize = true;
            this.lblENumExt.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblENumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumExt.Location = new System.Drawing.Point(539, 60);
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
            this.txtCalle.Location = new System.Drawing.Point(277, 81);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(259, 29);
            this.txtCalle.TabIndex = 9;
            // 
            // lblECalle
            // 
            this.lblECalle.AutoSize = true;
            this.lblECalle.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECalle.Location = new System.Drawing.Point(274, 60);
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
            this.txtRFC.Location = new System.Drawing.Point(12, 81);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(259, 29);
            this.txtRFC.TabIndex = 7;
            // 
            // lblERFC
            // 
            this.lblERFC.AutoSize = true;
            this.lblERFC.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblERFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERFC.Location = new System.Drawing.Point(9, 60);
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
            this.cboSucursal.Location = new System.Drawing.Point(12, 23);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(259, 29);
            this.cboSucursal.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRazonSocial.Location = new System.Drawing.Point(542, 23);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(259, 29);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblERazonSocial
            // 
            this.lblERazonSocial.AutoSize = true;
            this.lblERazonSocial.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblERazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERazonSocial.Location = new System.Drawing.Point(539, 2);
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
            this.txtNombre.Location = new System.Drawing.Point(277, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(274, 2);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 2;
            this.lblENombre.Text = "Nombre";
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblESucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESucursal.Location = new System.Drawing.Point(9, 2);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 0;
            this.lblESucursal.Text = "Sucursal";
            // 
            // pnlContactos
            // 
            this.pnlContactos.Controls.Add(this.btnEliminar);
            this.pnlContactos.Controls.Add(this.btnEditar);
            this.pnlContactos.Controls.Add(this.btnNuevo);
            this.pnlContactos.Controls.Add(this.dgvContactos);
            this.pnlContactos.Font = new System.Drawing.Font("Corbel", 11F);
            this.pnlContactos.Location = new System.Drawing.Point(0, 25);
            this.pnlContactos.Name = "pnlContactos";
            this.pnlContactos.Size = new System.Drawing.Size(813, 370);
            this.pnlContactos.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(264, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar contacto";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(445, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 46);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Modificar contacto";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(626, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo contacto";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AllowUserToResizeColumns = false;
            this.dgvContactos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNombre,
            this.CRFC,
            this.CTelefonos,
            this.CCorreo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvContactos.Location = new System.Drawing.Point(0, 0);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(813, 315);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_RowEnter);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CRFC
            // 
            this.CRFC.HeaderText = "RFC";
            this.CRFC.Name = "CRFC";
            this.CRFC.Width = 130;
            // 
            // CTelefonos
            // 
            this.CTelefonos.HeaderText = "Teléfonos";
            this.CTelefonos.Name = "CTelefonos";
            this.CTelefonos.Width = 200;
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            this.CCorreo.Width = 200;
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
            this.btnQuitar.Location = new System.Drawing.Point(193, 401);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(150, 46);
            this.btnQuitar.TabIndex = 56;
            this.btnQuitar.Text = "Quitar datos de cuenta";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Location = new System.Drawing.Point(12, 401);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(175, 46);
            this.btnCuenta.TabIndex = 55;
            this.btnCuenta.Text = "Asignar cuenta bancaria";
            this.btnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // frmEditarProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 459);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblEContactos);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.lblEDatosCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlContactos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarProveedor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar proveedor";
            this.Load += new System.EventHandler(this.frmEditarProveedor_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEContactos;
        private System.Windows.Forms.Label lblEDatosCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlDatos;
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
        private System.Windows.Forms.Panel pnlContactos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
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