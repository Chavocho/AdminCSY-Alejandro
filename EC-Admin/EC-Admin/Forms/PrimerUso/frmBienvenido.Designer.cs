namespace EC_Admin
{
    partial class frmBienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenido));
            this.lblTitulo02 = new System.Windows.Forms.Label();
            this.lblTitulo01 = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo02
            // 
            this.lblTitulo02.AutoSize = true;
            this.lblTitulo02.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo02.Location = new System.Drawing.Point(252, 61);
            this.lblTitulo02.Name = "lblTitulo02";
            this.lblTitulo02.Size = new System.Drawing.Size(97, 24);
            this.lblTitulo02.TabIndex = 1;
            this.lblTitulo02.Text = "Admin CSY";
            // 
            // lblTitulo01
            // 
            this.lblTitulo01.AutoSize = true;
            this.lblTitulo01.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo01.Location = new System.Drawing.Point(246, 21);
            this.lblTitulo01.Name = "lblTitulo01";
            this.lblTitulo01.Size = new System.Drawing.Size(109, 22);
            this.lblTitulo01.TabIndex = 0;
            this.lblTitulo01.Text = "Bienvenido a";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.Location = new System.Drawing.Point(62, 111);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(476, 72);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = resources.GetString("lblSubtitulo.Text");
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnAceptar.Location = new System.Drawing.Point(438, 242);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Siguiente";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo01);
            this.Controls.Add(this.lblTitulo02);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo02;
        private System.Windows.Forms.Label lblTitulo01;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnAceptar;
    }
}