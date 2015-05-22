namespace EC_Admin.Forms
{
    partial class frmDomicilio
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
            this.dgvDomicilio = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CColonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDomicilio
            // 
            this.dgvDomicilio.AllowUserToAddRows = false;
            this.dgvDomicilio.AllowUserToDeleteRows = false;
            this.dgvDomicilio.AllowUserToResizeColumns = false;
            this.dgvDomicilio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvDomicilio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDomicilio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDomicilio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDomicilio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDomicilio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDomicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDomicilio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CDireccion,
            this.CCP,
            this.CColonia,
            this.CCiudad,
            this.CEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDomicilio.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDomicilio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDomicilio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvDomicilio.Location = new System.Drawing.Point(193, 12);
            this.dgvDomicilio.MultiSelect = false;
            this.dgvDomicilio.Name = "dgvDomicilio";
            this.dgvDomicilio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDomicilio.RowHeadersVisible = false;
            this.dgvDomicilio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomicilio.Size = new System.Drawing.Size(803, 438);
            this.dgvDomicilio.TabIndex = 0;
            this.dgvDomicilio.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDomicilio_RowEnter);
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
            this.btnEliminar.Location = new System.Drawing.Point(12, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar domicilio";
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
            this.btnEditar.Location = new System.Drawing.Point(12, 64);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 46);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Modificar domicilio";
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
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo domicilio";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CDireccion
            // 
            this.CDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDireccion.HeaderText = "Dirección";
            this.CDireccion.Name = "CDireccion";
            // 
            // CCP
            // 
            this.CCP.HeaderText = "Cód. Postal";
            this.CCP.Name = "CCP";
            // 
            // CColonia
            // 
            this.CColonia.HeaderText = "Colonia";
            this.CColonia.Name = "CColonia";
            this.CColonia.Width = 120;
            // 
            // CCiudad
            // 
            this.CCiudad.HeaderText = "Ciudad";
            this.CCiudad.Name = "CCiudad";
            this.CCiudad.Width = 120;
            // 
            // CEstado
            // 
            this.CEstado.HeaderText = "Estado";
            this.CEstado.Name = "CEstado";
            this.CEstado.Width = 120;
            // 
            // frmDomicilio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 462);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDomicilio);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmDomicilio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domicilios";
            this.Load += new System.EventHandler(this.frmDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDomicilio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
    }
}