namespace EC_Admin.Forms
{
    partial class frmTraspasos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTraspasos = new System.Windows.Forms.DataGridView();
            this.lblETipoPrecio = new System.Windows.Forms.Label();
            this.cboTraspasos = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.lblEFechaIni = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDSucursalSolicito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDSucursalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDSucursalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSucursalOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSucursalDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspasos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTraspasos
            // 
            this.dgvTraspasos.AllowUserToAddRows = false;
            this.dgvTraspasos.AllowUserToDeleteRows = false;
            this.dgvTraspasos.AllowUserToResizeColumns = false;
            this.dgvTraspasos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvTraspasos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraspasos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraspasos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvTraspasos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTraspasos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTraspasos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraspasos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraspasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraspasos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CIDSucursalSolicito,
            this.CIDSucursalOrigen,
            this.CIDSucursalDestino,
            this.CSucursalOrigen,
            this.CSucursalDestino,
            this.CDescripcion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraspasos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTraspasos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTraspasos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvTraspasos.Location = new System.Drawing.Point(193, 65);
            this.dgvTraspasos.MultiSelect = false;
            this.dgvTraspasos.Name = "dgvTraspasos";
            this.dgvTraspasos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTraspasos.RowHeadersVisible = false;
            this.dgvTraspasos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTraspasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraspasos.Size = new System.Drawing.Size(803, 384);
            this.dgvTraspasos.TabIndex = 4;
            this.dgvTraspasos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraspasos_RowEnter);
            // 
            // lblETipoPrecio
            // 
            this.lblETipoPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblETipoPrecio.AutoSize = true;
            this.lblETipoPrecio.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETipoPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoPrecio.Location = new System.Drawing.Point(190, 9);
            this.lblETipoPrecio.Name = "lblETipoPrecio";
            this.lblETipoPrecio.Size = new System.Drawing.Size(115, 18);
            this.lblETipoPrecio.TabIndex = 41;
            this.lblETipoPrecio.Text = "Buscar traspasos:";
            // 
            // cboTraspasos
            // 
            this.cboTraspasos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTraspasos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTraspasos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraspasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTraspasos.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTraspasos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTraspasos.FormattingEnabled = true;
            this.cboTraspasos.Items.AddRange(new object[] {
            "Pendientes",
            "Aceptados",
            "Recibidos",
            "Rechazados"});
            this.cboTraspasos.Location = new System.Drawing.Point(193, 30);
            this.cboTraspasos.Name = "cboTraspasos";
            this.cboTraspasos.Size = new System.Drawing.Size(200, 29);
            this.cboTraspasos.TabIndex = 40;
            this.cboTraspasos.SelectedIndexChanged += new System.EventHandler(this.cboTraspasos_SelectedIndexChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(649, 30);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(244, 29);
            this.dtpFechaFin.TabIndex = 45;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaIni.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(399, 30);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(244, 29);
            this.dtpFechaIni.TabIndex = 43;
            this.dtpFechaIni.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(656, 9);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 44;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // lblEFechaIni
            // 
            this.lblEFechaIni.AutoSize = true;
            this.lblEFechaIni.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaIni.Location = new System.Drawing.Point(396, 9);
            this.lblEFechaIni.Name = "lblEFechaIni";
            this.lblEFechaIni.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaIni.TabIndex = 42;
            this.lblEFechaIni.Text = "Fecha de inicio";
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
            this.btnNuevo.Location = new System.Drawing.Point(12, 65);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo traspaso";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(12, 117);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(175, 46);
            this.btnDetalle.TabIndex = 47;
            this.btnDetalle.Text = "Detalles de traspaso";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // bgwBusqueda
            // 
            this.bgwBusqueda.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusqueda_DoWork);
            this.bgwBusqueda.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusqueda_RunWorkerCompleted);
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            this.tmrEspera.Tick += new System.EventHandler(this.tmrEspera_Tick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(899, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 30);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CIDSucursalSolicito
            // 
            this.CIDSucursalSolicito.HeaderText = "ID Sucursal Solicito";
            this.CIDSucursalSolicito.Name = "CIDSucursalSolicito";
            this.CIDSucursalSolicito.Visible = false;
            // 
            // CIDSucursalOrigen
            // 
            this.CIDSucursalOrigen.HeaderText = "ID Sucursal Origen";
            this.CIDSucursalOrigen.Name = "CIDSucursalOrigen";
            this.CIDSucursalOrigen.Visible = false;
            // 
            // CIDSucursalDestino
            // 
            this.CIDSucursalDestino.HeaderText = "ID Sucursal Destino";
            this.CIDSucursalDestino.Name = "CIDSucursalDestino";
            this.CIDSucursalDestino.Visible = false;
            // 
            // CSucursalOrigen
            // 
            this.CSucursalOrigen.HeaderText = "Sucursal de origen";
            this.CSucursalOrigen.Name = "CSucursalOrigen";
            this.CSucursalOrigen.Width = 200;
            // 
            // CSucursalDestino
            // 
            this.CSucursalDestino.HeaderText = "Sucursal de destino";
            this.CSucursalDestino.Name = "CSucursalDestino";
            this.CSucursalDestino.Width = 200;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            // 
            // frmTraspasos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.lblEFechaFin);
            this.Controls.Add(this.lblEFechaIni);
            this.Controls.Add(this.lblETipoPrecio);
            this.Controls.Add(this.cboTraspasos);
            this.Controls.Add(this.dgvTraspasos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmTraspasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traspasos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraspasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTraspasos;
        private System.Windows.Forms.Label lblETipoPrecio;
        private System.Windows.Forms.ComboBox cboTraspasos;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblEFechaFin;
        private System.Windows.Forms.Label lblEFechaIni;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDetalle;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDSucursalSolicito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDSucursalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDSucursalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSucursalOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSucursalDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
    }
}