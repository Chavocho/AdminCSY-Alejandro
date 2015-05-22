namespace EC_Admin.Forms
{
    partial class frmConfigAlmacen
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
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumAlm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEditarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEditarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEditarUsuario.Location = new System.Drawing.Point(12, 64);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(175, 46);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Modificar almacen";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(175, 46);
            this.btnNuevoUsuario.TabIndex = 1;
            this.btnNuevoUsuario.Text = "Nuevo almacen";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.AllowUserToAddRows = false;
            this.dgvAlmacen.AllowUserToDeleteRows = false;
            this.dgvAlmacen.AllowUserToResizeColumns = false;
            this.dgvAlmacen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvAlmacen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlmacen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CTrabajador,
            this.CNumAlm,
            this.CDescripcion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlmacen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlmacen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlmacen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvAlmacen.Location = new System.Drawing.Point(193, 12);
            this.dgvAlmacen.MultiSelect = false;
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlmacen.RowHeadersVisible = false;
            this.dgvAlmacen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacen.Size = new System.Drawing.Size(701, 338);
            this.dgvAlmacen.TabIndex = 0;
            this.dgvAlmacen.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacen_RowEnter);
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
            // CTrabajador
            // 
            this.CTrabajador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTrabajador.HeaderText = "Jefe de almacen";
            this.CTrabajador.Name = "CTrabajador";
            // 
            // CNumAlm
            // 
            this.CNumAlm.HeaderText = "Núm. Almacen";
            this.CNumAlm.Name = "CNumAlm";
            this.CNumAlm.Width = 130;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.Width = 200;
            // 
            // frmConfigAlmacen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 362);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.dgvAlmacen);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.Name = "frmConfigAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacenes";
            this.Load += new System.EventHandler(this.frmConfigAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumAlm;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
    }
}