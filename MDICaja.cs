using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_2.Frmlogincs;

namespace Proyecto_Final_2
{
    public partial class Frmcaja : Form
    {


        public Frmcaja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frmcaja_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.Sizable;  
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ControlBox = true;
            this.Text = "Caja - Loop Market"; 

            this.KeyPreview = true;

            dgvcarrito.CellValueChanged += Dgvcarrito_CellValueChanged;
            dgvcarrito.CellEndEdit += Dgvcarrito_CellEndEdit;
            dgvcarrito.UserDeletedRow += Dgvcarrito_UserDeletedRow;   
            dgvcarrito.RowsRemoved += Dgvcarrito_RowsRemoved;

            dgvcarrito.EditMode = DataGridViewEditMode.EditOnEnter;
            PersonalizarDataGridView(dgvcarrito);
            FormatearColumnasConCordoba();

            RedondearDataGridView(dgvcarrito, 1);



        }


        private decimal ultimoSubtotal;
        private decimal ultimoIVA;
        private decimal ultimoTotal;
        private decimal ultimoRecibido;
        private decimal ultimoVuelto;
        private List<Frmpago.ProductoVenta> ultimaVenta;

        public Frmcaja(string nombreCajero)
        {
            InitializeComponent();

            lblCajeroName.Text = $"Cajero:\n{nombreCajero} ";
           

            // Configurar DataGridView
            dgvcarrito.Columns.Add("Codigo", "Código");
            dgvcarrito.Columns["Codigo"].Width = 350;


            dgvcarrito.Columns.Add("Producto", "Producto");
            dgvcarrito.Columns["Producto"].Width = 350;

            dgvcarrito.Columns.Add("Precio", "Precio");
            dgvcarrito.Columns["Precio"].Width = 350;

            dgvcarrito.Columns.Add("Cantidad", "Cantidad");
            dgvcarrito.Columns["Cantidad"].Width = 350;

            dgvcarrito.Columns.Add("Total", "Total");
            dgvcarrito.Columns["Total"].Width = 420;

            dgvcarrito.Columns[0].ReadOnly = true;
            dgvcarrito.Columns[1].ReadOnly = true;
            dgvcarrito.Columns[2].ReadOnly = true;
            dgvcarrito.Columns["Cantidad"].ReadOnly = false;
            dgvcarrito.Columns[4].ReadOnly = true;






            // Capturar Teclas
            txtcodigo.KeyDown -= txtcodigo_KeyDown; 
            txtcodigo.KeyDown += txtcodigo_KeyDown;
            this.AcceptButton = null; 
            txtcodigo.Focus();


            // Eventos
           txtcodigo.KeyDown += txtcodigo_KeyDown;

             




        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Deseas cerrar la sesión?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

   

        private Producto BuscarProducto(string codigo)
        {
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            using (SqlConnection conn = new SqlConnection(parametros.cadenaConexion))
            {
                conn.Open();
                string query = "SELECT CodigoBarras, NombreProducto, Precio FROM SupermercadoProductos WHERE CodigoBarras = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Producto
                            {
                                Codigo = reader["CodigoBarras"].ToString(),
                                Nombre = reader["NombreProducto"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void ActualizarTotales()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvcarrito.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            decimal iva = subtotal * ivaPorcentaje;
            decimal total = subtotal + iva;

            CultureInfo nicaragua = new CultureInfo("es-NI");

            lblsubtotal.Text = $"Subtotal: {subtotal.ToString("C", nicaragua)}";
            lbliva.Text = $"IVA (15%): {iva.ToString("C", nicaragua)}";
            lbltotal.Text = $"Total: {total.ToString("C", nicaragua)}";


        }



        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvcarrito.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            // Calcular subtotal, IVA y total
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dgvcarrito.Rows)
            {
                if (!row.IsNewRow)
                    subtotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            decimal iva = subtotal * ivaPorcentaje;
            decimal total = subtotal + iva;

            // Preparar lista de productos
            List<Frmpago.ProductoVenta> listaProductos = new List<Frmpago.ProductoVenta>();
            foreach (DataGridViewRow row in dgvcarrito.Rows)
            {
                if (!row.IsNewRow)
                {
                    listaProductos.Add(new Frmpago.ProductoVenta
                    {
                        Codigo = row.Cells["Codigo"].Value.ToString(),
                        Nombre = row.Cells["Producto"].Value.ToString(),
                        Precio = Convert.ToDecimal(row.Cells["Precio"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Total = Convert.ToDecimal(row.Cells["Total"].Value)
                    });
                }
            }

            // Crear instancia de Frmpago
            Frmpago frmPago = new Frmpago(total)
            {
                Productos = listaProductos
            };

            // Mostrar con capa oscura
            MostrarModal.MostrarConCapa(this, frmPago);

            // Verificar si se pagó
            if (frmPago.Pagado)
            {
                decimal recibido = frmPago.DineroRecibido;
                decimal cambio = frmPago.Cambio;

                CultureInfo nicaragua = new CultureInfo("es-NI");
                lblvuelto.Text = $"Vuelto: {cambio.ToString("C", nicaragua)}";
                txtRecibido.Text = recibido.ToString();

                // Guardar últimos valores para factura manual
                ultimoSubtotal = subtotal;
                ultimoIVA = iva;
                ultimoTotal = total;
                ultimoRecibido = recibido;
                ultimoVuelto = cambio;
                ultimaVenta = listaProductos;

                // Registrar venta en BD
                RegistrarVenta(listaProductos, subtotal, iva, total, recibido, cambio);

                // Limpiar carrito
                dgvcarrito.Rows.Clear();
                ActualizarTotales();
            }
        }

        private void RegistrarVenta(List<Frmpago.ProductoVenta> productos, decimal subtotal, decimal iva, decimal total, decimal recibido, decimal cambio)
        {
            parametrosconexion parametros = AdministrarConexion.cargar();
            if (string.IsNullOrWhiteSpace(parametros.servidor) || string.IsNullOrWhiteSpace(parametros.baseDatos))
            {
                MessageBox.Show("No hay una conexión configurada. Configure la conexión primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(parametros.cadenaConexion))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string insertVenta = @"INSERT INTO Ventas (Idtrabajor, Subtotal, IVA, Total, Recibido, Vuelto) 
                               VALUES (@Idtrabajor, @Subtotal, @IVA, @Total, @Recibido, @Vuelto);
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdVenta = new SqlCommand(insertVenta, con, trans);
                    cmdVenta.Parameters.AddWithValue("@Idtrabajor", Variables.idTrabajador);
                    cmdVenta.Parameters.AddWithValue("@Subtotal", subtotal);
                    cmdVenta.Parameters.AddWithValue("@IVA", iva);
                    cmdVenta.Parameters.AddWithValue("@Total", total);
                    cmdVenta.Parameters.AddWithValue("@Recibido", recibido);
                    cmdVenta.Parameters.AddWithValue("@Vuelto", cambio);

                    int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                    foreach (var prod in productos)
                    {
                        string insertDetalle = @"INSERT INTO DetalleVenta (IdVenta, NombreProducto, Cantidad, Precio, Total) 
                                     VALUES (@IdVenta, @NombreProducto, @Cantidad, @Precio, @Total)";
                        SqlCommand cmdDetalle = new SqlCommand(insertDetalle, con, trans);
                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@NombreProducto", prod.Nombre);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", prod.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@Precio", prod.Precio);
                        cmdDetalle.Parameters.AddWithValue("@Total", prod.Total);
                        cmdDetalle.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("¡Venta realizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Clase auxiliar para productos
        public class Producto
        {

            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

        }

        private void btncobrar_Click_1(object sender, EventArgs e)
        {
         
        }

        private decimal ivaPorcentaje = 0.15m;




        private void GenerarFacturaPDF(string nombreCajero, DataGridView dgv, decimal subtotal, decimal iva, decimal total, decimal recibido, decimal vuelto)
        {
            if (ultimaVenta == null || ultimaVenta.Count == 0)
                return; 

            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Factura.pdf");
                rutaFactura = ruta;

                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                doc.Open();

                // Título
                string arialPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                FontFactory.Register(arialPath, "Arial");
                Paragraph titulo = new Paragraph("FACTURA DE VENTA", FontFactory.GetFont("Arial", 18));
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);

                doc.Add(new Paragraph($"Cajero: {nombreCajero}"));
                doc.Add(new Paragraph($"Fecha: {DateTime.Now}"));
                doc.Add(new Paragraph("------------------------------------------------------"));

                // Tabla de productos
                PdfPTable tabla = new PdfPTable(5); 
                tabla.WidthPercentage = 100;

                // Encabezados
                tabla.AddCell("Código");
                tabla.AddCell("Producto");
                tabla.AddCell("Precio");
                tabla.AddCell("Cantidad");
                tabla.AddCell("Total");

                
                foreach (var prod in ultimaVenta)
                {
                    tabla.AddCell(prod.Codigo);
                    tabla.AddCell(prod.Nombre);
                    tabla.AddCell(prod.Precio.ToString("C"));
                    tabla.AddCell(prod.Cantidad.ToString());
                    tabla.AddCell(prod.Total.ToString("C"));
                }

                doc.Add(tabla);

                doc.Add(new Paragraph("------------------------------------------------------"));
                doc.Add(new Paragraph($"Subtotal: {subtotal:C}"));
                doc.Add(new Paragraph($"IVA (15%): {iva:C}"));
                doc.Add(new Paragraph($"Total: {total:C}"));
                doc.Add(new Paragraph($"Recibido: {recibido:C}"));
                doc.Add(new Paragraph($"Vuelto: {vuelto:C}"));

                doc.Close();

                //MessageBox.Show("Factura generada correctamente en el escritorio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }

        private void btnfactura_Click(object sender, EventArgs e)
        { 

        }

        private string rutaFactura; 


        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigo = txtcodigo.Text.Trim();
                if (string.IsNullOrEmpty(codigo))
                    return;

                var producto = BuscarProducto(codigo);
                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    txtcodigo.Clear();
                    return;
                }

                bool encontrado = false;

               
                foreach (DataGridViewRow row in dgvcarrito.Rows)
                {
                    if (row.Cells["Codigo"].Value?.ToString() == producto.Codigo)
                    {
                        int cantActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        cantActual++;
                        row.Cells["Cantidad"].Value = cantActual;
                        row.Cells["Total"].Value = producto.Precio * cantActual;
                        encontrado = true;
                        break;
                    }
                }

               
                if (!encontrado)
                {
                    int cantidad = 1;
                    decimal total = producto.Precio * cantidad;
                    dgvcarrito.Rows.Add(producto.Codigo, producto.Nombre, producto.Precio, cantidad, total);
                }

               
                ActualizarTotales();

                
                txtcodigo.Clear();
                txtcodigo.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void FrmCaja_KeyDown(object sender, KeyEventArgs e)
        {
          
          

        }

        private void btnfactura_Click_1(object sender, EventArgs e)
        {
            if (ultimaVenta == null || ultimaVenta.Count == 0)
            {
                MessageBox.Show("Primero debe realizar una venta para generar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Genera la factura PDF
            GenerarFacturaPDF(lblCajeroName.Text, dgvcarrito, ultimoSubtotal, ultimoIVA, ultimoTotal, ultimoRecibido, ultimoVuelto);

            // Guardar la ruta para poder abrirla
            rutaFactura = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Factura.pdf");

            // Abrir el PDF
            if (File.Exists(rutaFactura))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = rutaFactura,
                    UseShellExecute = true
                });
            }

            CultureInfo nicaragua = new CultureInfo("es-NI");
            lblvuelto.Text = $"Vuelto: {0m.ToString("C", nicaragua)}";
            
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRecibido_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCobrar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnAgregar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void nudcantidad_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void nudcantidad_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void txtRecibido_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nudcantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Deseas cerrar la sesión?",
       "Confirmación",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
       );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frmcaja_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                btnfactura.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.C)
            {
                btnCobrar.PerformClick();
                e.Handled = true;
            }
        }

        private void Dgvcarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvcarrito.Columns["Cantidad"].Index)
            {
                var row = dgvcarrito.Rows[e.RowIndex];

                if (decimal.TryParse(row.Cells["Cantidad"].Value?.ToString(), out decimal cantidad) &&
                    decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out decimal precio))
                {
                    row.Cells["Total"].Value = cantidad * precio;
                    ActualizarTotales(); 
                }
            }
        }

        
        private void Dgvcarrito_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvcarrito.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void RedondearDataGridView(DataGridView dgv, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(dgv.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(dgv.Width - radio, dgv.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, dgv.Height - radio, radio, radio, 90, 90);
            path.CloseFigure();
            dgv.Region = new Region(path);
        }

        private void Dgvcarrito_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ActualizarTotales();
        }

        private void Dgvcarrito_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarTotales();
        }

        private void PersonalizarDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.GridColor = Color.LightGray;

            // Encabezados
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 🔹 Centra encabezados
            dgv.ColumnHeadersHeight = 35;
            dgv.EnableHeadersVisualStyles = false;

            // Celdas
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 🔹 Centra contenido

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowTemplate.Height = 30;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }


        private void FormatearColumnasConCordoba()
        {
            CultureInfo nicaragua = new CultureInfo("es-NI");

            // Alinear a la derecha
            dgvcarrito.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvcarrito.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvcarrito.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formato de moneda con símbolo de córdoba
            dgvcarrito.Columns["Precio"].DefaultCellStyle.FormatProvider = nicaragua;
            dgvcarrito.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvcarrito.Columns["Total"].DefaultCellStyle.FormatProvider = nicaragua;
            dgvcarrito.Columns["Total"].DefaultCellStyle.Format = "C2";
        }





    }
}

