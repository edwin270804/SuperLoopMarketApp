using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_2.Frmcaja;

namespace Proyecto_Final_2
{
    public partial class MDIProductos : Form
    {

        
        private int paginaActual = 1;
        private int registrosPorPagina = 10; 
        private int totalPaginas = 1;
        private FlowLayoutPanel flpPagina; 



        public MDIProductos()
        {
            InitializeComponent();
            this.IsMdiContainer = false;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            
            MDIGerente gerenteForm = Application.OpenForms.OfType<MDIGerente>().FirstOrDefault();

            if (gerenteForm != null)
            {
               
                gerenteForm.Show();
                gerenteForm.BringToFront();

               
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }
            else
            {
                
                gerenteForm = new MDIGerente(null);
                gerenteForm.Show();
                gerenteForm.AbrirFormularioEnPanel4(new MDIdashboard());
            }

            
            this.Close();
        }

        private void CargarProductos()
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
                string query = @"
                    SELECT CodigoBarras AS [Codigo de Barras],
                           NombreProducto AS [Nombre Del Producto],
                           Categoria,
                           Precio,
                           Stock,
                           FechaIngreso AS [Fecha de Ingreso]
                    FROM SupermercadoProductos";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                dtCargarproductos = new DataTable();
                da.Fill(dtCargarproductos);

                dgvproductos.DataSource = null;
                dgvproductos.DataSource = dtCargarproductos;

                
                dgvproductos.DefaultCellStyle.ForeColor = Color.Black;
                dgvproductos.DefaultCellStyle.BackColor = Color.White;
                dgvproductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvproductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

            private DataTable dtCargarproductos;

        private void MDIProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            PersonalizarDataGridView(dgvproductos);

            CalcularTotalPaginas();
            MostrarPagina();
            CrearBotonesPaginado();
        }

        private void CalcularTotalPaginas()
        {
            if (dtCargarproductos != null && dtCargarproductos.Rows.Count > 0)
            {
                totalPaginas = (int)Math.Ceiling((double)dtCargarproductos.Rows.Count / registrosPorPagina);
            }
            else
            {
                totalPaginas = 1;
            }
        }

        private void MostrarPagina()
        {
            if (dtCargarproductos == null) return;

            int inicio = (paginaActual - 1) * registrosPorPagina;
            int fin = Math.Min(inicio + registrosPorPagina, dtCargarproductos.Rows.Count);

            DataTable dtPagina = dtCargarproductos.Clone();

            for (int i = inicio; i < fin; i++)
            {
                dtPagina.ImportRow(dtCargarproductos.Rows[i]);
            }

            dgvproductos.DataSource = dtPagina;
        }

        private void CrearBotonesPaginado()
        {
            if (flpPagina3 == null)
            {
                flpPagina3 = new FlowLayoutPanel();
                flpPagina3.Size = new Size(300, 40);
                flpPagina3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                flpPagina3.Location = new Point(this.ClientSize.Width - flpPagina.Width - 20, this.ClientSize.Height - flpPagina.Height - 20);
                flpPagina3.BackColor = Color.Transparent;
                this.Controls.Add(flpPagina);
            }

            flpPagina3.Controls.Clear();

            // Botón Para regresar
            Button btnAnterior = new Button();
            btnAnterior.Text = "<";
            btnAnterior.Width = 40;
            btnAnterior.Height = 30;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.BackColor = Color.White;
            btnAnterior.ForeColor = Color.Black;
            btnAnterior.Enabled = paginaActual > 1;
            btnAnterior.Click += (s, e) =>
            {
                if (paginaActual > 1)
                {
                    paginaActual--;
                    MostrarPagina();
                    CrearBotonesPaginado();
                }
            };
            flpPagina3.Controls.Add(btnAnterior);


            int maxBotones = 3;
            int inicio = Math.Max(1, paginaActual - 1);
            int fin = Math.Min(totalPaginas, inicio + maxBotones - 1);

            for (int i = inicio; i <= fin; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 40;
                btn.Height = 30;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.Black;
                btn.BackColor = (i == paginaActual) ? Color.LightBlue : Color.White;

                int pagina = i;
                btn.Click += (s, e) =>
                {
                    paginaActual = pagina;
                    MostrarPagina();
                    CrearBotonesPaginado();
                };

                flpPagina3.Controls.Add(btn);
            }


            Button btnSiguiente = new Button();
            btnSiguiente.Text = ">";
            btnSiguiente.Width = 40;
            btnSiguiente.Height = 30;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.BackColor = Color.White;
            btnSiguiente.ForeColor = Color.Black;
            btnSiguiente.Enabled = paginaActual < totalPaginas;
            btnSiguiente.Click += (s, e) =>
            {
                if (paginaActual < totalPaginas)
                {
                    paginaActual++;
                    MostrarPagina();
                    CrearBotonesPaginado();
                }
            };
            flpPagina3.Controls.Add(btnSiguiente);
        }

        private void PersonalizarDataGridView(DataGridView dgv)
        {
            
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;

            
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204); 
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
            dgv.ColumnHeadersHeight = 38;

            
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 

          
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);

           
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 32;

            
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

    }

}
