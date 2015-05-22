namespace EC_Admin
{
    partial class frmLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEUsuario = new System.Windows.Forms.Label();
            this.lblEPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.llbReestablecer = new System.Windows.Forms.LinkLabel();
            this.btnPruebas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtUsuario.Location = new System.Drawing.Point(97, 37);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(351, 29);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEUsuario
            // 
            this.lblEUsuario.AutoSize = true;
            this.lblEUsuario.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEUsuario.Location = new System.Drawing.Point(239, 11);
            this.lblEUsuario.Name = "lblEUsuario";
            this.lblEUsuario.Size = new System.Drawing.Size(67, 22);
            this.lblEUsuario.TabIndex = 1;
            this.lblEUsuario.Text = "Usuario";
            // 
            // lblEPass
            // 
            this.lblEPass.AutoSize = true;
            this.lblEPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPass.Location = new System.Drawing.Point(224, 82);
            this.lblEPass.Name = "lblEPass";
            this.lblEPass.Size = new System.Drawing.Size(97, 22);
            this.lblEPass.TabIndex = 3;
            this.lblEPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPass.Location = new System.Drawing.Point(97, 108);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(351, 29);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnAceptar.Location = new System.Drawing.Point(382, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(12, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // llbReestablecer
            // 
            this.llbReestablecer.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.llbReestablecer.AutoSize = true;
            this.llbReestablecer.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.llbReestablecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.llbReestablecer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.llbReestablecer.Location = new System.Drawing.Point(272, 141);
            this.llbReestablecer.Name = "llbReestablecer";
            this.llbReestablecer.Size = new System.Drawing.Size(176, 18);
            this.llbReestablecer.TabIndex = 54;
            this.llbReestablecer.TabStop = true;
            this.llbReestablecer.Text = "¿Olvidaste tu contraseña?";
            this.llbReestablecer.Visible = false;
            this.llbReestablecer.VisitedLinkColor = System.Drawing.Color.DarkViolet;
            this.llbReestablecer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbReestablecer_LinkClicked);
            // 
            // btnPruebas
            // 
            this.btnPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPruebas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPruebas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPruebas.FlatAppearance.BorderSize = 0;
            this.btnPruebas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnPruebas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPruebas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPruebas.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnPruebas.ForeColor = System.Drawing.Color.White;
            this.btnPruebas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPruebas.Location = new System.Drawing.Point(12, 146);
            this.btnPruebas.Name = "btnPruebas";
            this.btnPruebas.Size = new System.Drawing.Size(150, 46);
            this.btnPruebas.TabIndex = 55;
            this.btnPruebas.Text = "Pruebas";
            this.btnPruebas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPruebas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPruebas.UseVisualStyleBackColor = false;
            this.btnPruebas.Visible = false;
            this.btnPruebas.Click += new System.EventHandler(this.btnPruebas_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(544, 256);
            this.Controls.Add(this.btnPruebas);
            this.Controls.Add(this.llbReestablecer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblEUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEUsuario;
        private System.Windows.Forms.Label lblEPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel llbReestablecer;
        private System.Windows.Forms.Button btnPruebas;
    }
}