namespace EC_Admin.Forms
{
    partial class frmReestablecer
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
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEPass = new System.Windows.Forms.Label();
            this.lblERepPass = new System.Windows.Forms.Label();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnReestablecer.FlatAppearance.BorderSize = 0;
            this.btnReestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnReestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReestablecer.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnReestablecer.ForeColor = System.Drawing.Color.White;
            this.btnReestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReestablecer.Location = new System.Drawing.Point(390, 191);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(150, 46);
            this.btnReestablecer.TabIndex = 4;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReestablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Corbel", 15F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPass.Location = new System.Drawing.Point(114, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(325, 32);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEPass
            // 
            this.lblEPass.AutoSize = true;
            this.lblEPass.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPass.Location = new System.Drawing.Point(196, 23);
            this.lblEPass.Name = "lblEPass";
            this.lblEPass.Size = new System.Drawing.Size(161, 24);
            this.lblEPass.TabIndex = 0;
            this.lblEPass.Text = "Nueva contraseña";
            // 
            // lblERepPass
            // 
            this.lblERepPass.AutoSize = true;
            this.lblERepPass.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblERepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERepPass.Location = new System.Drawing.Point(191, 90);
            this.lblERepPass.Name = "lblERepPass";
            this.lblERepPass.Size = new System.Drawing.Size(170, 24);
            this.lblERepPass.TabIndex = 2;
            this.lblERepPass.Text = "Repetir contraseña";
            // 
            // txtRepPass
            // 
            this.txtRepPass.BackColor = System.Drawing.Color.White;
            this.txtRepPass.Font = new System.Drawing.Font("Corbel", 15F);
            this.txtRepPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRepPass.Location = new System.Drawing.Point(114, 117);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.PasswordChar = '•';
            this.txtRepPass.Size = new System.Drawing.Size(325, 32);
            this.txtRepPass.TabIndex = 3;
            this.txtRepPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmReestablecer
            // 
            this.AcceptButton = this.btnReestablecer;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 249);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblEPass);
            this.Controls.Add(this.lblERepPass);
            this.Controls.Add(this.txtRepPass);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReestablecer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmReestablecer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEPass;
        private System.Windows.Forms.Label lblERepPass;
        private System.Windows.Forms.TextBox txtRepPass;
    }
}