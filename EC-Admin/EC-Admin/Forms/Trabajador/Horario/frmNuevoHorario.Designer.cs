namespace EC_Admin.Forms
{
    partial class frmNuevoHorario
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
            this.chbDomingo = new System.Windows.Forms.CheckBox();
            this.chbSabado = new System.Windows.Forms.CheckBox();
            this.chbViernes = new System.Windows.Forms.CheckBox();
            this.chbJueves = new System.Windows.Forms.CheckBox();
            this.chbMiercoles = new System.Windows.Forms.CheckBox();
            this.chbMartes = new System.Windows.Forms.CheckBox();
            this.chbLunes = new System.Windows.Forms.CheckBox();
            this.grbDias = new System.Windows.Forms.GroupBox();
            this.grbHorario = new System.Windows.Forms.GroupBox();
            this.lblEHoraFin = new System.Windows.Forms.Label();
            this.lblEHoraIni = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraIni = new System.Windows.Forms.DateTimePicker();
            this.lblEHoras = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbDias.SuspendLayout();
            this.grbHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbDomingo
            // 
            this.chbDomingo.AutoSize = true;
            this.chbDomingo.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbDomingo.Location = new System.Drawing.Point(325, 21);
            this.chbDomingo.Name = "chbDomingo";
            this.chbDomingo.Size = new System.Drawing.Size(84, 22);
            this.chbDomingo.TabIndex = 6;
            this.chbDomingo.Text = "Domingo";
            this.chbDomingo.UseVisualStyleBackColor = true;
            this.chbDomingo.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbSabado
            // 
            this.chbSabado.AutoSize = true;
            this.chbSabado.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbSabado.Location = new System.Drawing.Point(209, 49);
            this.chbSabado.Name = "chbSabado";
            this.chbSabado.Size = new System.Drawing.Size(73, 22);
            this.chbSabado.TabIndex = 5;
            this.chbSabado.Text = "Sábado";
            this.chbSabado.UseVisualStyleBackColor = true;
            this.chbSabado.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbViernes
            // 
            this.chbViernes.AutoSize = true;
            this.chbViernes.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbViernes.Location = new System.Drawing.Point(210, 21);
            this.chbViernes.Name = "chbViernes";
            this.chbViernes.Size = new System.Drawing.Size(72, 22);
            this.chbViernes.TabIndex = 4;
            this.chbViernes.Text = "Viernes";
            this.chbViernes.UseVisualStyleBackColor = true;
            this.chbViernes.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbJueves
            // 
            this.chbJueves.AutoSize = true;
            this.chbJueves.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbJueves.Location = new System.Drawing.Point(95, 49);
            this.chbJueves.Name = "chbJueves";
            this.chbJueves.Size = new System.Drawing.Size(68, 22);
            this.chbJueves.TabIndex = 3;
            this.chbJueves.Text = "Jueves";
            this.chbJueves.UseVisualStyleBackColor = true;
            this.chbJueves.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbMiercoles
            // 
            this.chbMiercoles.AutoSize = true;
            this.chbMiercoles.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbMiercoles.Location = new System.Drawing.Point(95, 21);
            this.chbMiercoles.Name = "chbMiercoles";
            this.chbMiercoles.Size = new System.Drawing.Size(85, 22);
            this.chbMiercoles.TabIndex = 2;
            this.chbMiercoles.Text = "Miércoles";
            this.chbMiercoles.UseVisualStyleBackColor = true;
            this.chbMiercoles.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbMartes
            // 
            this.chbMartes.AutoSize = true;
            this.chbMartes.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbMartes.Location = new System.Drawing.Point(6, 49);
            this.chbMartes.Name = "chbMartes";
            this.chbMartes.Size = new System.Drawing.Size(69, 22);
            this.chbMartes.TabIndex = 1;
            this.chbMartes.Text = "Martes";
            this.chbMartes.UseVisualStyleBackColor = true;
            this.chbMartes.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // chbLunes
            // 
            this.chbLunes.AutoSize = true;
            this.chbLunes.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbLunes.Location = new System.Drawing.Point(6, 21);
            this.chbLunes.Name = "chbLunes";
            this.chbLunes.Size = new System.Drawing.Size(64, 22);
            this.chbLunes.TabIndex = 0;
            this.chbLunes.Text = "Lunes";
            this.chbLunes.UseVisualStyleBackColor = true;
            this.chbLunes.CheckedChanged += new System.EventHandler(this.chbDias_CheckedChanged);
            // 
            // grbDias
            // 
            this.grbDias.Controls.Add(this.chbLunes);
            this.grbDias.Controls.Add(this.chbDomingo);
            this.grbDias.Controls.Add(this.chbMartes);
            this.grbDias.Controls.Add(this.chbSabado);
            this.grbDias.Controls.Add(this.chbMiercoles);
            this.grbDias.Controls.Add(this.chbViernes);
            this.grbDias.Controls.Add(this.chbJueves);
            this.grbDias.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbDias.Location = new System.Drawing.Point(12, 12);
            this.grbDias.Name = "grbDias";
            this.grbDias.Size = new System.Drawing.Size(425, 77);
            this.grbDias.TabIndex = 0;
            this.grbDias.TabStop = false;
            this.grbDias.Text = "Días de trabajo";
            // 
            // grbHorario
            // 
            this.grbHorario.Controls.Add(this.lblEHoraFin);
            this.grbHorario.Controls.Add(this.lblEHoraIni);
            this.grbHorario.Controls.Add(this.dtpHoraFin);
            this.grbHorario.Controls.Add(this.dtpHoraIni);
            this.grbHorario.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbHorario.Location = new System.Drawing.Point(12, 95);
            this.grbHorario.Name = "grbHorario";
            this.grbHorario.Size = new System.Drawing.Size(425, 76);
            this.grbHorario.TabIndex = 1;
            this.grbHorario.TabStop = false;
            this.grbHorario.Text = "Horario";
            // 
            // lblEHoraFin
            // 
            this.lblEHoraFin.AutoSize = true;
            this.lblEHoraFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEHoraFin.Location = new System.Drawing.Point(213, 18);
            this.lblEHoraFin.Name = "lblEHoraFin";
            this.lblEHoraFin.Size = new System.Drawing.Size(93, 18);
            this.lblEHoraFin.TabIndex = 2;
            this.lblEHoraFin.Text = "Hora de salida";
            // 
            // lblEHoraIni
            // 
            this.lblEHoraIni.AutoSize = true;
            this.lblEHoraIni.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEHoraIni.Location = new System.Drawing.Point(6, 18);
            this.lblEHoraIni.Name = "lblEHoraIni";
            this.lblEHoraIni.Size = new System.Drawing.Size(106, 18);
            this.lblEHoraIni.TabIndex = 0;
            this.lblEHoraIni.Text = "Hora de entrada";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "hh:mm tt";
            this.dtpHoraFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(216, 39);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(203, 25);
            this.dtpHoraFin.TabIndex = 3;
            this.dtpHoraFin.Value = new System.DateTime(1753, 1, 1, 18, 0, 0, 0);
            this.dtpHoraFin.ValueChanged += new System.EventHandler(this.dtpHoras_ValueChanged);
            // 
            // dtpHoraIni
            // 
            this.dtpHoraIni.CustomFormat = "hh:mm tt";
            this.dtpHoraIni.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraIni.Location = new System.Drawing.Point(6, 39);
            this.dtpHoraIni.Name = "dtpHoraIni";
            this.dtpHoraIni.ShowUpDown = true;
            this.dtpHoraIni.Size = new System.Drawing.Size(204, 25);
            this.dtpHoraIni.TabIndex = 1;
            this.dtpHoraIni.Value = new System.DateTime(1753, 1, 1, 9, 0, 0, 0);
            this.dtpHoraIni.ValueChanged += new System.EventHandler(this.dtpHoras_ValueChanged);
            // 
            // lblEHoras
            // 
            this.lblEHoras.AutoSize = true;
            this.lblEHoras.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEHoras.Location = new System.Drawing.Point(9, 213);
            this.lblEHoras.Name = "lblEHoras";
            this.lblEHoras.Size = new System.Drawing.Size(111, 18);
            this.lblEHoras.TabIndex = 2;
            this.lblEHoras.Text = "Horas trabajadas";
            this.lblEHoras.Visible = false;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblHoras.Location = new System.Drawing.Point(9, 236);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(24, 18);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "60";
            this.lblHoras.Visible = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(287, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmNuevoHorario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 266);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblEHoras);
            this.Controls.Add(this.grbHorario);
            this.Controls.Add(this.grbDias);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevoHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar horario a ";
            this.grbDias.ResumeLayout(false);
            this.grbDias.PerformLayout();
            this.grbHorario.ResumeLayout(false);
            this.grbHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDomingo;
        private System.Windows.Forms.CheckBox chbSabado;
        private System.Windows.Forms.CheckBox chbViernes;
        private System.Windows.Forms.CheckBox chbJueves;
        private System.Windows.Forms.CheckBox chbMiercoles;
        private System.Windows.Forms.CheckBox chbMartes;
        private System.Windows.Forms.CheckBox chbLunes;
        private System.Windows.Forms.GroupBox grbDias;
        private System.Windows.Forms.GroupBox grbHorario;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraIni;
        private System.Windows.Forms.Label lblEHoraFin;
        private System.Windows.Forms.Label lblEHoraIni;
        private System.Windows.Forms.Label lblEHoras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnAceptar;

    }
}