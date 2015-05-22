namespace EC_Admin.Forms
{
    partial class frmAsignarDomicilio
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
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
            this.dgvDomicilio.Location = new System.Drawing.Point(12, 12);
            this.dgvDomicilio.MultiSelect = false;
            this.dgvDomicilio.Name = "dgvDomicilio";
            this.dgvDomicilio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDomicilio.RowHeadersVisible = false;
            this.dgvDomicilio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDomicilio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDomicilio.Size = new System.Drawing.Size(984, 385);
            this.dgvDomicilio.TabIndex = 0;
            this.dgvDomicilio.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDomicilio_RowEnter);
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
            this.btnAceptar.Location = new System.Drawing.Point(846, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Asignar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // bgwBusqueda
            // 
            this.bgwBusqueda.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusqueda_DoWork);
            this.bgwBusqueda.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusqueda_RunWorkerCompleted);
            // 
            // tmrEspera
            // 
            this.tmrEspera.Tick += new System.EventHandler(this.tmrEspera_Tick);
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
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(690, 403);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 46);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Crear domicilio";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // frmAsignarDomicilio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDomicilio);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmAsignarDomicilio";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar domicilio";
            this.Load += new System.EventHandler(this.frmAsignarDomicilio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDomicilio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDomicilio;
        private System.Windows.Forms.Button btnAceptar;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstado;
    }
}