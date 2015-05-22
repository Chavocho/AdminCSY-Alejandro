namespace EC_Admin.Forms
{
    partial class frmDatosPuesto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblEDepartamento = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(9, 9);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 0;
            this.lblENombre.Text = "Nombre";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.White;
            this.txtDepartamento.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDepartamento.Location = new System.Drawing.Point(277, 30);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(259, 29);
            this.txtDepartamento.TabIndex = 3;
            // 
            // lblEDepartamento
            // 
            this.lblEDepartamento.AutoSize = true;
            this.lblEDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDepartamento.Location = new System.Drawing.Point(274, 9);
            this.lblEDepartamento.Name = "lblEDepartamento";
            this.lblEDepartamento.Size = new System.Drawing.Size(97, 18);
            this.lblEDepartamento.TabIndex = 2;
            this.lblEDepartamento.Text = "Departamento";
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 79);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmDatosPuesto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 137);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lblEDepartamento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblENombre);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDatosPuesto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar puesto";
            this.Load += new System.EventHandler(this.frmDatosPuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblEDepartamento;
        private System.Windows.Forms.Button btnAceptar;
    }
}