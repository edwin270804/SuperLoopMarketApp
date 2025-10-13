using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Final_2
{
    public partial class MDIdashboard : Form
    {
        

        public MDIdashboard()
        {
            InitializeComponent();

            this.IsMdiContainer = false;
        }

        private void MDIdashboard_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Ventas últimos 7 días");
            chart1.Titles[0].Font = new Font("Segoe UI Semibold", 16, FontStyle.Regular);

            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Pie;
            serie.IsValueShownAsLabel = true;

            
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string conexion = parametros.cadenaConexion;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                
                string query = @"
            SET LANGUAGE Spanish;

            SELECT DATENAME(WEEKDAY, v.Fecha) AS DiaSemana,
                   SUM(d.Total) AS TotalDia
            FROM DetalleVenta d
            INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
            WHERE v.Fecha >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE))
            GROUP BY DATENAME(WEEKDAY, v.Fecha)
            ORDER BY MIN(v.Fecha) ASC;";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dia = reader["DiaSemana"].ToString();
                    decimal total = Convert.ToDecimal(reader["TotalDia"]);
                    serie.Points.AddXY(dia, total);
                }
            }

            chart1.Series.Add(serie);

            CargarDetalleVentas();
            CargarEstadisticasSemanal();


        }

        private void CargarDetalleVentas()
        {
            
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string conexion = parametros.cadenaConexion;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = @"
            SELECT 
                CAST(v.Fecha AS DATE) AS Fecha,
                d.NombreProducto AS [Nombre Del Producto],
                d.Cantidad,
                d.Precio,
                d.Total
            FROM DetalleVenta d
            INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
            WHERE v.Fecha >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE))
            ORDER BY v.Fecha DESC;";

                SqlDataAdapter data = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                data.Fill(dt);

                dgvdetalle.AutoGenerateColumns = false;
                dgvdetalle.Columns.Clear();

                
                DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
                colFecha.DataPropertyName = "Fecha";
                colFecha.HeaderText = "Fecha";
                colFecha.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colFecha.FillWeight = 15;
                dgvdetalle.Columns.Add(colFecha);

                DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
                colNombre.DataPropertyName = "Nombre Del Producto";
                colNombre.HeaderText = "Nombre del Producto";
                colNombre.FillWeight = 18;
                dgvdetalle.Columns.Add(colNombre);

                DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
                colCantidad.DataPropertyName = "Cantidad";
                colCantidad.HeaderText = "Cantidad";
                colCantidad.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                colCantidad.FillWeight = 10;
                dgvdetalle.Columns.Add(colCantidad);

                DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
                colPrecio.DataPropertyName = "Precio";
                colPrecio.HeaderText = "Precio";
                colPrecio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colPrecio.FillWeight = 12;
                dgvdetalle.Columns.Add(colPrecio);

                DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
                colTotal.DataPropertyName = "Total";
                colTotal.HeaderText = "Total";
                colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                colTotal.FillWeight = 13;
                dgvdetalle.Columns.Add(colTotal);

                dgvdetalle.DataSource = dt;

                // Estilos del DGV
                dgvdetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvdetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvdetalle.AllowUserToResizeColumns = false;
                dgvdetalle.DefaultCellStyle.ForeColor = Color.Black;
                dgvdetalle.DefaultCellStyle.BackColor = Color.White;
                dgvdetalle.BackgroundColor = Color.White;
                dgvdetalle.BorderStyle = BorderStyle.None;
                dgvdetalle.EnableHeadersVisualStyles = false;
                dgvdetalle.GridColor = Color.LightGray;
                dgvdetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
                dgvdetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvdetalle.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                dgvdetalle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvdetalle.ColumnHeadersHeight = 40;
                dgvdetalle.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgvdetalle.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230);
                dgvdetalle.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvdetalle.RowTemplate.Height = 35;
                dgvdetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            }
        }
        private void CargarEstadisticasSemanal()
        {
            
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string conexion = parametros.cadenaConexion;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string queryTotalVentas = @"
            SELECT ISNULL(SUM(d.Total), 0) 
            FROM DetalleVenta d
            INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
            WHERE v.Fecha >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE));";

                SqlCommand cmdTotalVentas = new SqlCommand(queryTotalVentas, conn);
                decimal totalVentas = (decimal)cmdTotalVentas.ExecuteScalar();
                lblTotalVentas.Text = $"C${totalVentas:N2}";

                string queryCantidadProductos = @"
            SELECT ISNULL(SUM(d.Cantidad), 0) 
            FROM DetalleVenta d
            INNER JOIN Ventas v ON d.IdVenta = v.IdVenta
            WHERE v.Fecha >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE));";

                SqlCommand cmdCantidad = new SqlCommand(queryCantidadProductos, conn);
                int totalProductos = (int)cmdCantidad.ExecuteScalar();
                lblCantidadProductos.Text = totalProductos.ToString();
            }
        }

       

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
