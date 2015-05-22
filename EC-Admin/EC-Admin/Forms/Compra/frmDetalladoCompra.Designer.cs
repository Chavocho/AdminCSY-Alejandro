namespace EC_Admin.Forms
{
    partial class frmDetalladoCompra
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
            this.components = new System.ComponentModel.Container();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEDescuento = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblEImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblESubtotal = new System.Windows.Forms.Label();
            this.lblFolioFactura = new System.Windows.Forms.Label();
            this.lblEFolioFactura = new System.Windows.Forms.Label();
            this.lblFolioRemision = new System.Windows.Forms.Label();
            this.lblEFolioRemision = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblEFactura = new System.Windows.Forms.Label();
            this.lblRemision = new System.Windows.Forms.Label();
            this.lblERemision = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblETipoPago = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEFecha = new System.Windows.Forms.Label();
            this.pnlDetallada = new System.Windows.Forms.Panel();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.pnlCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCompra
            // 
            this.pnlCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompra.Controls.Add(this.lblTotal);
            this.pnlCompra.Controls.Add(this.lblETotal);
            this.pnlCompra.Controls.Add(this.lblDescuento);
            this.pnlCompra.Controls.Add(this.lblEDescuento);
            this.pnlCompra.Controls.Add(this.lblImpuesto);
            this.pnlCompra.Controls.Add(this.lblEImpuesto);
            this.pnlCompra.Controls.Add(this.lblSubtotal);
            this.pnlCompra.Controls.Add(this.lblESubtotal);
            this.pnlCompra.Controls.Add(this.lblFolioFactura);
            this.pnlCompra.Controls.Add(this.lblEFolioFactura);
            this.pnlCompra.Controls.Add(this.lblFolioRemision);
            this.pnlCompra.Controls.Add(this.lblEFolioRemision);
            this.pnlCompra.Controls.Add(this.lblFactura);
            this.pnlCompra.Controls.Add(this.lblEFactura);
            this.pnlCompra.Controls.Add(this.lblRemision);
            this.pnlCompra.Controls.Add(this.lblERemision);
            this.pnlCompra.Controls.Add(this.lblTipoPago);
            this.pnlCompra.Controls.Add(this.lblETipoPago);
            this.pnlCompra.Controls.Add(this.lblFecha);
            this.pnlCompra.Controls.Add(this.lblEFecha);
            this.pnlCompra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlCompra.Location = new System.Drawing.Point(0, 0);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(1008, 115);
            this.pnlCompra.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(918, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 19);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "---";
            // 
            // lblETotal
            // 
            this.lblETotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblETotal.AutoSize = true;
            this.lblETotal.Location = new System.Drawing.Point(873, 65);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(39, 19);
            this.lblETotal.TabIndex = 18;
            this.lblETotal.Text = "Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.Location = new System.Drawing.Point(793, 84);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(27, 19);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "---";
            // 
            // lblEDescuento
            // 
            this.lblEDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEDescuento.AutoSize = true;
            this.lblEDescuento.Location = new System.Drawing.Point(713, 65);
            this.lblEDescuento.Name = "lblEDescuento";
            this.lblEDescuento.Size = new System.Drawing.Size(74, 19);
            this.lblEDescuento.TabIndex = 16;
            this.lblEDescuento.Text = "Descuento";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImpuesto.Location = new System.Drawing.Point(637, 84);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(27, 19);
            this.lblImpuesto.TabIndex = 15;
            this.lblImpuesto.Text = "---";
            // 
            // lblEImpuesto
            // 
            this.lblEImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEImpuesto.AutoSize = true;
            this.lblEImpuesto.Location = new System.Drawing.Point(573, 65);
            this.lblEImpuesto.Name = "lblEImpuesto";
            this.lblEImpuesto.Size = new System.Drawing.Size(67, 19);
            this.lblEImpuesto.TabIndex = 14;
            this.lblEImpuesto.Text = "Impuesto";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(487, 84);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(27, 19);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "---";
            // 
            // lblESubtotal
            // 
            this.lblESubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblESubtotal.AutoSize = true;
            this.lblESubtotal.Location = new System.Drawing.Point(421, 65);
            this.lblESubtotal.Name = "lblESubtotal";
            this.lblESubtotal.Size = new System.Drawing.Size(60, 19);
            this.lblESubtotal.TabIndex = 12;
            this.lblESubtotal.Text = "Subtotal";
            // 
            // lblFolioFactura
            // 
            this.lblFolioFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFolioFactura.AutoSize = true;
            this.lblFolioFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFolioFactura.Location = new System.Drawing.Point(331, 84);
            this.lblFolioFactura.Name = "lblFolioFactura";
            this.lblFolioFactura.Size = new System.Drawing.Size(27, 19);
            this.lblFolioFactura.TabIndex = 11;
            this.lblFolioFactura.Text = "---";
            // 
            // lblEFolioFactura
            // 
            this.lblEFolioFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFolioFactura.AutoSize = true;
            this.lblEFolioFactura.Location = new System.Drawing.Point(222, 65);
            this.lblEFolioFactura.Name = "lblEFolioFactura";
            this.lblEFolioFactura.Size = new System.Drawing.Size(103, 19);
            this.lblEFolioFactura.TabIndex = 10;
            this.lblEFolioFactura.Text = "Folio de factura";
            // 
            // lblFolioRemision
            // 
            this.lblFolioRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFolioRemision.AutoSize = true;
            this.lblFolioRemision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFolioRemision.Location = new System.Drawing.Point(131, 84);
            this.lblFolioRemision.Name = "lblFolioRemision";
            this.lblFolioRemision.Size = new System.Drawing.Size(27, 19);
            this.lblFolioRemision.TabIndex = 9;
            this.lblFolioRemision.Text = "---";
            // 
            // lblEFolioRemision
            // 
            this.lblEFolioRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFolioRemision.AutoSize = true;
            this.lblEFolioRemision.Location = new System.Drawing.Point(12, 65);
            this.lblEFolioRemision.Name = "lblEFolioRemision";
            this.lblEFolioRemision.Size = new System.Drawing.Size(113, 19);
            this.lblEFolioRemision.TabIndex = 8;
            this.lblEFolioRemision.Text = "Folio de remisión";
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFactura.Location = new System.Drawing.Point(918, 28);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(27, 19);
            this.lblFactura.TabIndex = 7;
            this.lblFactura.Text = "---";
            // 
            // lblEFactura
            // 
            this.lblEFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFactura.AutoSize = true;
            this.lblEFactura.Location = new System.Drawing.Point(799, 9);
            this.lblEFactura.Name = "lblEFactura";
            this.lblEFactura.Size = new System.Drawing.Size(113, 19);
            this.lblEFactura.TabIndex = 6;
            this.lblEFactura.Text = "Se recibió factura";
            // 
            // lblRemision
            // 
            this.lblRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemision.Location = new System.Drawing.Point(713, 28);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(27, 19);
            this.lblRemision.TabIndex = 5;
            this.lblRemision.Text = "---";
            // 
            // lblERemision
            // 
            this.lblERemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblERemision.AutoSize = true;
            this.lblERemision.Location = new System.Drawing.Point(584, 9);
            this.lblERemision.Name = "lblERemision";
            this.lblERemision.Size = new System.Drawing.Size(123, 19);
            this.lblERemision.TabIndex = 4;
            this.lblERemision.Text = "Se recibió remisión";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoPago.Location = new System.Drawing.Point(421, 28);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(27, 19);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "---";
            // 
            // lblETipoPago
            // 
            this.lblETipoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblETipoPago.AutoSize = true;
            this.lblETipoPago.Location = new System.Drawing.Point(331, 9);
            this.lblETipoPago.Name = "lblETipoPago";
            this.lblETipoPago.Size = new System.Drawing.Size(84, 19);
            this.lblETipoPago.TabIndex = 2;
            this.lblETipoPago.Text = "Se pago con";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(62, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(27, 19);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "---";
            // 
            // lblEFecha
            // 
            this.lblEFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFecha.AutoSize = true;
            this.lblEFecha.Location = new System.Drawing.Point(12, 9);
            this.lblEFecha.Name = "lblEFecha";
            this.lblEFecha.Size = new System.Drawing.Size(44, 19);
            this.lblEFecha.TabIndex = 0;
            this.lblEFecha.Text = "Fecha";
            // 
            // pnlDetallada
            // 
            this.pnlDetallada.AutoScroll = true;
            this.pnlDetallada.BackColor = System.Drawing.Color.White;
            this.pnlDetallada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetallada.Location = new System.Drawing.Point(0, 114);
            this.pnlDetallada.Name = "pnlDetallada";
            this.pnlDetallada.Size = new System.Drawing.Size(1008, 421);
            this.pnlDetallada.TabIndex = 2;
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            // 
            // frmDetalladoCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.pnlDetallada);
            this.Controls.Add(this.pnlCompra);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Name = "frmDetalladoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detallado de la compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDetalladoCompra_Load);
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEDescuento;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblEImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblESubtotal;
        private System.Windows.Forms.Label lblFolioFactura;
        private System.Windows.Forms.Label lblEFolioFactura;
        private System.Windows.Forms.Label lblFolioRemision;
        private System.Windows.Forms.Label lblEFolioRemision;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblEFactura;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.Label lblERemision;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblETipoPago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEFecha;
        private System.Windows.Forms.Panel pnlDetallada;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
    }
}