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
            this.lblEPorcentajeImpuesto = new System.Windows.Forms.Label();
            this.txtPorcentajeImpuesto = new System.Windows.Forms.TextBox();
            this.lblEFolioTerminal = new System.Windows.Forms.Label();
            this.txtFolioTerminal = new System.Windows.Forms.TextBox();
            this.chbSaldo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblESaldo = new System.Windows.Forms.Label();
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
            this.btnCobrar.Location = new System.Drawing.Point(402, 221);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(150, 46);
            this.btnCobrar.TabIndex = 14;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblTotal.Location = new System.Drawing.Point(72, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 24);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblETotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETotal.Location = new System.Drawing.Point(8, 126);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(58, 24);
            this.lblETotal.TabIndex = 8;
            this.lblETotal.Text = "Total:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEfectivo.Location = new System.Drawing.Point(279, 126);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(91, 29);
            this.txtEfectivo.TabIndex = 11;
            this.txtEfectivo.Text = "0.00";
            this.txtEfectivo.Click += new System.EventHandler(this.txtEfectivo_Click);
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.Enter += new System.EventHandler(this.txtEfectivo_Enter);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
            // 
            // lblEEfectivo
            // 
            this.lblEEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEEfectivo.AutoSize = true;
            this.lblEEfectivo.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEfectivo.Location = new System.Drawing.Point(190, 126);
            this.lblEEfectivo.Name = "lblEEfectivo";
            this.lblEEfectivo.Size = new System.Drawing.Size(83, 24);
            this.lblEEfectivo.TabIndex = 10;
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
            this.btnCredito.Location = new System.Drawing.Point(246, 221);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(150, 46);
            this.btnCredito.TabIndex = 15;
            this.btnCredito.Text = "A pagos";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Visible = false;
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.lblCambio.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblCambio.ForeColor = System.Drawing.Color.White;
            this.lblCambio.Location = new System.Drawing.Point(463, 126);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(57, 24);
            this.lblCambio.TabIndex = 13;
            this.lblCambio.Text = "$0.00";
            // 
            // lblECambio
            // 
            this.lblECambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblECambio.AutoSize = true;
            this.lblECambio.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblECambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECambio.Location = new System.Drawing.Point(376, 126);
            this.lblECambio.Name = "lblECambio";
            this.lblECambio.Size = new System.Drawing.Size(81, 24);
            this.lblECambio.TabIndex = 12;
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
            this.cboTipoPago.TabIndex = 1;
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
            this.lblETipoPago.TabIndex = 0;
            this.lblETipoPago.Text = "Método de pago";
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDatos.Location = new System.Drawing.Point(194, 82);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(176, 29);
            this.txtDatos.TabIndex = 5;
            this.txtDatos.Visible = false;
            // 
            // lblEDatos
            // 
            this.lblEDatos.AutoSize = true;
            this.lblEDatos.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDatos.Location = new System.Drawing.Point(190, 57);
            this.lblEDatos.Name = "lblEDatos";
            this.lblEDatos.Size = new System.Drawing.Size(133, 22);
            this.lblEDatos.TabIndex = 4;
            this.lblEDatos.Text = "Núm. de cheque";
            this.lblEDatos.Visible = false;
            // 
            // lblEPorcentajeImpuesto
            // 
            this.lblEPorcentajeImpuesto.AutoSize = true;
            this.lblEPorcentajeImpuesto.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEPorcentajeImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPorcentajeImpuesto.Location = new System.Drawing.Point(8, 57);
            this.lblEPorcentajeImpuesto.Name = "lblEPorcentajeImpuesto";
            this.lblEPorcentajeImpuesto.Size = new System.Drawing.Size(73, 22);
            this.lblEPorcentajeImpuesto.TabIndex = 2;
            this.lblEPorcentajeImpuesto.Text = "% Cargo";
            this.lblEPorcentajeImpuesto.Visible = false;
            // 
            // txtPorcentajeImpuesto
            // 
            this.txtPorcentajeImpuesto.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtPorcentajeImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtPorcentajeImpuesto.Location = new System.Drawing.Point(12, 82);
            this.txtPorcentajeImpuesto.Name = "txtPorcentajeImpuesto";
            this.txtPorcentajeImpuesto.Size = new System.Drawing.Size(176, 29);
            this.txtPorcentajeImpuesto.TabIndex = 3;
            this.txtPorcentajeImpuesto.Text = "0";
            this.txtPorcentajeImpuesto.Visible = false;
            this.txtPorcentajeImpuesto.TextChanged += new System.EventHandler(this.txtPorcentajeImpuesto_TextChanged);
            this.txtPorcentajeImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeImpuesto_KeyPress);
            // 
            // lblEFolioTerminal
            // 
            this.lblEFolioTerminal.AutoSize = true;
            this.lblEFolioTerminal.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblEFolioTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFolioTerminal.Location = new System.Drawing.Point(372, 57);
            this.lblEFolioTerminal.Name = "lblEFolioTerminal";
            this.lblEFolioTerminal.Size = new System.Drawing.Size(114, 22);
            this.lblEFolioTerminal.TabIndex = 6;
            this.lblEFolioTerminal.Text = "Folio terminal";
            this.lblEFolioTerminal.Visible = false;
            // 
            // txtFolioTerminal
            // 
            this.txtFolioTerminal.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtFolioTerminal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtFolioTerminal.Location = new System.Drawing.Point(376, 82);
            this.txtFolioTerminal.Name = "txtFolioTerminal";
            this.txtFolioTerminal.Size = new System.Drawing.Size(176, 29);
            this.txtFolioTerminal.TabIndex = 7;
            this.txtFolioTerminal.Visible = false;
            // 
            // chbSaldo
            // 
            this.chbSaldo.AutoSize = true;
            this.chbSaldo.Font = new System.Drawing.Font("Corbel", 13F);
            this.chbSaldo.Location = new System.Drawing.Point(376, 12);
            this.chbSaldo.Name = "chbSaldo";
            this.chbSaldo.Size = new System.Drawing.Size(168, 26);
            this.chbSaldo.TabIndex = 16;
            this.chbSaldo.Text = "Cliente tiene saldo";
            this.chbSaldo.UseVisualStyleBackColor = true;
            this.chbSaldo.CheckedChanged += new System.EventHandler(this.chbSaldo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(77, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "$0.00";
            // 
            // lblESaldo
            // 
            this.lblESaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblESaldo.AutoSize = true;
            this.lblESaldo.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblESaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESaldo.Location = new System.Drawing.Point(8, 167);
            this.lblESaldo.Name = "lblESaldo";
            this.lblESaldo.Size = new System.Drawing.Size(63, 24);
            this.lblESaldo.TabIndex = 17;
            this.lblESaldo.Text = "Saldo:";
            // 
            // frmCobrar
            // 
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblESaldo);
            this.Controls.Add(this.chbSaldo);
            this.Controls.Add(this.lblEFolioTerminal);
            this.Controls.Add(this.txtFolioTerminal);
            this.Controls.Add(this.lblEPorcentajeImpuesto);
            this.Controls.Add(this.txtPorcentajeImpuesto);
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
        private System.Windows.Forms.Label lblEPorcentajeImpuesto;
        private System.Windows.Forms.TextBox txtPorcentajeImpuesto;
        private System.Windows.Forms.Label lblEFolioTerminal;
        private System.Windows.Forms.TextBox txtFolioTerminal;
        private System.Windows.Forms.CheckBox chbSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblESaldo;
    }
}