using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_2.Frmcaja;
using static Proyecto_Final_2.Frmlogincs;

namespace Proyecto_Final_2
{
    public partial class Frmpago : Form
    {
        public decimal TotalVenta { get; private set; }
        public decimal DineroRecibido { get; private set; }
        public decimal Cambio { get; private set; }
        public bool Pagado { get; private set; }
        public List<ProductoVenta> Productos { get; set; } 

        public Frmpago(decimal total)
        {
            InitializeComponent();
            TotalVenta = total;

            txtTotalAPagar.Text = TotalVenta.ToString("F2"); 


            btncobrar.Click += btnCobrar_Click;
            btnCerrar.Click += btnCerrar_Click;
            chkEfectivo.CheckedChanged += chkEfectivo_CheckedChanged;
            chkTarjeta.CheckedChanged += chkTarjeta_CheckedChanged;
        }

        private void Frmpago_Load(object sender, EventArgs e)
        {
            lblTotalPagar.Text = $"Total a pagar: {TotalVenta:C}";
            chkEfectivo.Checked = true;

            lblpagotarjeta.Visible = false;
            txtcard.Visible = false;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            bool visible = chkTarjeta.Checked;

            
            txtcard.Visible = visible;
            lblpagotarjeta.Visible = visible;

            if (!visible)
                txtcard.Text = "";
        }

        public class ProductoVenta
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal Total { get; set; }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void chkEfectivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEfectivo.Checked) chkTarjeta.Checked = false;
        }

        private void btncobrar_Click_1(object sender, EventArgs e)
        {
            decimal pagoEfectivo = 0;
            decimal pagoTarjeta = 0;

            // Leer efectivo
            if (!string.IsNullOrWhiteSpace(txtRecibido.Text))
                decimal.TryParse(txtRecibido.Text, out pagoEfectivo);

            // Leer tarjeta
            if (chkTarjeta.Checked && !string.IsNullOrWhiteSpace(txtcard.Text))
                decimal.TryParse(txtcard.Text, out pagoTarjeta);

            // Sumar ambos pagos
            decimal totalRecibido = pagoEfectivo + pagoTarjeta;

            if (totalRecibido < TotalVenta)
            {
                MessageBox.Show("El monto total recibido es menor al total a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DineroRecibido = totalRecibido;
            Cambio = totalRecibido - TotalVenta;
            lblCambio.Text = $"Cambio: {Cambio:C}";

            Pagado = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}