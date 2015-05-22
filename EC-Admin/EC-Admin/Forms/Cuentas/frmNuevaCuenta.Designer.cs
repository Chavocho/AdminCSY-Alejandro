namespace EC_Admin.Forms
{
    partial class frmNuevaCuenta
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
            this.lblEClabe = new System.Windows.Forms.Label();
            this.txtClabe = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblEBanco = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.lblEBeneficiario = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.lblENumCuenta = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEClabe
            // 
            this.lblEClabe.AutoSize = true;
            this.lblEClabe.Location = new System.Drawing.Point(9, 9);
            this.lblEClabe.Name = "lblEClabe";
            this.lblEClabe.Size = new System.Drawing.Size(42, 18);
            this.lblEClabe.TabIndex = 0;
            this.lblEClabe.Text = "Clabe";
            // 
            // txtClabe
            // 
            this.txtClabe.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtClabe.Location = new System.Drawing.Point(12, 30);
            this.txtClabe.Name = "txtClabe";
            this.txtClabe.Size = new System.Drawing.Size(259, 29);
            this.txtClabe.TabIndex = 1;
            this.txtClabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBanco.Location = new System.Drawing.Point(277, 30);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(259, 29);
            this.txtBanco.TabIndex = 3;
            // 
            // lblEBanco
            // 
            this.lblEBanco.AutoSize = true;
            this.lblEBanco.Location = new System.Drawing.Point(274, 9);
            this.lblEBanco.Name = "lblEBanco";
            this.lblEBanco.Size = new System.Drawing.Size(47, 18);
            this.lblEBanco.TabIndex = 2;
            this.lblEBanco.Text = "Banco";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtSucursal.Location = new System.Drawing.Point(277, 88);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(259, 29);
            this.txtSucursal.TabIndex = 7;
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.Location = new System.Drawing.Point(274, 67);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 6;
            this.lblESucursal.Text = "Sucursal";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBeneficiario.Location = new System.Drawing.Point(12, 88);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(259, 29);
            this.txtBeneficiario.TabIndex = 5;
            // 
            // lblEBeneficiario
            // 
            this.lblEBeneficiario.AutoSize = true;
            this.lblEBeneficiario.Location = new System.Drawing.Point(9, 67);
            this.lblEBeneficiario.Name = "lblEBeneficiario";
            this.lblEBeneficiario.Size = new System.Drawing.Size(80, 18);
            this.lblEBeneficiario.TabIndex = 4;
            this.lblEBeneficiario.Text = "Beneficiario";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumCuenta.Location = new System.Drawing.Point(12, 146);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(259, 29);
            this.txtNumCuenta.TabIndex = 9;
            this.txtNumCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblENumCuenta
            // 
            this.lblENumCuenta.AutoSize = true;
            this.lblENumCuenta.Location = new System.Drawing.Point(9, 125);
            this.lblENumCuenta.Name = "lblENumCuenta";
            this.lblENumCuenta.Size = new System.Drawing.Size(121, 18);
            this.lblENumCuenta.TabIndex = 8;
            this.lblENumCuenta.Text = "Número de cuenta";
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmNuevaCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 265);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblENumCuenta);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.lblESucursal);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.lblEBeneficiario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblEBanco);
            this.Controls.Add(this.txtClabe);
            this.Controls.Add(this.lblEClabe);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cuenta bancaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEClabe;
        private System.Windows.Forms.TextBox txtClabe;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblEBanco;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.Label lblEBeneficiario;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label lblENumCuenta;
        private System.Windows.Forms.Button btnAceptar;
    }
}