namespace EC_Admin.Forms
{
    partial class frmNuevaCompra
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
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
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblEProveedor = new System.Windows.Forms.Label();
            this.lblComprador = new System.Windows.Forms.Label();
            this.lblEComprador = new System.Windows.Forms.Label();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.lblEFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblERemision = new System.Windows.Forms.Label();
            this.chbFactura = new System.Windows.Forms.CheckBox();
            this.chbRemision = new System.Windows.Forms.CheckBox();
            this.txtRemision = new System.Windows.Forms.TextBox();
            this.lblEDatos = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblETipoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grbTotales.SuspendLayout();
            this.grbPago.SuspendLayout();
            this.SuspendLayout();
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
            this.CCosto,
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
            this.dgvProductos.Location = new System.Drawing.Point(12, 66);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(984, 392);
            this.dgvProductos.TabIndex = 13;
            this.dgvProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseDoubleClick);
            this.dgvProductos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_RowEnter);
            this.dgvProductos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProductos_RowsAdded);
            this.dgvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductos_RowsRemoved);
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
            this.grbTotales.Location = new System.Drawing.Point(12, 509);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(406, 110);
            this.grbTotales.TabIndex = 15;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Información de venta";
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
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 464);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(406, 29);
            this.txtBusqueda.TabIndex = 14;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Location = new System.Drawing.Point(218, 625);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(200, 60);
            this.btnProveedor.TabIndex = 16;
            this.btnProveedor.Text = "Proveedor (F2)";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(796, 625);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(200, 60);
            this.btnCobrar.TabIndex = 18;
            this.btnCobrar.Text = "Aceptar (F12)";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(424, 625);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(200, 60);
            this.btnProductos.TabIndex = 17;
            this.btnProductos.Text = "Productos (F3)";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblProveedor.Location = new System.Drawing.Point(101, 9);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(0, 22);
            this.lblProveedor.TabIndex = 20;
            // 
            // lblEProveedor
            // 
            this.lblEProveedor.AutoSize = true;
            this.lblEProveedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEProveedor.Location = new System.Drawing.Point(8, 9);
            this.lblEProveedor.Name = "lblEProveedor";
            this.lblEProveedor.Size = new System.Drawing.Size(93, 22);
            this.lblEProveedor.TabIndex = 19;
            this.lblEProveedor.Text = "Proveedor:";
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblComprador.Location = new System.Drawing.Point(91, 36);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(0, 22);
            this.lblComprador.TabIndex = 22;
            // 
            // lblEComprador
            // 
            this.lblEComprador.AutoSize = true;
            this.lblEComprador.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEComprador.Location = new System.Drawing.Point(8, 36);
            this.lblEComprador.Name = "lblEComprador";
            this.lblEComprador.Size = new System.Drawing.Size(77, 22);
            this.lblEComprador.TabIndex = 21;
            this.lblEComprador.Text = "Compró:";
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
            this.btnVendedor.Location = new System.Drawing.Point(12, 625);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(200, 60);
            this.btnVendedor.TabIndex = 23;
            this.btnVendedor.Text = "Vendedor (F1)";
            this.btnVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // grbPago
            // 
            this.grbPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbPago.Controls.Add(this.lblEFactura);
            this.grbPago.Controls.Add(this.txtFactura);
            this.grbPago.Controls.Add(this.lblERemision);
            this.grbPago.Controls.Add(this.chbFactura);
            this.grbPago.Controls.Add(this.chbRemision);
            this.grbPago.Controls.Add(this.txtRemision);
            this.grbPago.Controls.Add(this.lblEDatos);
            this.grbPago.Controls.Add(this.txtDatos);
            this.grbPago.Controls.Add(this.lblETipoPago);
            this.grbPago.Controls.Add(this.cboTipoPago);
            this.grbPago.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbPago.Location = new System.Drawing.Point(424, 464);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(572, 155);
            this.grbPago.TabIndex = 24;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Información del pago";
            // 
            // lblEFactura
            // 
            this.lblEFactura.AutoSize = true;
            this.lblEFactura.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFactura.Location = new System.Drawing.Point(286, 98);
            this.lblEFactura.Name = "lblEFactura";
            this.lblEFactura.Size = new System.Drawing.Size(103, 18);
            this.lblEFactura.TabIndex = 20;
            this.lblEFactura.Text = "Folio de factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFactura.Enabled = false;
            this.txtFactura.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtFactura.Location = new System.Drawing.Point(289, 120);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(277, 29);
            this.txtFactura.TabIndex = 19;
            // 
            // lblERemision
            // 
            this.lblERemision.AutoSize = true;
            this.lblERemision.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblERemision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERemision.Location = new System.Drawing.Point(3, 99);
            this.lblERemision.Name = "lblERemision";
            this.lblERemision.Size = new System.Drawing.Size(111, 18);
            this.lblERemision.TabIndex = 18;
            this.lblERemision.Text = "Folio de remisión";
            // 
            // chbFactura
            // 
            this.chbFactura.AutoSize = true;
            this.chbFactura.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbFactura.Location = new System.Drawing.Point(289, 74);
            this.chbFactura.Name = "chbFactura";
            this.chbFactura.Size = new System.Drawing.Size(74, 22);
            this.chbFactura.TabIndex = 16;
            this.chbFactura.Text = "Factura";
            this.chbFactura.UseVisualStyleBackColor = true;
            this.chbFactura.CheckedChanged += new System.EventHandler(this.chbFactura_CheckedChanged);
            // 
            // chbRemision
            // 
            this.chbRemision.AutoSize = true;
            this.chbRemision.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbRemision.Location = new System.Drawing.Point(6, 74);
            this.chbRemision.Name = "chbRemision";
            this.chbRemision.Size = new System.Drawing.Size(83, 22);
            this.chbRemision.TabIndex = 15;
            this.chbRemision.Text = "Remisión";
            this.chbRemision.UseVisualStyleBackColor = true;
            this.chbRemision.CheckedChanged += new System.EventHandler(this.chbRemision_CheckedChanged);
            // 
            // txtRemision
            // 
            this.txtRemision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemision.Enabled = false;
            this.txtRemision.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRemision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRemision.Location = new System.Drawing.Point(6, 121);
            this.txtRemision.Name = "txtRemision";
            this.txtRemision.Size = new System.Drawing.Size(277, 29);
            this.txtRemision.TabIndex = 17;
            // 
            // lblEDatos
            // 
            this.lblEDatos.AutoSize = true;
            this.lblEDatos.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDatos.Location = new System.Drawing.Point(286, 18);
            this.lblEDatos.Name = "lblEDatos";
            this.lblEDatos.Size = new System.Drawing.Size(108, 18);
            this.lblEDatos.TabIndex = 14;
            this.lblEDatos.Text = "Núm. de cheque";
            this.lblEDatos.Visible = false;
            // 
            // txtDatos
            // 
            this.txtDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDatos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDatos.Location = new System.Drawing.Point(289, 39);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(277, 29);
            this.txtDatos.TabIndex = 13;
            this.txtDatos.Visible = false;
            // 
            // lblETipoPago
            // 
            this.lblETipoPago.AutoSize = true;
            this.lblETipoPago.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoPago.Location = new System.Drawing.Point(3, 18);
            this.lblETipoPago.Name = "lblETipoPago";
            this.lblETipoPago.Size = new System.Drawing.Size(108, 18);
            this.lblETipoPago.TabIndex = 12;
            this.lblETipoPago.Text = "Método de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque",
            "Crédito",
            "Débito",
            "Transferencia"});
            this.cboTipoPago.Location = new System.Drawing.Point(6, 39);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(277, 29);
            this.cboTipoPago.TabIndex = 11;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
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
            // CCosto
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.CCosto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
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
            // frmNuevaCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.lblEComprador);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblEProveedor);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.grbTotales);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmNuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNuevaCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
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
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblEProveedor;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.Label lblEComprador;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.Label lblETipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label lblERemision;
        private System.Windows.Forms.CheckBox chbFactura;
        private System.Windows.Forms.CheckBox chbRemision;
        private System.Windows.Forms.TextBox txtRemision;
        private System.Windows.Forms.Label lblEDatos;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lblEFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnidad;
    }
}