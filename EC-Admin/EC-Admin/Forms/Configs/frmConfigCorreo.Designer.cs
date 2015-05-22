namespace EC_Admin.Forms.Configs
{
    partial class frmConfigCorreo
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
            this.lblEPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEHost = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblEPuerto = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblECorreo = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEPass
            // 
            this.lblEPass.AutoSize = true;
            this.lblEPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPass.Location = new System.Drawing.Point(298, 9);
            this.lblEPass.Name = "lblEPass";
            this.lblEPass.Size = new System.Drawing.Size(97, 22);
            this.lblEPass.TabIndex = 2;
            this.lblEPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPass.Location = new System.Drawing.Point(302, 35);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(282, 29);
            this.txtPass.TabIndex = 3;
            // 
            // lblEHost
            // 
            this.lblEHost.AutoSize = true;
            this.lblEHost.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEHost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEHost.Location = new System.Drawing.Point(9, 73);
            this.lblEHost.Name = "lblEHost";
            this.lblEHost.Size = new System.Drawing.Size(45, 22);
            this.lblEHost.TabIndex = 4;
            this.lblEHost.Text = "Host";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.Location = new System.Drawing.Point(13, 35);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(281, 29);
            this.txtCorreo.TabIndex = 1;
            // 
            // lblEPuerto
            // 
            this.lblEPuerto.AutoSize = true;
            this.lblEPuerto.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEPuerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPuerto.Location = new System.Drawing.Point(298, 73);
            this.lblEPuerto.Name = "lblEPuerto";
            this.lblEPuerto.Size = new System.Drawing.Size(60, 22);
            this.lblEPuerto.TabIndex = 6;
            this.lblEPuerto.Text = "Puerto";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPuerto.Location = new System.Drawing.Point(302, 99);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(282, 29);
            this.txtPuerto.TabIndex = 7;
            this.txtPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuerto_KeyPress);
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(9, 9);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(62, 22);
            this.lblECorreo.TabIndex = 0;
            this.lblECorreo.Text = "Correo";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtHost.Location = new System.Drawing.Point(13, 99);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(281, 29);
            this.txtHost.TabIndex = 5;
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
            this.btnAceptar.Location = new System.Drawing.Point(435, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(10, 170);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(274, 54);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Cierta información que es necesario agregar\r\naquí es muy sensible, así que si no " +
    "entiendes\r\na lo que se refiere, es mejor dejarlo así.";
            // 
            // frmConfigCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 233);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblEHost);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblEPuerto);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblECorreo);
            this.Controls.Add(this.txtHost);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEHost;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEPuerto;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblECorreo;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblInfo;
    }
}