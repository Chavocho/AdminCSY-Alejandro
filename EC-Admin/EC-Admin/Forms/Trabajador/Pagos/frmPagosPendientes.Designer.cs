namespace EC_Admin.Forms
{
    partial class frmPagosPendientes
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
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUltimoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPago = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblEBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeColumns = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNombre,
            this.CNomina,
            this.CPuesto,
            this.CSueldo,
            this.CUltimoPago,
            this.CPago});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvPagos.Location = new System.Drawing.Point(12, 47);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(984, 402);
            this.dgvPagos.TabIndex = 2;
            this.dgvPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellClick);
            this.dgvPagos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_RowEnter);
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
            // CNomina
            // 
            this.CNomina.HeaderText = "Núm. nómina";
            this.CNomina.Name = "CNomina";
            this.CNomina.Width = 150;
            // 
            // CPuesto
            // 
            this.CPuesto.HeaderText = "Puesto";
            this.CPuesto.Name = "CPuesto";
            this.CPuesto.Width = 150;
            // 
            // CSueldo
            // 
            this.CSueldo.HeaderText = "Sueldo";
            this.CSueldo.Name = "CSueldo";
            // 
            // CUltimoPago
            // 
            this.CUltimoPago.HeaderText = "Último pago";
            this.CUltimoPago.Name = "CUltimoPago";
            this.CUltimoPago.Width = 150;
            // 
            // CPago
            // 
            this.CPago.HeaderText = "";
            this.CPago.Name = "CPago";
            this.CPago.Text = "Efectuar pago";
            this.CPago.UseColumnTextForButtonValue = true;
            // 
            // lblEBusqueda
            // 
            this.lblEBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEBusqueda.AutoSize = true;
            this.lblEBusqueda.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEBusqueda.Location = new System.Drawing.Point(430, 17);
            this.lblEBusqueda.Name = "lblEBusqueda";
            this.lblEBusqueda.Size = new System.Drawing.Size(314, 18);
            this.lblEBusqueda.TabIndex = 0;
            this.lblEBusqueda.Text = "Buscar producto por nombre o número de nómina";
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
            // frmPagosPendientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.lblEBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvPagos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmPagosPendientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos pendientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lblEBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUltimoPago;
        private System.Windows.Forms.DataGridViewButtonColumn CPago;
    }
}