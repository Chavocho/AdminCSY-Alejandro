using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    public partial class Ticket
    {
        /// <summary>
        /// Inicializa la instancia de la clase Ticket
        /// </summary>
        public Ticket()
        {
            ObtenerDatosConfiguracion();
            pd = new PrintDocument();
            ppd = new PrintPreviewDialog();
            dtVenta = new DataTable();
            dtVentaDetallada = new DataTable();
            fuenteNormal = new Font("Consolas", 10F, FontStyle.Regular);
            fuenteNormalResaltada = new Font("Consolas", 10F, FontStyle.Bold);
            fuenteGrande = new Font("Consolas", 12F, FontStyle.Regular);
            fuenteGrandeResaltada = new Font("Consolas", 12F, FontStyle.Bold);
            y = 0;
        }

        public void TicketVenta(int id)
        {
            try
            {
                this.idVenta = id;
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPageTicketVenta);
                pd.DocumentName = "Ticket";
                pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 300, 10000);
                pd.PrinterSettings.PrinterName = impresora;
                //ppd.Document = pd;
                //ppd.ShowDialog();
                pd.Print();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ImprimirCorteCaja(int idApertura, int idCierre)
        {
            try
            {
                this.idApertura = idApertura;
                this.idCierre = idCierre;
                dtCaja = new DataTable();
                ObtenerDatosCorteCaja();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPageTicketCaja);
                pd.DocumentName = "Ticket";
                pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 300, 10000);
                pd.PrinterSettings.PrinterName = impresora;
                //ppd.Document = pd;
                //ppd.ShowDialog();
                pd.Print();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ImprimirCaja(bool esCierreCaja)
        {
            try
            {
                dtCaja = new DataTable();
                this.esCierreCaja = esCierreCaja;
                ObtenerDatosCaja();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPageTicketCaja);
                pd.DocumentName = "Ticket";
                pd.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 300, 10000);
                pd.PrinterSettings.PrinterName = impresora;
                //ppd.Document = pd;
                //ppd.ShowDialog();
                pd.Print();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pd_PrintPageTicketVenta(object sender, PrintPageEventArgs e)
        {
            try
            {
                ObtenerDatosVenta();
                ObtenerDatosVentaDetallada();
                AgregarEncabezadoTicket(ref e);
                AgregarLinea(ref e, new Pen(Brushes.DarkGray, 1));
                AgregarInformacionTicket(ref e, false);
                AgregarLinea(ref e, new Pen(Brushes.DarkGray, 1));
                AgregarProductosVentas(ref e, dtVentaDetallada);
                AgregarTotalVenta(ref e, dtVenta);
                AgregarLinea(ref e, new Pen(Brushes.DarkGray, 1));
                AgregarPieTicket(ref e, dtVenta);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento de impresión de ticket de caja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException"></exception>
        /// <exception cref="System.Exception"></exception>
        private void pd_PrintPageTicketCaja(object sender, PrintPageEventArgs e)
        {
            try
            {
                AgregarEncabezadoTicket(ref e);
                AgregarLinea(ref e, new Pen(Brushes.DarkGray, 1));
                AgregarInformacionTicket(ref e, true);
                AgregarLinea(ref e, new Pen(Brushes.DarkGray, 1));
                AgregarDatosCierreCaja(ref e);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
