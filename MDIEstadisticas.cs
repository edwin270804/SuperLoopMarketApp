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
    public partial class MDIEstadisticas : Form
    {
        

        public MDIEstadisticas()
        {
            InitializeComponent();

            this.IsMdiContainer = false;
        }

        private void toolback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIEstadisticas_Load(object sender, EventArgs e)
        {

            
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = parametros.cadenaConexion;

            chart1.Series.Clear();
            chart1.Series.Add("Ventas");
            chart1.Series["Ventas"].ChartType = SeriesChartType.Column;
            chart1.Series["Ventas"].IsValueShownAsLabel = true;
            chart1.Series["Ventas"].Font = new Font("Segoe UI", 11, FontStyle.Bold);
            chart1.Series["Ventas"].Palette = ChartColorPalette.BrightPastel;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.BackColor = Color.Transparent;

            string query = @"
SET LANGUAGE Spanish;

SELECT 
    FORMAT(v.Fecha, 'MMMM yyyy') AS Mes, 
    SUM(d.Total) AS TotalVendido
FROM DetalleVenta d
INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
GROUP BY FORMAT(v.Fecha, 'MMMM yyyy')
ORDER BY MIN(v.Fecha);";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string mes = reader["Mes"].ToString();
                        decimal total = Convert.ToDecimal(reader["TotalVendido"]);
                        chart1.Series["Ventas"].Points.AddXY(mes, total);
                    }
                }
            }

            chart1.Dock = DockStyle.Top;
            chart1.Height = 960;
            panel3.Controls.Add(chart1);
        }









        private void btninforme_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime fechaInicio = dtpInicio.Value.Date;
                DateTime fechaFin = dtpFin.Value.Date;

                parametrosconexion parametros = AdministrarConexion.cargar();
                if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
                {
                    MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string connectionString = parametros.cadenaConexion;

                
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "InformeVentas.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear documento PDF
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    
                    Paragraph titulo = new Paragraph("INFORME DE VENTAS\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20, BaseColor.BLACK));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);

                    Paragraph rango = new Paragraph(
                        $"Período: {fechaInicio:dd/MM/yyyy} - {fechaFin:dd/MM/yyyy}\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.BLACK)
                    );
                    rango.Alignment = Element.ALIGN_CENTER;
                    doc.Add(rango);

                    Paragraph fecha = new Paragraph("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n",
                        FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.DARK_GRAY));
                    fecha.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(fecha);

                    
                    PdfPTable tabla = new PdfPTable(4);
                    tabla.WidthPercentage = 100;
                    tabla.SetWidths(new float[] { 40, 20, 20, 20 });

                    // Encabezados
                    tabla.AddCell(new PdfPCell(new Phrase("Producto", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("Cantidad", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("Total Vendido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                    tabla.AddCell(new PdfPCell(new Phrase("% del Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { BackgroundColor = BaseColor.LIGHT_GRAY });

                    decimal granTotal = 0;

                    
                    string queryTotal = @"
                        SELECT SUM(d.Total)
                        FROM DetalleVenta d
                        INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
                        WHERE CAST(v.Fecha AS DATE) BETWEEN @FechaInicio AND @FechaFin";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(queryTotal, con);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        granTotal = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    }

                    
                    string queryDetalle = @"
                        SELECT d.NombreProducto, SUM(d.Cantidad) AS Cantidad, SUM(d.Total) AS TotalVendido
                        FROM DetalleVenta d
                        INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
                        WHERE CAST(v.Fecha AS DATE) BETWEEN @FechaInicio AND @FechaFin
                        GROUP BY d.NombreProducto
                        ORDER BY TotalVendido DESC";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(queryDetalle, con);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string producto = reader["NombreProducto"].ToString();
                            int cantidad = Convert.ToInt32(reader["Cantidad"]);
                            decimal total = Convert.ToDecimal(reader["TotalVendido"]);
                            decimal porcentaje = granTotal > 0 ? (total / granTotal) * 100 : 0;

                            tabla.AddCell(new Phrase(producto, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase(cantidad.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase("C$ " + total.ToString("N2"), FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                            tabla.AddCell(new Phrase(porcentaje.ToString("N2") + " %", FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        }
                    }

                    doc.Add(tabla);

                    // ---- Totales ----
                    doc.Add(new Paragraph("\n"));
                    Paragraph totalFinal = new Paragraph("TOTAL GENERAL: C$ " + granTotal.ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK));
                    totalFinal.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(totalFinal);

                    // IVA ejemplo (15%)
                    decimal iva = granTotal * 0.15m;
                    Paragraph ivaTxt = new Paragraph("IVA (15%): C$ " + iva.ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK));
                    ivaTxt.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(ivaTxt);

                    Paragraph neto = new Paragraph("TOTAL NETO: C$ " + (granTotal + iva).ToString("N2"),
                        FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.RED));
                    neto.Alignment = Element.ALIGN_RIGHT;
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
