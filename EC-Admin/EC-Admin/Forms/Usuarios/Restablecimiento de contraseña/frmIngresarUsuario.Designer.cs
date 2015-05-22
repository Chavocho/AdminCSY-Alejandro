namespace EC_Admin.Forms
{
    partial class frmIngresarUsuario
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
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEUsuario = new System.Windows.Forms.Label();
            this.btnVerificarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCodigoCorreo = new System.Windows.Forms.Button();
            this.bgwVerificar = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblCorreo.Location = new System.Drawing.Point(165, 159);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(223, 22);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "alguien@correoprueba.com";
            this.lblCorreo.Visible = false;
            // 
            // lblEUsuario
            // 
            this.lblEUsuario.AutoSize = true;
            this.lblEUsuario.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEUsuario.Location = new System.Drawing.Point(239, 27);
            this.lblEUsuario.Name = "lblEUsuario";
            this.lblEUsuario.Size = new System.Drawing.Size(74, 24);
            this.lblEUsuario.TabIndex = 0;
            this.lblEUsuario.Text = "Usuario";
            // 
            // btnVerificarUsuario
            // 
            this.btnVerificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnVerificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnVerificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnVerificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnVerificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarUsuario.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnVerificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnVerificarUsuario.Location = new System.Drawing.Point(228, 92);
            this.btnVerificarUsuario.Name = "btnVerificarUsuario";
            this.btnVerificarUsuario.Size = new System.Drawing.Size(97, 43);
            this.btnVerificarUsuario.TabIndex = 2;
            this.btnVerificarUsuario.Text = "Verificar usuario";
            this.btnVerificarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerificarUsuario.UseVisualStyleBackColor = false;
            this.btnVerificarUsuario.Click += new System.EventHandler(this.btnVerificarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Corbel", 15F);
            this.txtUsuario.Location = new System.Drawing.Point(123, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(306, 32);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // btnCodigoCorreo
            // 
            this.btnCodigoCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCodigoCorreo.FlatAppearance.BorderSize = 0;
            this.btnCodigoCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCodigoCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCodigoCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigoCorreo.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnCodigoCorreo.ForeColor = System.Drawing.Color.White;
            this.btnCodigoCorreo.Location = new System.Drawing.Point(228, 189);
            this.btnCodigoCorreo.Name = "btnCodigoCorreo";
            this.btnCodigoCorreo.Size = new System.Drawing.Size(97, 43);
            this.btnCodigoCorreo.TabIndex = 4;
            this.btnCodigoCorreo.Text = "Enviar código por correo";
            this.btnCodigoCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCodigoCorreo.UseVisualStyleBackColor = false;
            this.btnCodigoCorreo.Visible = false;
            this.btnCodigoCorreo.Click += new System.EventHandler(this.btnCodigoCorreo_Click);
            // 
            // bgwVerificar
            // 
            this.bgwVerificar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwVerificar_DoWork);
            this.bgwVerificar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwVerificar_RunWorkerCompleted);
            // 
            // frmIngresarUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 249);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblEUsuario);
            this.Controls.Add(this.btnVerificarUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCodigoCorreo);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmIngresarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEUsuario;
        private System.Windows.Forms.Button btnVerificarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCodigoCorreo;
        private System.ComponentModel.BackgroundWorker bgwVerificar;
    }
}