namespace EC_Admin.Forms
{
    partial class frmVerificarUsuario
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
            this.lblECodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblECodigo
            // 
            this.lblECodigo.AutoSize = true;
            this.lblECodigo.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblECodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECodigo.Location = new System.Drawing.Point(119, 47);
            this.lblECodigo.Name = "lblECodigo";
            this.lblECodigo.Size = new System.Drawing.Size(318, 24);
            this.lblECodigo.TabIndex = 0;
            this.lblECodigo.Text = "Ingresa el código enviado a tu correo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Corbel", 15F);
            this.txtCodigo.Location = new System.Drawing.Point(116, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(321, 32);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnContinuar.ForeColor = System.Drawing.Color.White;
            this.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuar.Location = new System.Drawing.Point(390, 191);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(150, 46);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmVerificarUsuario
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 249);
            this.Controls.Add(this.lblECodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnContinuar);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmVerificarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblECodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnContinuar;
    }
}