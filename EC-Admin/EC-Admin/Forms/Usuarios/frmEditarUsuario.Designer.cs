namespace EC_Admin.Forms
{
    partial class frmEditarUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblRepPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.lblEUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtAntiPass = new System.Windows.Forms.TextBox();
            this.lblAntiPass = new System.Windows.Forms.Label();
            this.chbPass = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboCamaras = new System.Windows.Forms.ComboBox();
            this.btnCamara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.pnlPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Asignar huella";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(174, 281);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = "Quitar imagen";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen.Location = new System.Drawing.Point(12, 191);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 34;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(280, 146);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCorreo.Location = new System.Drawing.Point(277, 125);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(121, 18);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtApellidos.Location = new System.Drawing.Point(280, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 29);
            this.txtApellidos.TabIndex = 7;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblApellidos.Location = new System.Drawing.Point(277, 67);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 18);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(15, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtRepPass
            // 
            this.txtRepPass.BackColor = System.Drawing.Color.White;
            this.txtRepPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRepPass.Location = new System.Drawing.Point(280, 74);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.PasswordChar = '•';
            this.txtRepPass.Size = new System.Drawing.Size(259, 29);
            this.txtRepPass.TabIndex = 5;
            // 
            // lblRepPass
            // 
            this.lblRepPass.AutoSize = true;
            this.lblRepPass.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblRepPass.Location = new System.Drawing.Point(277, 53);
            this.lblRepPass.Name = "lblRepPass";
            this.lblRepPass.Size = new System.Drawing.Size(123, 18);
            this.lblRepPass.TabIndex = 4;
            this.lblRepPass.Text = "Repetir contraseña";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPass.Location = new System.Drawing.Point(15, 74);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(259, 29);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblPass.Location = new System.Drawing.Point(12, 53);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(118, 18);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Nueva contraseña";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblNivel.Location = new System.Drawing.Point(277, 9);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 18);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel";
            // 
            // cboNivel
            // 
            this.cboNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNivel.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(280, 30);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(259, 29);
            this.cboNivel.TabIndex = 3;
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.cboNivel_SelectedIndexChanged);
            // 
            // lblEUsuario
            // 
            this.lblEUsuario.AutoSize = true;
            this.lblEUsuario.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEUsuario.Location = new System.Drawing.Point(9, 9);
            this.lblEUsuario.Name = "lblEUsuario";
            this.lblEUsuario.Size = new System.Drawing.Size(55, 18);
            this.lblEUsuario.TabIndex = 0;
            this.lblEUsuario.Text = "Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblUsuario.Location = new System.Drawing.Point(8, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Administrador";
            // 
            // pnlPass
            // 
            this.pnlPass.Controls.Add(this.txtAntiPass);
            this.pnlPass.Controls.Add(this.lblAntiPass);
            this.pnlPass.Controls.Add(this.txtPass);
            this.pnlPass.Controls.Add(this.lblPass);
            this.pnlPass.Controls.Add(this.lblRepPass);
            this.pnlPass.Controls.Add(this.txtRepPass);
            this.pnlPass.Location = new System.Drawing.Point(0, 181);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(548, 112);
            this.pnlPass.TabIndex = 11;
            this.pnlPass.Visible = false;
            // 
            // txtAntiPass
            // 
            this.txtAntiPass.BackColor = System.Drawing.Color.White;
            this.txtAntiPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtAntiPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtAntiPass.Location = new System.Drawing.Point(15, 21);
            this.txtAntiPass.Name = "txtAntiPass";
            this.txtAntiPass.PasswordChar = '•';
            this.txtAntiPass.Size = new System.Drawing.Size(259, 29);
            this.txtAntiPass.TabIndex = 1;
            // 
            // lblAntiPass
            // 
            this.lblAntiPass.AutoSize = true;
            this.lblAntiPass.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblAntiPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblAntiPass.Location = new System.Drawing.Point(12, 0);
            this.lblAntiPass.Name = "lblAntiPass";
            this.lblAntiPass.Size = new System.Drawing.Size(128, 18);
            this.lblAntiPass.TabIndex = 0;
            this.lblAntiPass.Text = "Antigua contraseña";
            // 
            // chbPass
            // 
            this.chbPass.AutoSize = true;
            this.chbPass.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbPass.Location = new System.Drawing.Point(12, 153);
            this.chbPass.Name = "chbPass";
            this.chbPass.Size = new System.Drawing.Size(156, 22);
            this.chbPass.TabIndex = 10;
            this.chbPass.Text = "Modificar contraseña";
            this.chbPass.UseVisualStyleBackColor = true;
            this.chbPass.CheckedChanged += new System.EventHandler(this.chbPass_CheckedChanged);
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboCamaras
            // 
            this.cboCamaras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCamaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamaras.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboCamaras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboCamaras.FormattingEnabled = true;
            this.cboCamaras.Location = new System.Drawing.Point(12, 353);
            this.cboCamaras.Name = "cboCamaras";
            this.cboCamaras.Size = new System.Drawing.Size(259, 29);
            this.cboCamaras.TabIndex = 36;
            // 
            // btnCamara
            // 
            this.btnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCamara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnCamara.ForeColor = System.Drawing.Color.White;
            this.btnCamara.Location = new System.Drawing.Point(174, 317);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(97, 30);
            this.btnCamara.TabIndex = 35;
            this.btnCamara.Text = "Tomar foto";
            this.btnCamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 394);
            this.Controls.Add(this.cboCamaras);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chbPass);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.lblEUsuario);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditarUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblRepPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label lblEUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.CheckBox chbPass;
        private System.Windows.Forms.TextBox txtAntiPass;
        private System.Windows.Forms.Label lblAntiPass;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboCamaras;
        private System.Windows.Forms.Button btnCamara;
    }
}