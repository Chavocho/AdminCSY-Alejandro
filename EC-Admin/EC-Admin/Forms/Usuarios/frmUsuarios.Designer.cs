namespace EC_Admin.Forms
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNivelC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.bgwUsuarios = new System.ComponentModel.BackgroundWorker();
            this.btnUsuariosEliminados = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CUser,
            this.CNombre,
            this.CCorreo,
            this.CNivel,
            this.CNivelC});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
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
            // CNivelC
            // 
            this.CNivelC.HeaderText = "Nivel";
            this.CNivelC.Name = "CNivelC";
            this.CNivelC.Visible = false;
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
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
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
            this.btnEditarUsuario.Text = "Modificar usuario";
            this.btnEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(12, 116);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(175, 46);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // bgwUsuarios
            // 
            this.bgwUsuarios.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwUsuarios_DoWork);
            this.bgwUsuarios.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwUsuarios_RunWorkerCompleted);
            // 
            // btnUsuariosEliminados
            // 
            this.btnUsuariosEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuariosEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnUsuariosEliminados.FlatAppearance.BorderSize = 0;
            this.btnUsuariosEliminados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnUsuariosEliminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnUsuariosEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosEliminados.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnUsuariosEliminados.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosEliminados.Location = new System.Drawing.Point(12, 365);
            this.btnUsuariosEliminados.Name = "btnUsuariosEliminados";
            this.btnUsuariosEliminados.Size = new System.Drawing.Size(175, 46);
            this.btnUsuariosEliminados.TabIndex = 4;
            this.btnUsuariosEliminados.Text = "Ver usuarios eliminados";
            this.btnUsuariosEliminados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuariosEliminados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuariosEliminados.UseVisualStyleBackColor = false;
            this.btnUsuariosEliminados.Click += new System.EventHandler(this.btnUsuariosEliminados_Click);
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            this.tmrEspera.Tick += new System.EventHandler(this.tmrEspera_Tick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 423);
            this.Controls.Add(this.btnUsuariosEliminados);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.ComponentModel.BackgroundWorker bgwUsuarios;
        private System.Windows.Forms.Button btnUsuariosEliminados;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNivelC;
    }
}