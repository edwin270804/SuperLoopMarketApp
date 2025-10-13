using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Font = System.Drawing.Font;

namespace Proyecto_Final_2
{
    public partial class MDIVentas_ : Form
    {
        

        public MDIVentas_()
        {
            InitializeComponent();


            this.IsMdiContainer = false;
        }

        private void MDIVentas__Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Ventas");
            chart1.Series["Ventas"].ChartType = SeriesChartType.Column;
            chart1.Series["Ventas"].IsValueShownAsLabel = true;
            chart1.Series["Ventas"].Font = new Font("Segoe UI", 11, FontStyle.Bold);
            chart1.Series["Ventas"].Palette = ChartColorPalette.BrightPastel;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string conexion = parametros.cadenaConexion;

            string query = @"
                SELECT NombreProducto, SUM(Cantidad) AS CantidadVendida
                FROM DetalleVenta
                GROUP BY NombreProducto
                ORDER BY CantidadVendida DESC;";

            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string producto = reader["NombreProducto"].ToString();
                        int cantidad = Convert.ToInt32(reader["CantidadVendida"]);
                        chart1.Series["Ventas"].Points.AddXY(producto, cantidad);
                    }
                }
            }

            chart1.Dock = DockStyle.Top;
            chart1.Height = 960;
            panel1.Controls.Add(chart1);
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    FileName = "InformeProductosMasVendidos.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    Paragraph titulo = new Paragraph("INFORME DE PRODUCTOS MÁS VENDIDOS\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20, BaseColor.BLACK))
                    { Alignment = Element.ALIGN_CENTER };
                    doc.Add(titulo);

                    Paragraph fecha = new Paragraph("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.DARK_GRAY))
                    { Alignment = Element.ALIGN_RIGHT };
                    doc.Add(fecha);

                    PdfPTable tabla = new PdfPTable(4)
                    {
                        WidthPercentage = 100
                    };
                    tabla.SetWidths(new float[] { 40, 20, 20, 20 });

                    // Encabezados
                    tabla.AddCell(new PdfPCell(new Phrase("Producto", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("Total Vendido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("% del Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });

                    // === Conexión dinámica para datos ===
                    parametrosconexion parametros = AdministrarConexion.cargar();
                    if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                        return;

                    string conexion = parametros.cadenaConexion;

                    // Total general
                    decimal granTotal = 0;
                    using (SqlConnection con = new SqlConnection(conexion))
                    {
                        SqlCommand cmd = new SqlCommand("SELECT SUM(Total) FROM DetalleVenta", con);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        granTotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }

                    // Detalle productos
                    Dictionary<string, (int Cantidad, decimal Total)> productos = new Dictionary<string, (int, decimal)>();
                    string queryDetalle = @"
                        SELECT NombreProducto, SUM(Cantidad) AS Cantidad, SUM(Total) AS TotalVendido
                        FROM DetalleVenta
                        GROUP BY NombreProducto
                        ORDER BY TotalVendido DESC";
                    using (SqlConnection con = new SqlConnection(conexion))
                    {
                        SqlCommand cmd = new SqlCommand(queryDetalle, con);
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string producto = reader["NombreProducto"].ToString();
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);
                            decimal total = Convert.ToDecimal(reader["TotalVendido"]);
                            productos.Add(producto, (cantidad, total));
                        }
                    }

                    // Top N y otros
                    int topN = 10;
                    int otrosCantidad = 0;
                    decimal otrosTotal = 0;
                    int contador = 0;

                    foreach (var item in productos)
                    {
                        if (contador < topN)
                        {
                            decimal porcentaje = granTotal > 0 ? (item.Value.Total / granTotal) * 100 : 0;
                            tabla.AddCell(new Phrase(item.Key, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase(item.Value.Cantidad.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase("C$ " + item.Value.Total.ToString("N2"), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase(porcentaje.ToString("N2") + " %", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        }
                        else
                        {
                            otrosCantidad += item.Value.Cantidad;
                            otrosTotal += item.Value.Total;
                        }
                        contador++;
                    }

                    if (otrosTotal > 0)
                    {
                        decimal porcentajeOtros = (otrosTotal / granTotal) * 100;
                        tabla.AddCell(new Phrase("Otros", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        tabla.AddCell(new Phrase(otrosCantidad.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        tabla.AddCell(new Phrase("C$ " + otrosTotal.ToString("N2"), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        tabla.AddCell(new Phrase(porcentajeOtros.ToString("N2") + " %", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                    }

                    doc.Add(tabla);

                    // Totales finales
                    doc.Add(new Paragraph("\n"));
                    Paragraph totalFinal = new Paragraph("TOTAL GENERAL: C$ " + granTotal.ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK))
                    { Alignment = Element.ALIGN_RIGHT };
                    doc.Add(totalFinal);

                    decimal iva = granTotal * 0.15m;
                    Paragraph ivaTxt = new Paragraph("IVA (15%): C$ " + iva.ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK))
                    { Alignment = Element.ALIGN_RIGHT };
                    doc.Add(ivaTxt);

                    Paragraph neto = new Paragraph("TOTAL NETO: C$ " + (granTotal + iva).ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.RED))
                    { Alignment = Element.ALIGN_RIGHT };
                    doc.Add(neto);

                    doc.Close();
                    MessageBox.Show("Informe generado correctamente en PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar informe: " + ex.Message);
            }

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal MDIGerente
            MDIGerente gerenteForm = Application.OpenForms.OfType<MDIGerente>().FirstOrDefault();

            if (gerenteForm != null)
            {
                // Mostrar el formulario principal si estaba minimizado u oculto
                gerenteForm.Show();
                gerenteForm.BringToFront();

                // Cargar el dashboard dentro del panel
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }
            else
            {
                // Si no existe, crearlo y cargar el dashboard
                gerenteForm = new MDIGerente(null);
                gerenteForm.Show();
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }

            // Cerrar el formulario actual
            this.Close();

        }
    }
}

 