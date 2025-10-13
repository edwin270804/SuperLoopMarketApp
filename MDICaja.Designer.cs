namespace Proyecto_Final_2
{
    partial class Frmcaja
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnfactura = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnsalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnCobrar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvcarrito = new System.Windows.Forms.DataGridView();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblvuelto = new System.Windows.Forms.Label();
            this.lblcarrito = new System.Windows.Forms.Label();
            this.txtcodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCajeroName = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfactura
            // 
            this.btnfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfactura.BorderRadius = 8;
            this.btnfactura.CheckedState.Parent = this.btnfactura;
            this.btnfactura.CustomImages.Parent = this.btnfactura;
            this.btnfactura.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactura.ForeColor = System.Drawing.Color.White;
            this.btnfactura.HoverState.Parent = this.btnfactura;
            this.btnfactura.Image = global::Proyecto_Final_2.Properties.Resources.impresora;
            this.btnfactura.Location = new System.Drawing.Point(25, 21);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.ShadowDecoration.Parent = this.btnfactura;
            this.btnfactura.Size = new System.Drawing.Size(385, 109);
            this.btnfactura.TabIndex = 5;
            this.btnfactura.Text = "Imprimir Factura";
            this.toolTip.SetToolTip(this.btnfactura, "Imprime una factura");
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.guna2GroupBox2);
            this.panel2.Controls.Add(this.dgvcarrito);
            this.panel2.Controls.Add(this.txtRecibido);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.lblcarrito);
            this.panel2.Controls.Add(this.txtcodigo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 979);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderRadius = 9;
            this.guna2GroupBox2.BorderThickness = 3;
            this.guna2GroupBox2.Controls.Add(this.btnsalir);
            this.guna2GroupBox2.Controls.Add(this.btnfactura);
            this.guna2GroupBox2.Controls.Add(this.btnCobrar);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(811, 562);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(422, 393);
            this.guna2GroupBox2.TabIndex = 16;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.BorderRadius = 8;
            this.btnsalir.CheckedState.Parent = this.btnsalir;
            this.btnsalir.CustomImages.Parent = this.btnsalir;
            this.btnsalir.FillColor = System.Drawing.Color.Red;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.HoverState.Parent = this.btnsalir;
            this.btnsalir.Image = global::Proyecto_Final_2.Properties.Resources.icon_salida_32;
            this.btnsalir.Location = new System.Drawing.Point(25, 267);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.ShadowDecoration.Parent = this.btnsalir;
            this.btnsalir.Size = new System.Drawing.Size(385, 109);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.BorderRadius = 8;
            this.btnCobrar.CheckedState.Parent = this.btnCobrar;
            this.btnCobrar.CustomImages.Parent = this.btnCobrar;
            this.btnCobrar.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.HoverState.Parent = this.btnCobrar;
            this.btnCobrar.Image = global::Proyecto_Final_2.Properties.Resources.recibo;
            this.btnCobrar.Location = new System.Drawing.Point(25, 136);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.ShadowDecoration.Parent = this.btnCobrar;
            this.btnCobrar.Size = new System.Drawing.Size(385, 109);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // dgvcarrito
            // 
            this.dgvcarrito.AllowUserToAddRows = false;
            this.dgvcarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcarrito.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcarrito.Location = new System.Drawing.Point(14, 161);
            this.dgvcarrito.Name = "dgvcarrito";
            this.dgvcarrito.RowHeadersVisible = false;
            this.dgvcarrito.RowHeadersWidth = 51;
            this.dgvcarrito.RowTemplate.Height = 24;
            this.dgvcarrito.Size = new System.Drawing.Size(1219, 385);
            this.dgvcarrito.TabIndex = 15;
            // 
            // txtRecibido
            // 
            this.txtRecibido.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecibido.ForeColor = System.Drawing.Color.Transparent;
            this.txtRecibido.Location = new System.Drawing.Point(1239, 925);
            this.txtRecibido.Name = "txtRecibido";
            this.txtRecibido.Size = new System.Drawing.Size(10, 30);
            this.txtRecibido.TabIndex = 13;
            this.txtRecibido.Visible = false;
            this.txtRecibido.TextChanged += new System.EventHandler(this.txtRecibido_TextChanged);
            this.txtRecibido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecibido_KeyDown_1);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 9;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.lblsubtotal);
            this.guna2GroupBox1.Controls.Add(this.lbliva);
            this.guna2GroupBox1.Controls.Add(this.lbltotal);
            this.guna2GroupBox1.Controls.Add(this.lblvuelto);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 562);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(793, 393);
            this.guna2GroupBox1.TabIndex = 14;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblsubtotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(14, 21);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(370, 31);
            this.lblsubtotal.TabIndex = 5;
            this.lblsubtotal.Text = "Subtotal:";
            // 
            // lbliva
            // 
            this.lbliva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbliva.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(14, 81);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(370, 31);
            this.lbliva.TabIndex = 6;
            this.lbliva.Text = "IVA (15%):";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(14, 136);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(370, 31);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total:";
            // 
            // lblvuelto
            // 
            this.lblvuelto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblvuelto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvuelto.Location = new System.Drawing.Point(14, 185);
            this.lblvuelto.Name = "lblvuelto";
            this.lblvuelto.Size = new System.Drawing.Size(350, 148);
            this.lblvuelto.TabIndex = 9;
            this.lblvuelto.Text = "Cambio:";
            // 
            // lblcarrito
            // 
            this.lblcarrito.AutoSize = true;
            this.lblcarrito.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblcarrito.Location = new System.Drawing.Point(3, 101);
            this.lblcarrito.Name = "lblcarrito";
            this.lblcarrito.Size = new System.Drawing.Size(320, 45);
            this.lblcarrito.TabIndex = 10;
            this.lblcarrito.Text = "Carrito de Compras";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderColor = System.Drawing.Color.Black;
            this.txtcodigo.BorderRadius = 9;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.DefaultText = "";
            this.txtcodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.DisabledState.Parent = this.txtcodigo;
            this.txtcodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.FocusedState.Parent = this.txtcodigo;
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.HoverState.Parent = this.txtcodigo;
            this.txtcodigo.IconLeft = global::Proyecto_Final_2.Properties.Resources.icons8_search_244;
            this.txtcodigo.Location = new System.Drawing.Point(9, 31);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.PlaceholderText = "Escanea o escribe codigo de barras..";
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.ShadowDecoration.Parent = this.txtcodigo;
            this.txtcodigo.Size = new System.Drawing.Size(1542, 63);
            this.txtcodigo.TabIndex = 0;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEncabezado.Controls.Add(this.pictureBox1);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Controls.Add(this.lblCajeroName);
            this.panelEncabezado.Controls.Add(this.lbltitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1262, 129);
            this.panelEncabezado.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Proyecto_Final_2.Properties.Resources.icon_user_32;
            this.pictureBox1.Location = new System.Drawing.Point(836, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loop Market";
            // 
            // lblCajeroName
            // 
            this.lblCajeroName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajeroName.AutoSize = true;
            this.lblCajeroName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajeroName.Location = new System.Drawing.Point(886, 38);
            this.lblCajeroName.Name = "lblCajeroName";
            this.lblCajeroName.Size = new System.Drawing.Size(88, 31);
            this.lblCajeroName.TabIndex = 0;
            this.lblCajeroName.Text = "Cajero:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.Image = global::Proyecto_Final_2.Properties.Resources.carrito_de_compras__3_2;
            this.lbltitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltitulo.Location = new System.Drawing.Point(24, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(388, 81);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "       Caja Registradora";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Frmcaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 1108);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEncabezado);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmcaja";
            this.Text = "MDICaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmcaja_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmcaja_KeyDown_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcarrito)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCajeroName;
        private System.Windows.Forms.TextBox txtRecibido;
        private Guna.UI2.WinForms.Guna2Button btnfactura;
        private Guna.UI2.WinForms.Guna2Button btnCobrar;
        private System.Windows.Forms.Label lblcarrito;
        private System.Windows.Forms.Label lblvuelto;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblsubtotal;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel panelEncabezado;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvcarrito;
        private Guna.UI2.WinForms.Guna2Button btnsalir;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
    }
}



