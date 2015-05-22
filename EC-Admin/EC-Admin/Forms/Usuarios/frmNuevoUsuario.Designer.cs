namespace EC_Admin.Forms
{
    partial class frmNuevoUsuario
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblRepPass = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.lblInfoImagen = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboCamaras = new System.Windows.Forms.ComboBox();
            this.btnCamara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblUsuario.Location = new System.Drawing.Point(9, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtUsuario.Location = new System.Drawing.Point(12, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(259, 29);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // cboNivel
            // 
            this.cboNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNivel.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(277, 30);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(259, 29);
            this.cboNivel.TabIndex = 3;
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.cboNivel_SelectedIndexChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblNivel.Location = new System.Drawing.Point(274, 9);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 18);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPass.Location = new System.Drawing.Point(12, 88);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(259, 29);
            this.txtPass.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblPass.Location = new System.Drawing.Point(9, 67);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 18);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseña";
            // 
            // txtRepPass
            // 
            this.txtRepPass.BackColor = System.Drawing.Color.White;
            this.txtRepPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRepPass.Location = new System.Drawing.Point(277, 88);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.PasswordChar = '•';
            this.txtRepPass.Size = new System.Drawing.Size(259, 29);
            this.txtRepPass.TabIndex = 7;
            // 
            // lblRepPass
            // 
            this.lblRepPass.AutoSize = true;
            this.lblRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblRepPass.Location = new System.Drawing.Point(274, 67);
            this.lblRepPass.Name = "lblRepPass";
            this.lblRepPass.Size = new System.Drawing.Size(123, 18);
            this.lblRepPass.TabIndex = 6;
            this.lblRepPass.Text = "Repetir contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblNombre.Location = new System.Drawing.Point(9, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 18);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtApellidos.Location = new System.Drawing.Point(277, 146);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 29);
            this.txtApellidos.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblApellidos.Location = new System.Drawing.Point(274, 125);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 18);
            this.lblApellidos.TabIndex = 10;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(277, 204);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 13;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCorreo.Location = new System.Drawing.Point(274, 183);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(121, 18);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pcbImagen.Location = new System.Drawing.Point(12, 233);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(156, 156);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImagen.TabIndex = 14;
            this.pcbImagen.TabStop = false;
            this.pcbImagen.Click += new System.EventHandler(this.pcbImagen_Click);
            // 
            // lblInfoImagen
            // 
            this.lblInfoImagen.AutoSize = true;
            this.lblInfoImagen.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfoImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfoImagen.Location = new System.Drawing.Point(9, 392);
            this.lblInfoImagen.Name = "lblInfoImagen";
            this.lblInfoImagen.Size = new System.Drawing.Size(141, 14);
            this.lblInfoImagen.TabIndex = 15;
            this.lblInfoImagen.Text = "Clic para cambiar la imagen";
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 392);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblInfo.Location = new System.Drawing.Point(223, 236);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(313, 14);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "El nombre de usuario ingresado ya existe. Ingrese otro por favor";
            this.lblInfo.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(174, 323);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(97, 30);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar imagen";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Asignar huella";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // cboCamaras
            // 
            this.cboCamaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamaras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamaras.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboCamaras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboCamaras.FormattingEnabled = true;
            this.cboCamaras.Location = new System.Drawing.Point(12, 409);
            this.cboCamaras.Name = "cboCamaras";
            this.cboCamaras.Size = new System.Drawing.Size(259, 29);
            this.cboCamaras.TabIndex = 34;
            // 
            // btnCamara
            // 
            this.btnCamara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCamara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnCamara.ForeColor = System.Drawing.Color.White;
            this.btnCamara.Location = new System.Drawing.Point(174, 359);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(97, 30);
            this.btnCamara.TabIndex = 33;
            this.btnCamara.Text = "Tomar foto";
            this.btnCamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.cboCamaras);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblInfoImagen);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.lblRepPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNuevoUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creación de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNuevoUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmNuevoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblRepPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lblInfoImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboCamaras;
        private System.Windows.Forms.Button btnCamara;
    }
}