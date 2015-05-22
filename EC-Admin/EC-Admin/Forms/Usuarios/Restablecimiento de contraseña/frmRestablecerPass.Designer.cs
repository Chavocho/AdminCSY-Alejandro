namespace EC_Admin.Forms
{
    partial class frmReestablecerPass
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
            this.lblEVerificarUsuario = new System.Windows.Forms.Label();
            this.lblEIngresarCódigo = new System.Windows.Forms.Label();
            this.lblEReestablecer = new System.Windows.Forms.Label();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEVerificarUsuario
            // 
            this.lblEVerificarUsuario.AutoSize = true;
            this.lblEVerificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEVerificarUsuario.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEVerificarUsuario.ForeColor = System.Drawing.Color.White;
            this.lblEVerificarUsuario.Location = new System.Drawing.Point(0, 9);
            this.lblEVerificarUsuario.Name = "lblEVerificarUsuario";
            this.lblEVerificarUsuario.Size = new System.Drawing.Size(133, 22);
            this.lblEVerificarUsuario.TabIndex = 0;
            this.lblEVerificarUsuario.Text = "Verificar usuario";
            // 
            // lblEIngresarCódigo
            // 
            this.lblEIngresarCódigo.AutoSize = true;
            this.lblEIngresarCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblEIngresarCódigo.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEIngresarCódigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEIngresarCódigo.Location = new System.Drawing.Point(133, 9);
            this.lblEIngresarCódigo.Name = "lblEIngresarCódigo";
            this.lblEIngresarCódigo.Size = new System.Drawing.Size(129, 22);
            this.lblEIngresarCódigo.TabIndex = 1;
            this.lblEIngresarCódigo.Text = "Ingresar código";
            // 
            // lblEReestablecer
            // 
            this.lblEReestablecer.AutoSize = true;
            this.lblEReestablecer.BackColor = System.Drawing.Color.Transparent;
            this.lblEReestablecer.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEReestablecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEReestablecer.Location = new System.Drawing.Point(262, 9);
            this.lblEReestablecer.Name = "lblEReestablecer";
            this.lblEReestablecer.Size = new System.Drawing.Size(200, 22);
            this.lblEReestablecer.TabIndex = 2;
            this.lblEReestablecer.Text = "Reestablecer contraseña";
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormularios.Location = new System.Drawing.Point(0, 34);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(552, 249);
            this.pnlFormularios.TabIndex = 3;
            // 
            // frmReestablecerPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 283);
            this.Controls.Add(this.pnlFormularios);
            this.Controls.Add(this.lblEReestablecer);
            this.Controls.Add(this.lblEIngresarCódigo);
            this.Controls.Add(this.lblEVerificarUsuario);
            this.Font = new System.Drawing.Font("Corbel", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmReestablecerPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reestablecimiento de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEVerificarUsuario;
        private System.Windows.Forms.Label lblEIngresarCódigo;
        private System.Windows.Forms.Label lblEReestablecer;
        private System.Windows.Forms.Panel pnlFormularios;


    }
}