namespace EC_Admin.Forms
{
    partial class frmConfigBaseDatos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEServer = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblEPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEUsuario = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btnAceptar.Location = new System.Drawing.Point(434, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 46);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEServer
            // 
            this.lblEServer.AutoSize = true;
            this.lblEServer.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEServer.Location = new System.Drawing.Point(9, 9);
            this.lblEServer.Name = "lblEServer";
            this.lblEServer.Size = new System.Drawing.Size(73, 22);
            this.lblEServer.TabIndex = 0;
            this.lblEServer.Text = "Servidor";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtUsuario.Location = new System.Drawing.Point(13, 99);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(281, 29);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblEBase
            // 
            this.lblEBase.AutoSize = true;
            this.lblEBase.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEBase.Location = new System.Drawing.Point(298, 9);
            this.lblEBase.Name = "lblEBase";
            this.lblEBase.Size = new System.Drawing.Size(115, 22);
            this.lblEBase.TabIndex = 2;
            this.lblEBase.Text = "Base de datos";
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBase.Location = new System.Drawing.Point(302, 35);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(281, 29);
            this.txtBase.TabIndex = 3;
            // 
            // lblEPass
            // 
            this.lblEPass.AutoSize = true;
            this.lblEPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPass.Location = new System.Drawing.Point(298, 73);
            this.lblEPass.Name = "lblEPass";
            this.lblEPass.Size = new System.Drawing.Size(97, 22);
            this.lblEPass.TabIndex = 6;
            this.lblEPass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPass.Location = new System.Drawing.Point(302, 99);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(281, 29);
            this.txtPass.TabIndex = 7;
            // 
            // lblEUsuario
            // 
            this.lblEUsuario.AutoSize = true;
            this.lblEUsuario.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEUsuario.Location = new System.Drawing.Point(9, 73);
            this.lblEUsuario.Name = "lblEUsuario";
            this.lblEUsuario.Size = new System.Drawing.Size(67, 22);
            this.lblEUsuario.TabIndex = 4;
            this.lblEUsuario.Text = "Usuario";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtServer.Location = new System.Drawing.Point(13, 35);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(281, 29);
            this.txtServer.TabIndex = 1;
            // 
            // frmConfigBaseDatos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 233);
            this.Controls.Add(this.lblEPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblEUsuario);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblEBase);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblEServer);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConfigBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de conexión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfigBaseDatos_FormClosed);
            this.Load += new System.EventHandler(this.frmConfigBaseDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEServer;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblEPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEUsuario;
        private System.Windows.Forms.TextBox txtServer;
    }
}