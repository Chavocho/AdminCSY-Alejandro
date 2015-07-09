namespace EC_Admin.Forms
{
    partial class frmDevoluciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos01 = new System.Windows.Forms.DataGridView();
            this.CID01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCant01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPromocion01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductos02 = new System.Windows.Forms.DataGridView();
            this.CID02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPromocion02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lblCantDif = new System.Windows.Forms.Label();
            this.lblECantDif = new System.Windows.Forms.Label();
            this.lblCantTot = new System.Windows.Forms.Label();
            this.lblECantTot = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.grbTotales = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos02)).BeginInit();
            this.grbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos01
            // 
            this.dgvProductos01.AllowDrop = true;
            this.dgvProductos01.AllowUserToAddRows = false;
            this.dgvProductos01.AllowUserToDeleteRows = false;
            this.dgvProductos01.AllowUserToResizeColumns = false;
            this.dgvProductos01.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvProductos01.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos01.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvProductos01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos01.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos01.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos01.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID01,
            this.CCodigo01,
            this.CNombre01,
            this.CPrecio01,
            this.CCant01,
            this.CPromocion01});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos01.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos01.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos01.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvProductos01.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos01.MultiSelect = false;
            this.dgvProductos01.Name = "dgvProductos01";
            this.dgvProductos01.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos01.RowHeadersVisible = false;
            this.dgvProductos01.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos01.Size = new System.Drawing.Size(489, 386);
            this.dgvProductos01.TabIndex = 13;
            this.dgvProductos01.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvProductos01_DragDrop);
            this.dgvProductos01.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvProductos01_DragEnter);
            this.dgvProductos01.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvProductos01_DragOver);
            this.dgvProductos01.DragLeave += new System.EventHandler(this.dgvProductos01_DragLeave);
            this.dgvProductos01.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseDoubleClick);
            this.dgvProductos01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProductos01_MouseDown);
            this.dgvProductos01.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvProductos01_MouseMove);
            // 
            // CID01
            // 
            this.CID01.HeaderText = "ID";
            this.CID01.Name = "CID01";
            this.CID01.Visible = false;
            // 
            // CCodigo01
            // 
            this.CCodigo01.HeaderText = "Cód. producto";
            this.CCodigo01.Name = "CCodigo01";
            this.CCodigo01.Width = 150;
            // 
            // CNombre01
            // 
            this.CNombre01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre01.HeaderText = "Nombre";
            this.CNombre01.Name = "CNombre01";
            // 
            // CPrecio01
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.CPrecio01.DefaultCellStyle = dataGridViewCellStyle3;
            this.CPrecio01.HeaderText = "Precio";
            this.CPrecio01.Name = "CPrecio01";
            // 
            // CCant01
            // 
            dataGridViewCellStyle4.Format = "0";
            this.CCant01.DefaultCellStyle = dataGridViewCellStyle4;
            this.CCant01.HeaderText = "Cantidad";
            this.CCant01.Name = "CCant01";
            // 
            // CPromocion01
            // 
            this.CPromocion01.HeaderText = "Promocion";
            this.CPromocion01.Name = "CPromocion01";
            this.CPromocion01.Visible = false;
            // 
            // dgvProductos02
            // 
            this.dgvProductos02.AllowDrop = true;
            this.dgvProductos02.AllowUserToAddRows = false;
            this.dgvProductos02.AllowUserToDeleteRows = false;
            this.dgvProductos02.AllowUserToResizeColumns = false;
            this.dgvProductos02.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvProductos02.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos02.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvProductos02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos02.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos02.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos02.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos02.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID02,
            this.CCodigo02,
            this.CNombre02,
            this.CPrecio02,
            this.CCantidad02,
            this.CPromocion02});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos02.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos02.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductos02.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvProductos02.Location = new System.Drawing.Point(507, 12);
            this.dgvProductos02.MultiSelect = false;
            this.dgvProductos02.Name = "dgvProductos02";
            this.dgvProductos02.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos02.RowHeadersVisible = false;
            this.dgvProductos02.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos02.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos02.Size = new System.Drawing.Size(489, 385);
            this.dgvProductos02.TabIndex = 14;
            this.dgvProductos02.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvProductos02_DragDrop);
            this.dgvProductos02.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvProductos02_DragEnter);
            this.dgvProductos02.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvProductos02_DragOver);
            this.dgvProductos02.DragLeave += new System.EventHandler(this.dgvProductos02_DragLeave);
            this.dgvProductos02.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseDoubleClick);
            this.dgvProductos02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProductos02_MouseDown);
            this.dgvProductos02.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvProductos02_MouseMove);
            // 
            // CID02
            // 
            this.CID02.HeaderText = "ID";
            this.CID02.Name = "CID02";
            this.CID02.Visible = false;
            // 
            // CCodigo02
            // 
            this.CCodigo02.HeaderText = "Cód. producto";
            this.CCodigo02.Name = "CCodigo02";
            this.CCodigo02.Width = 150;
            // 
            // CNombre02
            // 
            this.CNombre02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre02.HeaderText = "Nombre";
            this.CNombre02.Name = "CNombre02";
            // 
            // CPrecio02
            // 
            dataGridViewCellStyle8.Format = "C2";
            this.CPrecio02.DefaultCellStyle = dataGridViewCellStyle8;
            this.CPrecio02.HeaderText = "Precio";
            this.CPrecio02.Name = "CPrecio02";
            // 
            // CCantidad02
            // 
            dataGridViewCellStyle9.Format = "0";
            this.CCantidad02.DefaultCellStyle = dataGridViewCellStyle9;
            this.CCantidad02.HeaderText = "Cantidad";
            this.CCantidad02.Name = "CCantidad02";
            // 
            // CPromocion02
            // 
            this.CPromocion02.HeaderText = "Promocion";
            this.CPromocion02.Name = "CPromocion02";
            this.CPromocion02.Visible = false;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolver.Location = new System.Drawing.Point(846, 403);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(150, 46);
            this.btnDevolver.TabIndex = 15;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblCantDif
            // 
            this.lblCantDif.AutoSize = true;
            this.lblCantDif.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCantDif.Location = new System.Drawing.Point(333, 18);
            this.lblCantDif.Name = "lblCantDif";
            this.lblCantDif.Size = new System.Drawing.Size(16, 18);
            this.lblCantDif.TabIndex = 19;
            this.lblCantDif.Text = "0";
            // 
            // lblECantDif
            // 
            this.lblECantDif.AutoSize = true;
            this.lblECantDif.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantDif.Location = new System.Drawing.Point(194, 18);
            this.lblECantDif.Name = "lblECantDif";
            this.lblECantDif.Size = new System.Drawing.Size(133, 18);
            this.lblECantDif.TabIndex = 18;
            this.lblECantDif.Text = "Cant. productos dif.:";
            // 
            // lblCantTot
            // 
            this.lblCantTot.AutoSize = true;
            this.lblCantTot.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblCantTot.Location = new System.Drawing.Point(575, 18);
            this.lblCantTot.Name = "lblCantTot";
            this.lblCantTot.Size = new System.Drawing.Size(16, 18);
            this.lblCantTot.TabIndex = 21;
            this.lblCantTot.Text = "0";
            // 
            // lblECantTot
            // 
            this.lblECantTot.AutoSize = true;
            this.lblECantTot.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantTot.Location = new System.Drawing.Point(461, 18);
            this.lblECantTot.Name = "lblECantTot";
            this.lblECantTot.Size = new System.Drawing.Size(108, 18);
            this.lblECantTot.TabIndex = 20;
            this.lblECantTot.Text = "Total productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(54, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 18);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotal.Location = new System.Drawing.Point(6, 18);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(42, 18);
            this.lblETotal.TabIndex = 16;
            this.lblETotal.Text = "Total:";
            // 
            // grbTotales
            // 
            this.grbTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTotales.Controls.Add(this.lblECantTot);
            this.grbTotales.Controls.Add(this.lblTotal);
            this.grbTotales.Controls.Add(this.lblCantDif);
            this.grbTotales.Controls.Add(this.lblETotal);
            this.grbTotales.Controls.Add(this.lblCantTot);
            this.grbTotales.Controls.Add(this.lblECantDif);
            this.grbTotales.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbTotales.Location = new System.Drawing.Point(12, 404);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(689, 45);
            this.grbTotales.TabIndex = 22;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Información de venta";
            this.grbTotales.Visible = false;
            // 
            // frmDevoluciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.grbTotales);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvProductos02);
            this.Controls.Add(this.dgvProductos01);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución de productos";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos02)).EndInit();
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos01;
        private System.Windows.Forms.DataGridView dgvProductos02;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lblCantDif;
        private System.Windows.Forms.Label lblECantDif;
        private System.Windows.Forms.Label lblCantTot;
        private System.Windows.Forms.Label lblECantTot;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.GroupBox grbTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCant01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPromocion01;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID02;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo02;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre02;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio02;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad02;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPromocion02;
    }
}