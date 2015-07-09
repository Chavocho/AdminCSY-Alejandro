namespace EC_Admin.Forms
{
    partial class frmEditarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpaPaquete = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlPaquete = new System.Windows.Forms.Panel();
            this.btnAceptarPaquete = new System.Windows.Forms.Button();
            this.txtCantPaquete = new System.Windows.Forms.TextBox();
            this.lblECantPaquete = new System.Windows.Forms.Label();
            this.txtPrecioPaquete = new System.Windows.Forms.TextBox();
            this.lblEPrecioPaquete = new System.Windows.Forms.Label();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEdito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpaProducto = new System.Windows.Forms.TabPage();
            this.lblInformacionCodigo = new System.Windows.Forms.Label();
            this.btnQuitar03 = new System.Windows.Forms.Button();
            this.lblInfoImagen03 = new System.Windows.Forms.Label();
            this.pcbImagen03 = new System.Windows.Forms.PictureBox();
            this.btnQuitar02 = new System.Windows.Forms.Button();
            this.lblInfoImagen02 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtPrecioMayoreo = new System.Windows.Forms.TextBox();
            this.txtPrecioMedioMayoreo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion01 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pcbImagen02 = new System.Windows.Forms.PictureBox();
            this.lblECant = new System.Windows.Forms.Label();
            this.lblEUnidad = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.lblEPrecioMayoreo = new System.Windows.Forms.Label();
            this.lblEPrecioMedioMayoreo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnQuitar01 = new System.Windows.Forms.Button();
            this.lblInfoImagen01 = new System.Windows.Forms.Label();
            this.pcbImagen01 = new System.Windows.Forms.PictureBox();
            this.lblEPrecio = new System.Windows.Forms.Label();
            this.lblECosto = new System.Windows.Forms.Label();
            this.lblEDescripcion01 = new System.Windows.Forms.Label();
            this.lblECategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblEProveedor = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblECodigo = new System.Windows.Forms.Label();
            this.lblEMarca = new System.Windows.Forms.Label();
            this.lblENombre = new System.Windows.Forms.Label();
            this.tcoPrincipal = new System.Windows.Forms.TabControl();
            this.tpaPaquete.SuspendLayout();
            this.pnlPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.tpaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen01)).BeginInit();
            this.tcoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpaPaquete
            // 
            this.tpaPaquete.Controls.Add(this.btnEliminar);
            this.tpaPaquete.Controls.Add(this.btnEditar);
            this.tpaPaquete.Controls.Add(this.btnNuevo);
            this.tpaPaquete.Controls.Add(this.pnlPaquete);
            this.tpaPaquete.Controls.Add(this.dgvPaquetes);
            this.tpaPaquete.Location = new System.Drawing.Point(4, 22);
            this.tpaPaquete.Name = "tpaPaquete";
            this.tpaPaquete.Padding = new System.Windows.Forms.Padding(3);
            this.tpaPaquete.Size = new System.Drawing.Size(805, 541);
            this.tpaPaquete.TabIndex = 1;
            this.tpaPaquete.Text = "Paquetes";
            this.tpaPaquete.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(262, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar paquete";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(443, 376);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 46);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Modificar paquete";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(624, 376);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo paquete";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlPaquete
            // 
            this.pnlPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaquete.Controls.Add(this.btnAceptarPaquete);
            this.pnlPaquete.Controls.Add(this.txtCantPaquete);
            this.pnlPaquete.Controls.Add(this.lblECantPaquete);
            this.pnlPaquete.Controls.Add(this.txtPrecioPaquete);
            this.pnlPaquete.Controls.Add(this.lblEPrecioPaquete);
            this.pnlPaquete.Location = new System.Drawing.Point(8, 437);
            this.pnlPaquete.Name = "pnlPaquete";
            this.pnlPaquete.Size = new System.Drawing.Size(789, 81);
            this.pnlPaquete.TabIndex = 14;
            this.pnlPaquete.Visible = false;
            // 
            // btnAceptarPaquete
            // 
            this.btnAceptarPaquete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarPaquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptarPaquete.FlatAppearance.BorderSize = 0;
            this.btnAceptarPaquete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptarPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPaquete.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAceptarPaquete.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarPaquete.Location = new System.Drawing.Point(636, 32);
            this.btnAceptarPaquete.Name = "btnAceptarPaquete";
            this.btnAceptarPaquete.Size = new System.Drawing.Size(150, 46);
            this.btnAceptarPaquete.TabIndex = 76;
            this.btnAceptarPaquete.Text = "Crear";
            this.btnAceptarPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarPaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptarPaquete.UseVisualStyleBackColor = false;
            this.btnAceptarPaquete.Click += new System.EventHandler(this.btnAceptarPaquete_Click);
            // 
            // txtCantPaquete
            // 
            this.txtCantPaquete.BackColor = System.Drawing.Color.White;
            this.txtCantPaquete.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCantPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCantPaquete.Location = new System.Drawing.Point(271, 23);
            this.txtCantPaquete.MaxLength = 13;
            this.txtCantPaquete.Name = "txtCantPaquete";
            this.txtCantPaquete.Size = new System.Drawing.Size(259, 29);
            this.txtCantPaquete.TabIndex = 7;
            this.txtCantPaquete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosEnteros_KeyPress);
            // 
            // lblECantPaquete
            // 
            this.lblECantPaquete.AutoSize = true;
            this.lblECantPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECantPaquete.Location = new System.Drawing.Point(268, 2);
            this.lblECantPaquete.Name = "lblECantPaquete";
            this.lblECantPaquete.Size = new System.Drawing.Size(63, 18);
            this.lblECantPaquete.TabIndex = 6;
            this.lblECantPaquete.Text = "Cantidad";
            // 
            // txtPrecioPaquete
            // 
            this.txtPrecioPaquete.BackColor = System.Drawing.Color.White;
            this.txtPrecioPaquete.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPrecioPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPrecioPaquete.Location = new System.Drawing.Point(6, 23);
            this.txtPrecioPaquete.MaxLength = 13;
            this.txtPrecioPaquete.Name = "txtPrecioPaquete";
            this.txtPrecioPaquete.Size = new System.Drawing.Size(259, 29);
            this.txtPrecioPaquete.TabIndex = 5;
            this.txtPrecioPaquete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblEPrecioPaquete
            // 
            this.lblEPrecioPaquete.AutoSize = true;
            this.lblEPrecioPaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecioPaquete.Location = new System.Drawing.Point(3, 2);
            this.lblEPrecioPaquete.Name = "lblEPrecioPaquete";
            this.lblEPrecioPaquete.Size = new System.Drawing.Size(47, 18);
            this.lblEPrecioPaquete.TabIndex = 4;
            this.lblEPrecioPaquete.Text = "Precio";
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AllowUserToAddRows = false;
            this.dgvPaquetes.AllowUserToDeleteRows = false;
            this.dgvPaquetes.AllowUserToResizeColumns = false;
            this.dgvPaquetes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvPaquetes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaquetes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaquetes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaquetes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CPrecio,
            this.CCantidad,
            this.CBase,
            this.CEdito});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaquetes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaquetes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPaquetes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvPaquetes.Location = new System.Drawing.Point(8, 6);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPaquetes.RowHeadersVisible = false;
            this.dgvPaquetes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(791, 349);
            this.dgvPaquetes.TabIndex = 13;
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            this.CPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            // 
            // CBase
            // 
            this.CBase.HeaderText = "Esta en base de datos";
            this.CBase.Name = "CBase";
            this.CBase.Visible = false;
            // 
            // CEdito
            // 
            this.CEdito.HeaderText = "Se edito";
            this.CEdito.Name = "CEdito";
            this.CEdito.Visible = false;
            // 
            // tpaProducto
            // 
            this.tpaProducto.Controls.Add(this.lblInformacionCodigo);
            this.tpaProducto.Controls.Add(this.btnQuitar03);
            this.tpaProducto.Controls.Add(this.lblInfoImagen03);
            this.tpaProducto.Controls.Add(this.pcbImagen03);
            this.tpaProducto.Controls.Add(this.btnQuitar02);
            this.tpaProducto.Controls.Add(this.lblInfoImagen02);
            this.tpaProducto.Controls.Add(this.txtCant);
            this.tpaProducto.Controls.Add(this.txtPrecioMayoreo);
            this.tpaProducto.Controls.Add(this.txtPrecioMedioMayoreo);
            this.tpaProducto.Controls.Add(this.txtPrecio);
            this.tpaProducto.Controls.Add(this.txtCosto);
            this.tpaProducto.Controls.Add(this.txtDescripcion01);
            this.tpaProducto.Controls.Add(this.txtCodigo);
            this.tpaProducto.Controls.Add(this.txtMarca);
            this.tpaProducto.Controls.Add(this.txtNombre);
            this.tpaProducto.Controls.Add(this.pcbImagen02);
            this.tpaProducto.Controls.Add(this.lblECant);
            this.tpaProducto.Controls.Add(this.lblEUnidad);
            this.tpaProducto.Controls.Add(this.cboUnidad);
            this.tpaProducto.Controls.Add(this.lblEPrecioMayoreo);
            this.tpaProducto.Controls.Add(this.lblEPrecioMedioMayoreo);
            this.tpaProducto.Controls.Add(this.btnAceptar);
            this.tpaProducto.Controls.Add(this.btnQuitar01);
            this.tpaProducto.Controls.Add(this.lblInfoImagen01);
            this.tpaProducto.Controls.Add(this.pcbImagen01);
            this.tpaProducto.Controls.Add(this.lblEPrecio);
            this.tpaProducto.Controls.Add(this.lblECosto);
            this.tpaProducto.Controls.Add(this.lblEDescripcion01);
            this.tpaProducto.Controls.Add(this.lblECategoria);
            this.tpaProducto.Controls.Add(this.cboCategoria);
            this.tpaProducto.Controls.Add(this.lblEProveedor);
            this.tpaProducto.Controls.Add(this.cboProveedor);
            this.tpaProducto.Controls.Add(this.lblECodigo);
            this.tpaProducto.Controls.Add(this.lblEMarca);
            this.tpaProducto.Controls.Add(this.lblENombre);
            this.tpaProducto.Location = new System.Drawing.Point(4, 27);
            this.tpaProducto.Name = "tpaProducto";
            this.tpaProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpaProducto.Size = new System.Drawing.Size(805, 536);
            this.tpaProducto.TabIndex = 0;
            this.tpaProducto.Text = "Datos de producto";
            this.tpaProducto.UseVisualStyleBackColor = true;
            // 
            // lblInformacionCodigo
            // 
            this.lblInformacionCodigo.AutoSize = true;
            this.lblInformacionCodigo.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInformacionCodigo.Location = new System.Drawing.Point(6, 238);
            this.lblInformacionCodigo.Name = "lblInformacionCodigo";
            this.lblInformacionCodigo.Size = new System.Drawing.Size(319, 14);
            this.lblInformacionCodigo.TabIndex = 154;
            this.lblInformacionCodigo.Text = "El código de producto ingresado ya existe. Favor de ingresar otro.";
            this.lblInformacionCodigo.Visible = false;
            // 
            // btnQuitar03
            // 
            this.btnQuitar03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar03.FlatAppearance.BorderSize = 0;
            this.btnQuitar03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar03.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar03.ForeColor = System.Drawing.Color.White;
            this.btnQuitar03.Location = new System.Drawing.Point(342, 494);
            this.btnQuitar03.Name = "btnQuitar03";
            this.btnQuitar03.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar03.TabIndex = 25;
            this.btnQuitar03.Text = "Quitar imagen";
            this.btnQuitar03.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar03.UseVisualStyleBackColor = false;
            this.btnQuitar03.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInfoImagen03
            // 
            this.lblInfoImagen03.AutoSize = true;
            this.lblInfoImagen03.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfoImagen03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfoImagen03.Location = new System.Drawing.Point(339, 477);
            this.lblInfoImagen03.Name = "lblInfoImagen03";
            this.lblInfoImagen03.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen03.TabIndex = 24;
            this.lblInfoImagen03.Text = "Clic para cambiar la imagen";
            // 
            // pcbImagen03
            // 
            this.pcbImagen03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen03.Location = new System.Drawing.Point(342, 318);
            this.pcbImagen03.Name = "pcbImagen03";
            this.pcbImagen03.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen03.TabIndex = 153;
            this.pcbImagen03.TabStop = false;
            this.pcbImagen03.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // btnQuitar02
            // 
            this.btnQuitar02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar02.FlatAppearance.BorderSize = 0;
            this.btnQuitar02.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar02.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar02.ForeColor = System.Drawing.Color.White;
            this.btnQuitar02.Location = new System.Drawing.Point(175, 494);
            this.btnQuitar02.Name = "btnQuitar02";
            this.btnQuitar02.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar02.TabIndex = 23;
            this.btnQuitar02.Text = "Quitar imagen";
            this.btnQuitar02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar02.UseVisualStyleBackColor = false;
            this.btnQuitar02.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInfoImagen02
            // 
            this.lblInfoImagen02.AutoSize = true;
            this.lblInfoImagen02.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfoImagen02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfoImagen02.Location = new System.Drawing.Point(172, 477);
            this.lblInfoImagen02.Name = "lblInfoImagen02";
            this.lblInfoImagen02.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen02.TabIndex = 22;
            this.lblInfoImagen02.Text = "Clic para cambiar la imagen";
            // 
            // txtCant
            // 
            this.txtCant.BackColor = System.Drawing.Color.White;
            this.txtCant.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCant.Location = new System.Drawing.Point(274, 140);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(259, 29);
            this.txtCant.TabIndex = 113;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosEnteros_KeyPress);
            // 
            // txtPrecioMayoreo
            // 
            this.txtPrecioMayoreo.BackColor = System.Drawing.Color.White;
            this.txtPrecioMayoreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPrecioMayoreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPrecioMayoreo.Location = new System.Drawing.Point(539, 198);
            this.txtPrecioMayoreo.Name = "txtPrecioMayoreo";
            this.txtPrecioMayoreo.Size = new System.Drawing.Size(259, 29);
            this.txtPrecioMayoreo.TabIndex = 17;
            this.txtPrecioMayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtPrecioMedioMayoreo
            // 
            this.txtPrecioMedioMayoreo.BackColor = System.Drawing.Color.White;
            this.txtPrecioMedioMayoreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPrecioMedioMayoreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPrecioMedioMayoreo.Location = new System.Drawing.Point(274, 198);
            this.txtPrecioMedioMayoreo.Name = "txtPrecioMedioMayoreo";
            this.txtPrecioMedioMayoreo.Size = new System.Drawing.Size(259, 29);
            this.txtPrecioMedioMayoreo.TabIndex = 15;
            this.txtPrecioMedioMayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPrecio.Location = new System.Drawing.Point(9, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(259, 29);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCosto.Location = new System.Drawing.Point(9, 140);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(259, 29);
            this.txtCosto.TabIndex = 105;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtDescripcion01
            // 
            this.txtDescripcion01.BackColor = System.Drawing.Color.White;
            this.txtDescripcion01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDescripcion01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDescripcion01.Location = new System.Drawing.Point(539, 82);
            this.txtDescripcion01.Multiline = true;
            this.txtDescripcion01.Name = "txtDescripcion01";
            this.txtDescripcion01.Size = new System.Drawing.Size(259, 87);
            this.txtDescripcion01.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCodigo.Location = new System.Drawing.Point(274, 82);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(259, 29);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMarca.Location = new System.Drawing.Point(9, 82);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(259, 29);
            this.txtMarca.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(539, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // pcbImagen02
            // 
            this.pcbImagen02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen02.Location = new System.Drawing.Point(175, 318);
            this.pcbImagen02.Name = "pcbImagen02";
            this.pcbImagen02.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen02.TabIndex = 148;
            this.pcbImagen02.TabStop = false;
            this.pcbImagen02.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // lblECant
            // 
            this.lblECant.AutoSize = true;
            this.lblECant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECant.Location = new System.Drawing.Point(271, 119);
            this.lblECant.Name = "lblECant";
            this.lblECant.Size = new System.Drawing.Size(63, 18);
            this.lblECant.TabIndex = 111;
            this.lblECant.Text = "Cantidad";
            // 
            // lblEUnidad
            // 
            this.lblEUnidad.AutoSize = true;
            this.lblEUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEUnidad.Location = new System.Drawing.Point(6, 235);
            this.lblEUnidad.Name = "lblEUnidad";
            this.lblEUnidad.Size = new System.Drawing.Size(52, 18);
            this.lblEUnidad.TabIndex = 18;
            this.lblEUnidad.Text = "Unidad";
            this.lblEUnidad.Visible = false;
            // 
            // cboUnidad
            // 
            this.cboUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidad.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Items.AddRange(new object[] {
            "Pieza"});
            this.cboUnidad.Location = new System.Drawing.Point(9, 256);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(259, 29);
            this.cboUnidad.TabIndex = 19;
            this.cboUnidad.Visible = false;
            this.cboUnidad.SelectedIndexChanged += new System.EventHandler(this.cboUnidad_SelectedIndexChanged);
            // 
            // lblEPrecioMayoreo
            // 
            this.lblEPrecioMayoreo.AutoSize = true;
            this.lblEPrecioMayoreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecioMayoreo.Location = new System.Drawing.Point(536, 177);
            this.lblEPrecioMayoreo.Name = "lblEPrecioMayoreo";
            this.lblEPrecioMayoreo.Size = new System.Drawing.Size(104, 18);
            this.lblEPrecioMayoreo.TabIndex = 16;
            this.lblEPrecioMayoreo.Text = "Precio mayoreo";
            // 
            // lblEPrecioMedioMayoreo
            // 
            this.lblEPrecioMedioMayoreo.AutoSize = true;
            this.lblEPrecioMedioMayoreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecioMedioMayoreo.Location = new System.Drawing.Point(271, 177);
            this.lblEPrecioMedioMayoreo.Name = "lblEPrecioMedioMayoreo";
            this.lblEPrecioMedioMayoreo.Size = new System.Drawing.Size(145, 18);
            this.lblEPrecioMedioMayoreo.TabIndex = 14;
            this.lblEPrecioMedioMayoreo.Text = "Precio medio mayoreo";
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
            this.btnAceptar.Location = new System.Drawing.Point(649, 477);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnQuitar01
            // 
            this.btnQuitar01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar01.FlatAppearance.BorderSize = 0;
            this.btnQuitar01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar01.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar01.ForeColor = System.Drawing.Color.White;
            this.btnQuitar01.Location = new System.Drawing.Point(8, 494);
            this.btnQuitar01.Name = "btnQuitar01";
            this.btnQuitar01.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar01.TabIndex = 21;
            this.btnQuitar01.Text = "Quitar imagen";
            this.btnQuitar01.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar01.UseVisualStyleBackColor = false;
            this.btnQuitar01.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lblInfoImagen01
            // 
            this.lblInfoImagen01.AutoSize = true;
            this.lblInfoImagen01.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfoImagen01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfoImagen01.Location = new System.Drawing.Point(5, 477);
            this.lblInfoImagen01.Name = "lblInfoImagen01";
            this.lblInfoImagen01.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen01.TabIndex = 20;
            this.lblInfoImagen01.Text = "Clic para cambiar la imagen";
            // 
            // pcbImagen01
            // 
            this.pcbImagen01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen01.Location = new System.Drawing.Point(8, 318);
            this.pcbImagen01.Name = "pcbImagen01";
            this.pcbImagen01.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen01.TabIndex = 142;
            this.pcbImagen01.TabStop = false;
            this.pcbImagen01.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // lblEPrecio
            // 
            this.lblEPrecio.AutoSize = true;
            this.lblEPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecio.Location = new System.Drawing.Point(6, 177);
            this.lblEPrecio.Name = "lblEPrecio";
            this.lblEPrecio.Size = new System.Drawing.Size(47, 18);
            this.lblEPrecio.TabIndex = 12;
            this.lblEPrecio.Text = "Precio";
            // 
            // lblECosto
            // 
            this.lblECosto.AutoSize = true;
            this.lblECosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECosto.Location = new System.Drawing.Point(6, 119);
            this.lblECosto.Name = "lblECosto";
            this.lblECosto.Size = new System.Drawing.Size(44, 18);
            this.lblECosto.TabIndex = 104;
            this.lblECosto.Text = "Costo";
            // 
            // lblEDescripcion01
            // 
            this.lblEDescripcion01.AutoSize = true;
            this.lblEDescripcion01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDescripcion01.Location = new System.Drawing.Point(536, 61);
            this.lblEDescripcion01.Name = "lblEDescripcion01";
            this.lblEDescripcion01.Size = new System.Drawing.Size(80, 18);
            this.lblEDescripcion01.TabIndex = 10;
            this.lblEDescripcion01.Text = "Descripción";
            // 
            // lblECategoria
            // 
            this.lblECategoria.AutoSize = true;
            this.lblECategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECategoria.Location = new System.Drawing.Point(271, 3);
            this.lblECategoria.Name = "lblECategoria";
            this.lblECategoria.Size = new System.Drawing.Size(67, 18);
            this.lblECategoria.TabIndex = 2;
            this.lblECategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(274, 24);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(259, 29);
            this.cboCategoria.TabIndex = 3;
            // 
            // lblEProveedor
            // 
            this.lblEProveedor.AutoSize = true;
            this.lblEProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEProveedor.Location = new System.Drawing.Point(6, 3);
            this.lblEProveedor.Name = "lblEProveedor";
            this.lblEProveedor.Size = new System.Drawing.Size(72, 18);
            this.lblEProveedor.TabIndex = 0;
            this.lblEProveedor.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            this.cboProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProveedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(9, 24);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(259, 29);
            this.cboProveedor.TabIndex = 1;
            // 
            // lblECodigo
            // 
            this.lblECodigo.AutoSize = true;
            this.lblECodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECodigo.Location = new System.Drawing.Point(271, 61);
            this.lblECodigo.Name = "lblECodigo";
            this.lblECodigo.Size = new System.Drawing.Size(52, 18);
            this.lblECodigo.TabIndex = 8;
            this.lblECodigo.Text = "Código";
            // 
            // lblEMarca
            // 
            this.lblEMarca.AutoSize = true;
            this.lblEMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEMarca.Location = new System.Drawing.Point(6, 61);
            this.lblEMarca.Name = "lblEMarca";
            this.lblEMarca.Size = new System.Drawing.Size(46, 18);
            this.lblEMarca.TabIndex = 6;
            this.lblEMarca.Text = "Marca";
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(536, 3);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 4;
            this.lblENombre.Text = "Nombre";
            // 
            // tcoPrincipal
            // 
            this.tcoPrincipal.Controls.Add(this.tpaProducto);
            this.tcoPrincipal.Controls.Add(this.tpaPaquete);
            this.tcoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcoPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcoPrincipal.Name = "tcoPrincipal";
            this.tcoPrincipal.SelectedIndex = 0;
            this.tcoPrincipal.Size = new System.Drawing.Size(813, 567);
            this.tcoPrincipal.TabIndex = 0;
            // 
            // frmEditarProducto
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 567);
            this.Controls.Add(this.tcoPrincipal);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar datos de producto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.tpaPaquete.ResumeLayout(false);
            this.pnlPaquete.ResumeLayout(false);
            this.pnlPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.tpaProducto.ResumeLayout(false);
            this.tpaProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen01)).EndInit();
            this.tcoPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpaPaquete;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlPaquete;
        private System.Windows.Forms.Button btnAceptarPaquete;
        private System.Windows.Forms.TextBox txtCantPaquete;
        private System.Windows.Forms.Label lblECantPaquete;
        private System.Windows.Forms.TextBox txtPrecioPaquete;
        private System.Windows.Forms.Label lblEPrecioPaquete;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.TabPage tpaProducto;
        private System.Windows.Forms.Button btnQuitar03;
        private System.Windows.Forms.Label lblInfoImagen03;
        private System.Windows.Forms.PictureBox pcbImagen03;
        private System.Windows.Forms.Button btnQuitar02;
        private System.Windows.Forms.Label lblInfoImagen02;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtPrecioMayoreo;
        private System.Windows.Forms.TextBox txtPrecioMedioMayoreo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDescripcion01;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pcbImagen02;
        private System.Windows.Forms.Label lblECant;
        private System.Windows.Forms.Label lblEUnidad;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.Label lblEPrecioMayoreo;
        private System.Windows.Forms.Label lblEPrecioMedioMayoreo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnQuitar01;
        private System.Windows.Forms.Label lblInfoImagen01;
        private System.Windows.Forms.PictureBox pcbImagen01;
        private System.Windows.Forms.Label lblEPrecio;
        private System.Windows.Forms.Label lblECosto;
        private System.Windows.Forms.Label lblEDescripcion01;
        private System.Windows.Forms.Label lblECategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblEProveedor;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lblECodigo;
        private System.Windows.Forms.Label lblEMarca;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.TabControl tcoPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEdito;
        private System.Windows.Forms.Label lblInformacionCodigo;


    }
}