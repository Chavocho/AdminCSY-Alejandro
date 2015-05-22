namespace EC_Admin.Forms
{
    partial class frmCompraProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
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
            this.btnAceptar.Location = new System.Drawing.Point(750, 399);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEBusqueda
            // 
            this.lblEBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEBusqueda.AutoSize = true;
            this.lblEBusqueda.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEBusqueda.Location = new System.Drawing.Point(394, 17);
            this.lblEBusqueda.Name = "lblEBusqueda";
            this.lblEBusqueda.Size = new System.Drawing.Size(254, 18);
            this.lblEBusqueda.TabIndex = 4;
            this.lblEBusqueda.Text = "Buscar cliente por nombre o razón social";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(654, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(246, 29);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNombre,
            this.CRazonSocial,
            this.CTelefonos,
            this.CCorreo});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvProveedores.Location = new System.Drawing.Point(12, 47);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(888, 346);
            this.dgvProveedores.TabIndex = 6;
            this.dgvProveedores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_RowEnter);
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
            // CRazonSocial
            // 
            this.CRazonSocial.HeaderText = "Razón social";
            this.CRazonSocial.Name = "CRazonSocial";
            this.CRazonSocial.Width = 200;
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
            // frmCompraProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 457);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvProveedores);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCompraProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de proveedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCompraProveedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
    }
}