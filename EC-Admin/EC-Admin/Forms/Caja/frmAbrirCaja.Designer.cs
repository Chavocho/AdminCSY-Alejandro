namespace EC_Admin.Forms
{
    partial class frmAbrirCaja
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
            this.lblEEfeDejar = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEEfeCaja = new System.Windows.Forms.Label();
            this.lblEfeCaja = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEEfeDejar
            // 
            this.lblEEfeDejar.AutoSize = true;
            this.lblEEfeDejar.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEEfeDejar.Location = new System.Drawing.Point(10, 44);
            this.lblEEfeDejar.Name = "lblEEfeDejar";
            this.lblEEfeDejar.Size = new System.Drawing.Size(144, 24);
            this.lblEEfeDejar.TabIndex = 4;
            this.lblEEfeDejar.Text = "Efectivo a dejar:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEfectivo.Location = new System.Drawing.Point(160, 44);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(145, 29);
            this.txtEfectivo.TabIndex = 3;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress);
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
            this.btnAceptar.Location = new System.Drawing.Point(155, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblEEfeCaja
            // 
            this.lblEEfeCaja.AutoSize = true;
            this.lblEEfeCaja.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblEEfeCaja.Location = new System.Drawing.Point(8, 9);
            this.lblEEfeCaja.Name = "lblEEfeCaja";
            this.lblEEfeCaja.Size = new System.Drawing.Size(146, 24);
            this.lblEEfeCaja.TabIndex = 10;
            this.lblEEfeCaja.Text = "Efectivo en caja:";
            // 
            // lblEfeCaja
            // 
            this.lblEfeCaja.AutoSize = true;
            this.lblEfeCaja.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblEfeCaja.Location = new System.Drawing.Point(160, 9);
            this.lblEfeCaja.Name = "lblEfeCaja";
            this.lblEfeCaja.Size = new System.Drawing.Size(57, 24);
            this.lblEfeCaja.TabIndex = 11;
            this.lblEfeCaja.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(210)))), ((int)(((byte)(50)))));
            this.lblTotal.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(160, 78);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 24);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 15F);
            this.lblETotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETotal.Location = new System.Drawing.Point(27, 78);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(127, 24);
            this.lblETotal.TabIndex = 12;
            this.lblETotal.Text = "Efectivo total:";
            // 
            // frmAbrirCaja
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 235);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblETotal);
            this.Controls.Add(this.lblEfeCaja);
            this.Controls.Add(this.lblEEfeCaja);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEEfeDejar);
            this.Controls.Add(this.txtEfectivo);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAbrirCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEEfeDejar;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEEfeCaja;
        private System.Windows.Forms.Label lblEfeCaja;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
    }
}