namespace EC_Admin.Forms
{
    partial class frmNuevaCategoria
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 150);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDescripcion.Location = new System.Drawing.Point(277, 30);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(259, 100);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblEDescripcion
            // 
            this.lblEDescripcion.AutoSize = true;
            this.lblEDescripcion.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDescripcion.Location = new System.Drawing.Point(274, 9);
            this.lblEDescripcion.Name = "lblEDescripcion";
            this.lblEDescripcion.Size = new System.Drawing.Size(80, 18);
            this.lblEDescripcion.TabIndex = 2;
            this.lblEDescripcion.Text = "Descripción";
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
            this.lblENombre.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(9, 9);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 0;
            this.lblENombre.Text = "Nombre";
            // 
            // frmNuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 208);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblEDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblENombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;
    }
}