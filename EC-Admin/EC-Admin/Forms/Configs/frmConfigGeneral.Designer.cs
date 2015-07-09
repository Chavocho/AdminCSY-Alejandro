namespace EC_Admin.Forms
{
    partial class frmConfigGeneral
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
            this.grbPOS = new System.Windows.Forms.GroupBox();
            this.lblEIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblECantMayoreo = new System.Windows.Forms.Label();
            this.txtCantMayoreo = new System.Windows.Forms.TextBox();
            this.lblECantMedioMayoreo = new System.Windows.Forms.Label();
            this.txtCantMedioMayoreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEInformacion = new System.Windows.Forms.Label();
            this.grbPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPOS
            // 
            this.grbPOS.Controls.Add(this.lblEInformacion);
            this.grbPOS.Controls.Add(this.lblEIVA);
            this.grbPOS.Controls.Add(this.txtIVA);
            this.grbPOS.Controls.Add(this.lblECantMayoreo);
            this.grbPOS.Controls.Add(this.txtCantMayoreo);
            this.grbPOS.Controls.Add(this.lblECantMedioMayoreo);
            this.grbPOS.Controls.Add(this.txtCantMedioMayoreo);
            this.grbPOS.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbPOS.Location = new System.Drawing.Point(12, 12);
            this.grbPOS.Name = "grbPOS";
            this.grbPOS.Size = new System.Drawing.Size(505, 116);
            this.grbPOS.TabIndex = 1;
            this.grbPOS.TabStop = false;
            this.grbPOS.Text = "Punto de venta";
            // 
            // lblEIVA
            // 
            this.lblEIVA.AutoSize = true;
            this.lblEIVA.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEIVA.Location = new System.Drawing.Point(394, 56);
            this.lblEIVA.Name = "lblEIVA";
            this.lblEIVA.Size = new System.Drawing.Size(97, 18);
            this.lblEIVA.TabIndex = 6;
            this.lblEIVA.Text = "Valor del I.V.A.";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtIVA.Location = new System.Drawing.Point(394, 81);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(105, 29);
            this.txtIVA.TabIndex = 5;
            this.txtIVA.Text = "0";
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosDecimal_KeyPress);
            // 
            // lblECantMayoreo
            // 
            this.lblECantMayoreo.AutoSize = true;
            this.lblECantMayoreo.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantMayoreo.Location = new System.Drawing.Point(200, 56);
            this.lblECantMayoreo.Name = "lblECantMayoreo";
            this.lblECantMayoreo.Size = new System.Drawing.Size(138, 18);
            this.lblECantMayoreo.TabIndex = 4;
            this.lblECantMayoreo.Text = "Cantidad de mayoreo";
            // 
            // txtCantMayoreo
            // 
            this.txtCantMayoreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCantMayoreo.Location = new System.Drawing.Point(200, 81);
            this.txtCantMayoreo.Name = "txtCantMayoreo";
            this.txtCantMayoreo.Size = new System.Drawing.Size(188, 29);
            this.txtCantMayoreo.TabIndex = 3;
            this.txtCantMayoreo.Text = "0";
            this.txtCantMayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblECantMedioMayoreo
            // 
            this.lblECantMedioMayoreo.AutoSize = true;
            this.lblECantMedioMayoreo.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblECantMedioMayoreo.Location = new System.Drawing.Point(6, 56);
            this.lblECantMedioMayoreo.Name = "lblECantMedioMayoreo";
            this.lblECantMedioMayoreo.Size = new System.Drawing.Size(179, 18);
            this.lblECantMedioMayoreo.TabIndex = 2;
            this.lblECantMedioMayoreo.Text = "Cantidad de medio mayoreo";
            // 
            // txtCantMedioMayoreo
            // 
            this.txtCantMedioMayoreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCantMedioMayoreo.Location = new System.Drawing.Point(6, 81);
            this.txtCantMedioMayoreo.Name = "txtCantMedioMayoreo";
            this.txtCantMedioMayoreo.Size = new System.Drawing.Size(188, 29);
            this.txtCantMedioMayoreo.TabIndex = 1;
            this.txtCantMedioMayoreo.Text = "0";
            this.txtCantMedioMayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
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
            this.btnAceptar.Location = new System.Drawing.Point(368, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEInformacion
            // 
            this.lblEInformacion.AutoSize = true;
            this.lblEInformacion.Font = new System.Drawing.Font("Corbel", 9F);
            this.lblEInformacion.Location = new System.Drawing.Point(6, 18);
            this.lblEInformacion.Name = "lblEInformacion";
            this.lblEInformacion.Size = new System.Drawing.Size(279, 28);
            this.lblEInformacion.TabIndex = 7;
            this.lblEInformacion.Text = "*Ingrese las cantidades para que se asignen los precios \r\nde medio mayoreo y mayo" +
    "reo a la venta según se asigne";
            // 
            // frmConfigGeneral
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbPOS);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfigGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración general";
            this.Load += new System.EventHandler(this.frmConfigGeneral_Load);
            this.grbPOS.ResumeLayout(false);
            this.grbPOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPOS;
        private System.Windows.Forms.Label lblECantMedioMayoreo;
        private System.Windows.Forms.TextBox txtCantMedioMayoreo;
        private System.Windows.Forms.Label lblECantMayoreo;
        private System.Windows.Forms.TextBox txtCantMayoreo;
        private System.Windows.Forms.Label lblEIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEInformacion;
    }
}