using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    class Camara
    {
        PictureBox pcb;
        ComboBox cbo;
        private bool existeCamara = false;
        private FilterInfoCollection dispositivoDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;

        public bool ExisteCamara
        {
            get { return existeCamara; }
        }

        public VideoCaptureDevice FuenteDeVideo
        {
            get { return fuenteDeVideo; }
            set { fuenteDeVideo = value; }
        }

        public Camara(ref PictureBox pcb, ref ComboBox cbo)
        {
            this.pcb = pcb;
            this.cbo = cbo;
            BuscarCamaras();
        }

        public void CargarCamaras(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cbo.Items.Add(Dispositivos[i].Name.ToString());
            cbo.Text = cbo.Items[0].ToString();
        }

        public void BuscarCamaras()
        {
            dispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivoDeVideo.Count == 0)
            {
                existeCamara = false;
            }
            else
            {
                existeCamara = true;
                CargarCamaras(dispositivoDeVideo);
            }
        }

        public void IniciarCamara(int index)
        {
            fuenteDeVideo = new VideoCaptureDevice(dispositivoDeVideo[index].MonikerString);
            fuenteDeVideo.NewFrame += new NewFrameEventHandler(Mostrar_Imagen);
            fuenteDeVideo.Start();
        }

        public void TerminarFuenteDeVideo()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
        }

        public void Mostrar_Imagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pcb.Image = Imagen;
        }
    }
}
