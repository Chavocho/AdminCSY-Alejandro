namespace EC_Admin.Forms
{
    partial class frmUsuariosEliminados
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestablecerUsuario = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CUser,
            this.CNombre,
            this.CCorreo,
            this.CNivel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(193, 12);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(747, 399);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_RowEnter);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CUser
            // 
            this.CUser.HeaderText = "Usuario";
            this.CUser.Name = "CUser";
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            this.CCorreo.Width = 250;
            // 
            // CNivel
            // 
            this.CNivel.HeaderText = "Nivel";
            this.CNivel.Name = "CNivel";
            this.CNivel.Width = 120;
            // 
            // btnRestablecerUsuario
            // 
            this.btnRestablecerUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestablecerUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnRestablecerUsuario.FlatAppearance.BorderSize = 0;
            this.btnRestablecerUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnRestablecerUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRestablecerUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerUsuario.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnRestablecerUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRestablecerUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnRestablecerUsuario.Name = "btnRestablecerUsuario";
            this.btnRestablecerUsuario.Size = new System.Drawing.Size(175, 46);
            this.btnRestablecerUsuario.TabIndex = 1;
            this.btnRestablecerUsuario.Text = "Restablecer usuario";
            this.btnRestablecerUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecerUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestablecerUsuario.UseVisualStyleBackColor = false;
            this.btnRestablecerUsuario.Click += new System.EventHandler(this.btnRestablecerUsuario_Click);
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
            // frmUsuariosEliminados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 422);
            this.Controls.Add(this.btnRestablecerUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmUsuariosEliminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios eliminados";
            this.Load += new System.EventHandler(this.frmUsuariosEliminados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnRestablecerUsuario;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNivel;
    }
}