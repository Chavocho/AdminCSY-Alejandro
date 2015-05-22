namespace EC_Admin.Forms
{
    partial class frmCotizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblEVendedor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pcbProducto = new System.Windows.Forms.PictureBox();
            this.grbTotales = new System.Windows.Forms.GroupBox();
            this.lblCantDif = new System.Windows.Forms.Label();
            this.lblECantDif = new System.Windows.Forms.Label();
            this.lblCantTot = new System.Windows.Forms.Label();
            this.lblECantTot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEDescuento = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblEImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblESubtotal = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnRecuperarVenta = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblECliente = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblEFolio = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.bgwImagen = new System.ComponentModel.BackgroundWorker();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).BeginInit();
            this.grbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVendedor
            // 
            this.btnVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnVendedor.FlatAppearance.BorderSize = 0;
            this.btnVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnVendedor.ForeColor = System.Drawing.Color.White;
            this.btnVendedor.Location = new System.Drawing.Point(12, 343);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(200, 60);
            this.btnVendedor.TabIndex = 51;
            this.btnVendedor.Text = "Vendedor (F11)";
            this.btnVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Visible = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblVendedor.Location = new System.Drawing.Point(88, 36);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 22);
            this.lblVendedor.TabIndex = 47;
            this.lblVendedor.Visible = false;
            // 
            // lblEVendedor
            // 
            this.lblEVendedor.AutoSize = true;
            this.lblEVendedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEVendedor.Location = new System.Drawing.Point(8, 36);
            this.lblEVendedor.Name = "lblEVendedor";
            this.lblEVendedor.Size = new System.Drawing.Size(74, 22);
            this.lblEVendedor.TabIndex = 46;
            this.lblEVendedor.Text = "Atiende:";
            this.lblEVendedor.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 409);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 60);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar cotización (F12)";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pcbProducto
            // 
            this.pcbProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbProducto.Enabled = false;
            this.pcbProducto.Location = new System.Drawing.Point(12, 66);
            this.pcbProducto.Name = "pcbProducto";
            this.pcbProducto.Size = new System.Drawing.Size(200, 200);
            this.pcbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProducto.TabIndex = 54;
            this.pcbProducto.TabStop = false;
            // 
            // grbTotales
            // 
            this.grbTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTotales.Controls.Add(this.lblCantDif);
            this.grbTotales.Controls.Add(this.lblECantDif);
            this.grbTotales.Controls.Add(this.lblCantTot);
            this.grbTotales.Controls.Add(this.lblECantTot);
            this.grbTotales.Controls.Add(this.lblTotal);
            this.grbTotales.Controls.Add(this.lblETotal);
            this.grbTotales.Controls.Add(this.lblDescuento);
            this.grbTotales.Controls.Add(this.lblEDescuento);
            this.grbTotales.Controls.Add(this.lblImpuesto);
            this.grbTotales.Controls.Add(this.lblEImpuesto);
            this.grbTotales.Controls.Add(this.lblSubtotal);
            this.grbTotales.Controls.Add(this.lblESubtotal);
            this.grbTotales.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbTotales.Location = new System.Drawing.Point(12, 510);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(406, 110);
            this.grbTotales.TabIndex = 43;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Información de la cotización";
            this.grbTotales.Visible = false;
            // 
            // lblCantDif
            // 
            this.lblCantDif.AutoSize = true;
            this.lblCantDif.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCantDif.Location = new System.Drawing.Point(317, 64);
            this.lblCantDif.Name = "lblCantDif";
            this.lblCantDif.Size = new System.Drawing.Size(16, 18);
            this.lblCantDif.TabIndex = 9;
            this.lblCantDif.Text = "0";
            // 
            // lblECantDif
            // 
            this.lblECantDif.AutoSize = true;
            this.lblECantDif.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantDif.Location = new System.Drawing.Point(178, 64);
            this.lblECantDif.Name = "lblECantDif";
            this.lblECantDif.Size = new System.Drawing.Size(133, 18);
            this.lblECantDif.TabIndex = 8;
            this.lblECantDif.Text = "Cant. productos dif.:";
            // 
            // lblCantTot
            // 
            this.lblCantTot.AutoSize = true;
            this.lblCantTot.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCantTot.Location = new System.Drawing.Point(317, 87);
            this.lblCantTot.Name = "lblCantTot";
            this.lblCantTot.Size = new System.Drawing.Size(16, 18);
            this.lblCantTot.TabIndex = 11;
            this.lblCantTot.Text = "0";
            // 
            // lblECantTot
            // 
            this.lblECantTot.AutoSize = true;
            this.lblECantTot.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantTot.Location = new System.Drawing.Point(203, 87);
            this.lblECantTot.Name = "lblECantTot";
            this.lblECantTot.Size = new System.Drawing.Size(108, 18);
            this.lblECantTot.TabIndex = 10;
            this.lblECantTot.Text = "Total productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(90, 87);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 18);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotal.Location = new System.Drawing.Point(42, 87);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(42, 18);
            this.lblETotal.TabIndex = 6;
            this.lblETotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.Location = new System.Drawing.Point(90, 64);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(44, 18);
            this.lblDescuento.TabIndex = 5;
            this.lblDescuento.Text = "$0.00";
            // 
            // lblEDescuento
            // 
            this.lblEDescuento.AutoSize = true;
            this.lblEDescuento.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEDescuento.Location = new System.Drawing.Point(6, 64);
            this.lblEDescuento.Name = "lblEDescuento";
            this.lblEDescuento.Size = new System.Drawing.Size(78, 18);
            this.lblEDescuento.TabIndex = 4;
            this.lblEDescuento.Text = "Descuento:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblImpuesto.Location = new System.Drawing.Point(90, 41);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(44, 18);
            this.lblImpuesto.TabIndex = 3;
            this.lblImpuesto.Text = "$0.00";
            // 
            // lblEImpuesto
            // 
            this.lblEImpuesto.AutoSize = true;
            this.lblEImpuesto.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEImpuesto.Location = new System.Drawing.Point(14, 41);
            this.lblEImpuesto.Name = "lblEImpuesto";
            this.lblEImpuesto.Size = new System.Drawing.Size(70, 18);
            this.lblEImpuesto.TabIndex = 2;
            this.lblEImpuesto.Text = "Impuesto:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(90, 18);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(44, 18);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "$0.00";
            // 
            // lblESubtotal
            // 
            this.lblESubtotal.AutoSize = true;
            this.lblESubtotal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblESubtotal.Location = new System.Drawing.Point(20, 18);
            this.lblESubtotal.Name = "lblESubtotal";
            this.lblESubtotal.Size = new System.Drawing.Size(64, 18);
            this.lblESubtotal.TabIndex = 0;
            this.lblESubtotal.Text = "Subtotal:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 475);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(406, 29);
            this.txtBusqueda.TabIndex = 40;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(424, 625);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 60);
            this.btnClientes.TabIndex = 41;
            this.btnClientes.Text = "Clientes (F3)";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(796, 625);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 60);
            this.btnCrear.TabIndex = 53;
            this.btnCrear.Text = "Crear venta (F5)";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Visible = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(796, 475);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 60);
            this.btnProductos.TabIndex = 42;
            this.btnProductos.Text = "Productos (F4)";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnRecuperarVenta
            // 
            this.btnRecuperarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecuperarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnRecuperarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRecuperarVenta.FlatAppearance.BorderSize = 0;
            this.btnRecuperarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnRecuperarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRecuperarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarVenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnRecuperarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarVenta.Location = new System.Drawing.Point(218, 625);
            this.btnRecuperarVenta.Name = "btnRecuperarVenta";
            this.btnRecuperarVenta.Size = new System.Drawing.Size(200, 60);
            this.btnRecuperarVenta.TabIndex = 39;
            this.btnRecuperarVenta.Text = "Recuperar cotización (F2)";
            this.btnRecuperarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecuperarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecuperarVenta.UseVisualStyleBackColor = false;
            this.btnRecuperarVenta.Click += new System.EventHandler(this.btnRecuperarVenta_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnNuevaVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(12, 625);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(200, 60);
            this.btnNuevaVenta.TabIndex = 38;
            this.btnNuevaVenta.Text = "Nueva cotización (F1)";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(88, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 22);
            this.lblCliente.TabIndex = 45;
            this.lblCliente.Visible = false;
            // 
            // lblECliente
            // 
            this.lblECliente.AutoSize = true;
            this.lblECliente.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblECliente.Location = new System.Drawing.Point(14, 9);
            this.lblECliente.Name = "lblECliente";
            this.lblECliente.Size = new System.Drawing.Size(68, 22);
            this.lblECliente.TabIndex = 44;
            this.lblECliente.Text = "Cliente:";
            this.lblECliente.Visible = false;
            // 
            // lblFolio
            // 
            this.lblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblFolio.Location = new System.Drawing.Point(913, 9);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(0, 22);
            this.lblFolio.TabIndex = 49;
            this.lblFolio.Visible = false;
            // 
            // lblEFolio
            // 
            this.lblEFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEFolio.AutoSize = true;
            this.lblEFolio.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEFolio.Location = new System.Drawing.Point(751, 9);
            this.lblEFolio.Name = "lblEFolio";
            this.lblEFolio.Size = new System.Drawing.Size(156, 22);
            this.lblEFolio.TabIndex = 48;
            this.lblEFolio.Text = "Folio de cotización:";
            this.lblEFolio.Visible = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CCodigo,
            this.CNombre,
            this.CPrecio,
            this.CCant,
            this.CDescuento,
            this.CUnidad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvProductos.Location = new System.Drawing.Point(218, 66);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(778, 403);
            this.dgvProductos.TabIndex = 50;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseDoubleClick);
            this.dgvProductos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_RowEnter);
            this.dgvProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductos_RowsAdded);
            this.dgvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductos_RowsRemoved);
            // 
            // bgwImagen
            // 
            this.bgwImagen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwImagen_DoWork);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Cód. producto";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Width = 150;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CPrecio
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.CPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CCant
            // 
            dataGridViewCellStyle4.Format = "0.00";
            this.CCant.DefaultCellStyle = dataGridViewCellStyle4;
            this.CCant.HeaderText = "Cantidad";
            this.CCant.Name = "CCant";
            // 
            // CDescuento
            // 
            dataGridViewCellStyle5.Format = "##0.##%";
            this.CDescuento.DefaultCellStyle = dataGridViewCellStyle5;
            this.CDescuento.HeaderText = "Descuento";
            this.CDescuento.Name = "CDescuento";
            // 
            // CUnidad
            // 
            this.CUnidad.HeaderText = "Unidad";
            this.CUnidad.Name = "CUnidad";
            this.CUnidad.Visible = false;
            // 
            // frmCotizacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblEVendedor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pcbProducto);
            this.Controls.Add(this.grbTotales);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnRecuperarVenta);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblECliente);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblEFolio);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCotizacion_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProducto)).EndInit();
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblEVendedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pcbProducto;
        private System.Windows.Forms.GroupBox grbTotales;
        private System.Windows.Forms.Label lblCantDif;
        private System.Windows.Forms.Label lblECantDif;
        private System.Windows.Forms.Label lblCantTot;
        private System.Windows.Forms.Label lblECantTot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEDescuento;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblEImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblESubtotal;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnRecuperarVenta;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblECliente;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblEFolio;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.ComponentModel.BackgroundWorker bgwImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidad;
    }
}