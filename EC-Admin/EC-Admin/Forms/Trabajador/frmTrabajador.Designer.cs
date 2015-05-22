namespace EC_Admin.Forms
{
    partial class frmTrabajador
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblEBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.btnPuestos = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.SuspendLayout();
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Dar baja a trabajador";
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
            this.btnEditar.Location = new System.Drawing.Point(12, 99);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 46);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Modificar trabajador";
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
            this.btnNuevo.Location = new System.Drawing.Point(12, 47);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo trabajador";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblEBusqueda
            // 
            this.lblEBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEBusqueda.AutoSize = true;
            this.lblEBusqueda.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEBusqueda.Location = new System.Drawing.Point(552, 17);
            this.lblEBusqueda.Name = "lblEBusqueda";
            this.lblEBusqueda.Size = new System.Drawing.Size(192, 18);
            this.lblEBusqueda.TabIndex = 0;
            this.lblEBusqueda.Text = "Buscar trabajador por nombre";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(750, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(246, 29);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.AllowUserToAddRows = false;
            this.dgvTrabajadores.AllowUserToDeleteRows = false;
            this.dgvTrabajadores.AllowUserToResizeColumns = false;
            this.dgvTrabajadores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvTrabajadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrabajadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrabajadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTrabajadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNombre,
            this.CPuesto,
            this.CTelefonos,
            this.CCorreo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrabajadores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrabajadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTrabajadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvTrabajadores.Location = new System.Drawing.Point(193, 47);
            this.dgvTrabajadores.MultiSelect = false;
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrabajadores.RowHeadersVisible = false;
            this.dgvTrabajadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTrabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrabajadores.Size = new System.Drawing.Size(803, 403);
            this.dgvTrabajadores.TabIndex = 2;
            this.dgvTrabajadores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_RowEnter);
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
            // CPuesto
            // 
            this.CPuesto.HeaderText = "Puesto";
            this.CPuesto.Name = "CPuesto";
            this.CPuesto.Width = 130;
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
            // btnPuestos
            // 
            this.btnPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnPuestos.FlatAppearance.BorderSize = 0;
            this.btnPuestos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuestos.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnPuestos.ForeColor = System.Drawing.Color.White;
            this.btnPuestos.Location = new System.Drawing.Point(12, 203);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Size = new System.Drawing.Size(175, 46);
            this.btnPuestos.TabIndex = 6;
            this.btnPuestos.Text = "Administrar puestos";
            this.btnPuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPuestos.UseVisualStyleBackColor = false;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(12, 255);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(175, 46);
            this.btnHorarios.TabIndex = 7;
            this.btnHorarios.Text = "Administrar horarios";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Visible = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Location = new System.Drawing.Point(12, 307);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(175, 46);
            this.btnIngreso.TabIndex = 8;
            this.btnIngreso.Text = "Ingreso";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Visible = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Location = new System.Drawing.Point(12, 359);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(175, 46);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Visible = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // frmTrabajador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnPuestos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblEBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvTrabajadores);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "frmTrabajador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblEBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.Button btnPuestos;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnPagos;
    }
}