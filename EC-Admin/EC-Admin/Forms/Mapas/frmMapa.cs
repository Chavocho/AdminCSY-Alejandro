﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmMapa : Form
    {
        private string archivo = Application.StartupPath + "\\mapas\\mapa.html";
        private string mapaUbicacion = Application.StartupPath + "\\mapas\\MapaUbicacionPersona.html";
        private string direccion;
        private Uri mapa;

        public frmMapa(string direccion, string texto)
        {
            InitializeComponent();
            this.Text = texto;
            this.direccion = direccion;
        }

        private void UbicarPersona()
        {
            try
            {
                if (File.Exists(archivo))
                {
                    string html = "";
                    html = File.ReadAllText(archivo);
                    html = html.Replace("@direccion_persona@", direccion);
                    File.WriteAllText(mapaUbicacion, html);
                    mapa = new Uri(mapaUbicacion);
                    wbrMapa.Url = mapa;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmMapa_Shown(object sender, EventArgs e)
        {
            UbicarPersona();
        }
    }
}
