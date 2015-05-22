namespace EC_Admin.Forms
{
    partial class frmEntradaSalida
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblEEfectivo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMonto.Location = new System.Drawing.Point(12, 34);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(204, 29);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblEEfectivo
            // 
            this.lblEEfectivo.AutoSize = true;
            this.lblEEfectivo.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEEfectivo.Location = new System.Drawing.Point(8, 9);
            this.lblEEfectivo.Name = "lblEEfectivo";
            this.lblEEfectivo.Size = new System.Drawing.Size(139, 22);
            this.lblEEfectivo.TabIndex = 2;
            this.lblEEfectivo.Text = "Monto a ingresar";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDescripcion.Location = new System.Drawing.Point(222, 34);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(294, 114);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblEDescripcion
            // 
            this.lblEDescripcion.AutoSize = true;
            this.lblEDescripcion.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEDescripcion.Location = new System.Drawing.Point(218, 9);
            this.lblEDescripcion.Name = "lblEDescripcion";
            this.lblEDescripcion.Size = new System.Drawing.Size(98, 22);
            this.lblEDescripcion.TabIndex = 4;
            this.lblEDescripcion.Text = "Descripción";
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
            this.btnAceptar.Location = new System.Drawing.Point(366, 174);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmEntradaSalida
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 232);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblEEfectivo);
            this.Controls.Add(this.txtMonto);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEntradaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblEEfectivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEDescripcion;
        private System.Windows.Forms.Button btnAceptar;
    }
}