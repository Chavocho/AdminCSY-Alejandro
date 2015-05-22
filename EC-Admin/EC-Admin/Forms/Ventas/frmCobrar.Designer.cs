namespace EC_Admin.Forms
{
    partial class frmCobrar
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
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblEEfectivo = new System.Windows.Forms.Label();
            this.btnCredito = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblECambio = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.lblETipoPago = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblEDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.Location = new System.Drawing.Point(220, 238);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(150, 46);
            this.btnCobrar.TabIndex = 7;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTotal.Location = new System.Drawing.Point(93, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 24);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblETotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETotal.Location = new System.Drawing.Point(33, 57);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(58, 24);
            this.lblETotal.TabIndex = 0;
            this.lblETotal.Text = "Total:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEfectivo.Location = new System.Drawing.Point(97, 89);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(77, 29);
            this.txtEfectivo.TabIndex = 3;
            this.txtEfectivo.Text = "0.00";
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // lblEEfectivo
            // 
            this.lblEEfectivo.AutoSize = true;
            this.lblEEfectivo.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEfectivo.Location = new System.Drawing.Point(8, 89);
            this.lblEEfectivo.Name = "lblEEfectivo";
            this.lblEEfectivo.Size = new System.Drawing.Size(83, 24);
            this.lblEEfectivo.TabIndex = 2;
            this.lblEEfectivo.Text = "Efectivo:";
            // 
            // btnCredito
            // 
            this.btnCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCredito.Location = new System.Drawing.Point(64, 238);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(150, 46);
            this.btnCredito.TabIndex = 8;
            this.btnCredito.Text = "A pagos";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Visible = false;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.lblCambio.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblCambio.ForeColor = System.Drawing.Color.White;
            this.lblCambio.Location = new System.Drawing.Point(97, 121);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(57, 24);
            this.lblCambio.TabIndex = 6;
            this.lblCambio.Text = "$0.00";
            // 
            // lblECambio
            // 
            this.lblECambio.AutoSize = true;
            this.lblECambio.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblECambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECambio.Location = new System.Drawing.Point(10, 121);
            this.lblECambio.Name = "lblECambio";
            this.lblECambio.Size = new System.Drawing.Size(81, 24);
            this.lblECambio.TabIndex = 5;
            this.lblECambio.Text = "Cambio:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Débito"});
            this.cboTipoPago.Location = new System.Drawing.Point(150, 9);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(220, 29);
            this.cboTipoPago.TabIndex = 9;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged);
            // 
            // lblETipoPago
            // 
            this.lblETipoPago.AutoSize = true;
            this.lblETipoPago.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblETipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoPago.Location = new System.Drawing.Point(8, 12);
            this.lblETipoPago.Name = "lblETipoPago";
            this.lblETipoPago.Size = new System.Drawing.Size(136, 22);
            this.lblETipoPago.TabIndex = 10;
            this.lblETipoPago.Text = "Método de pago";
            // 
            // txtDatos
            // 
            this.txtDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDatos.Enabled = false;
            this.txtDatos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDatos.Location = new System.Drawing.Point(180, 89);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(190, 29);
            this.txtDatos.TabIndex = 11;
            this.txtDatos.Visible = false;
            // 
            // lblEDatos
            // 
            this.lblEDatos.AutoSize = true;
            this.lblEDatos.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDatos.Location = new System.Drawing.Point(176, 64);
            this.lblEDatos.Name = "lblEDatos";
            this.lblEDatos.Size = new System.Drawing.Size(133, 22);
            this.lblEDatos.TabIndex = 12;
            this.lblEDatos.Text = "Núm. de cheque";
            this.lblEDatos.Visible = false;
            // 
            // frmCobrar
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 296);
            this.Controls.Add(this.lblEDatos);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lblETipoPago);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblECambio);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.lblEEfectivo);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblETotal);
            this.Controls.Add(this.btnCobrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar venta";
            this.Load += new System.EventHandler(this.frmCobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblEEfectivo;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblECambio;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label lblETipoPago;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lblEDatos;
    }
}