namespace EC_Admin.Forms
{
    partial class frmEditarAlmacen
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEDescripcion = new System.Windows.Forms.Label();
            this.lblJefeAlmacen = new System.Windows.Forms.Label();
            this.lblEJefeAlmacen = new System.Windows.Forms.Label();
            this.txtNumAlm = new System.Windows.Forms.TextBox();
            this.lblENumAlm = new System.Windows.Forms.Label();
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
            this.btnAceptar.Location = new System.Drawing.Point(386, 159);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(439, 4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(97, 30);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar jefe";
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDescripcion.Location = new System.Drawing.Point(277, 53);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(259, 100);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblEDescripcion
            // 
            this.lblEDescripcion.AutoSize = true;
            this.lblEDescripcion.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDescripcion.Location = new System.Drawing.Point(274, 32);
            this.lblEDescripcion.Name = "lblEDescripcion";
            this.lblEDescripcion.Size = new System.Drawing.Size(80, 18);
            this.lblEDescripcion.TabIndex = 5;
            this.lblEDescripcion.Text = "Descripción";
            // 
            // lblJefeAlmacen
            // 
            this.lblJefeAlmacen.AutoSize = true;
            this.lblJefeAlmacen.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblJefeAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblJefeAlmacen.Location = new System.Drawing.Point(124, 9);
            this.lblJefeAlmacen.Name = "lblJefeAlmacen";
            this.lblJefeAlmacen.Size = new System.Drawing.Size(79, 18);
            this.lblJefeAlmacen.TabIndex = 1;
            this.lblJefeAlmacen.Text = "Sin asignar";
            // 
            // lblEJefeAlmacen
            // 
            this.lblEJefeAlmacen.AutoSize = true;
            this.lblEJefeAlmacen.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEJefeAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEJefeAlmacen.Location = new System.Drawing.Point(9, 9);
            this.lblEJefeAlmacen.Name = "lblEJefeAlmacen";
            this.lblEJefeAlmacen.Size = new System.Drawing.Size(109, 18);
            this.lblEJefeAlmacen.TabIndex = 0;
            this.lblEJefeAlmacen.Text = "Jefe de almacen:";
            // 
            // txtNumAlm
            // 
            this.txtNumAlm.BackColor = System.Drawing.Color.White;
            this.txtNumAlm.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumAlm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumAlm.Location = new System.Drawing.Point(12, 53);
            this.txtNumAlm.Name = "txtNumAlm";
            this.txtNumAlm.Size = new System.Drawing.Size(259, 29);
            this.txtNumAlm.TabIndex = 4;
            this.txtNumAlm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAlm_KeyPress);
            // 
            // lblENumAlm
            // 
            this.lblENumAlm.AutoSize = true;
            this.lblENumAlm.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblENumAlm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumAlm.Location = new System.Drawing.Point(9, 32);
            this.lblENumAlm.Name = "lblENumAlm";
            this.lblENumAlm.Size = new System.Drawing.Size(130, 18);
            this.lblENumAlm.TabIndex = 3;
            this.lblENumAlm.Text = "Número de almacen";
            // 
            // frmEditarAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 217);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblEDescripcion);
            this.Controls.Add(this.lblJefeAlmacen);
            this.Controls.Add(this.lblEJefeAlmacen);
            this.Controls.Add(this.txtNumAlm);
            this.Controls.Add(this.lblENumAlm);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditarAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar almacen";
            this.Load += new System.EventHandler(this.frmEditarAlmacen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEDescripcion;
        private System.Windows.Forms.Label lblJefeAlmacen;
        private System.Windows.Forms.Label lblEJefeAlmacen;
        private System.Windows.Forms.TextBox txtNumAlm;
        private System.Windows.Forms.Label lblENumAlm;
    }
}