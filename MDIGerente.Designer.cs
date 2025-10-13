namespace Proyecto_Final_2
{
    partial class MDIGerente
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
            this.icondetalle = new FontAwesome.Sharp.IconButton();
            this.iconventas = new FontAwesome.Sharp.IconButton();
            this.iconProductos = new FontAwesome.Sharp.IconButton();
            this.icontrabajadores = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblgerente = new System.Windows.Forms.Label();
            this.lblcabeza = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolestadisticas = new FontAwesome.Sharp.IconDropDownButton();
            this.gráficoDeVentasMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.productosMasVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsalir = new FontAwesome.Sharp.IconToolStripButton();
            this.paneldinamico = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // icondetalle
            // 
            this.icondetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icondetalle.FlatAppearance.BorderSize = 0;
            this.icondetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.icondetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icondetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icondetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icondetalle.IconChar = FontAwesome.Sharp.IconChar.History;
            this.icondetalle.IconColor = System.Drawing.Color.WhiteSmoke;
            this.icondetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icondetalle.IconSize = 26;
            this.icondetalle.Location = new System.Drawing.Point(6, 342);
            this.icondetalle.Name = "icondetalle";
            this.icondetalle.Size = new System.Drawing.Size(189, 61);
            this.icondetalle.TabIndex = 8;
            this.icondetalle.Text = "Historial ";
            this.icondetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.icondetalle, "Historial de Productos Vendidos");
            this.icondetalle.UseVisualStyleBackColor = true;
            this.icondetalle.Click += new System.EventHandler(this.icondetalle_Click);
            // 
            // iconventas
            // 
            this.iconventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconventas.FlatAppearance.BorderSize = 0;
            this.iconventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconventas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconventas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconventas.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconventas.IconSize = 26;
            this.iconventas.Location = new System.Drawing.Point(6, 275);
            this.iconventas.Name = "iconventas";
            this.iconventas.Size = new System.Drawing.Size(189, 61);
            this.iconventas.TabIndex = 7;
            this.iconventas.Text = "Ventas";
            this.iconventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.iconventas, "Informe de Ventas Realizadas");
            this.iconventas.UseVisualStyleBackColor = true;
            this.iconventas.Click += new System.EventHandler(this.iconventas_Click);
            // 
            // iconProductos
            // 
            this.iconProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconProductos.FlatAppearance.BorderSize = 0;
            this.iconProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconProductos.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconProductos.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProductos.IconSize = 26;
            this.iconProductos.Location = new System.Drawing.Point(6, 208);
            this.iconProductos.Name = "iconProductos";
            this.iconProductos.Size = new System.Drawing.Size(189, 61);
            this.iconProductos.TabIndex = 6;
            this.iconProductos.Text = "Productos";
            this.iconProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.iconProductos, "Productos Disponible ");
            this.iconProductos.UseVisualStyleBackColor = true;
            this.iconProductos.Click += new System.EventHandler(this.iconProductos_Click);
            // 
            // icontrabajadores
            // 
            this.icontrabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icontrabajadores.FlatAppearance.BorderSize = 0;
            this.icontrabajadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.icontrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icontrabajadores.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icontrabajadores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icontrabajadores.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icontrabajadores.IconColor = System.Drawing.Color.WhiteSmoke;
            this.icontrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icontrabajadores.IconSize = 26;
            this.icontrabajadores.Location = new System.Drawing.Point(6, 141);
            this.icontrabajadores.Name = "icontrabajadores";
            this.icontrabajadores.Size = new System.Drawing.Size(189, 61);
            this.icontrabajadores.TabIndex = 4;
            this.icontrabajadores.Text = "Trabajadores";
            this.icontrabajadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.icontrabajadores, "Registro De Trabajadores");
            this.icontrabajadores.UseVisualStyleBackColor = true;
            this.icontrabajadores.Click += new System.EventHandler(this.icontrabajadores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblgerente);
            this.panel1.Controls.Add(this.lblcabeza);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Proyecto_Final_2.Properties.Resources.icon_user_24;
            this.pictureBox1.Location = new System.Drawing.Point(1021, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblgerente
            // 
            this.lblgerente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgerente.AutoSize = true;
            this.lblgerente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgerente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblgerente.Location = new System.Drawing.Point(1055, 42);
            this.lblgerente.Name = "lblgerente";
            this.lblgerente.Size = new System.Drawing.Size(205, 28);
            this.lblgerente.TabIndex = 1;
            this.lblgerente.Text = "Nombre del Gerente:";
            // 
            // lblcabeza
            // 
            this.lblcabeza.AutoSize = true;
            this.lblcabeza.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblcabeza.Location = new System.Drawing.Point(12, 24);
            this.lblcabeza.Name = "lblcabeza";
            this.lblcabeza.Size = new System.Drawing.Size(486, 45);
            this.lblcabeza.TabIndex = 0;
            this.lblcabeza.Text = "Información del Supermercado";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.icondetalle);
            this.panel2.Controls.Add(this.iconventas);
            this.panel2.Controls.Add(this.iconProductos);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.icontrabajadores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 821);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(1, 367);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(3, 48);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(1, 315);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 62);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(1, 259);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(3, 62);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(1, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(3, 62);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(1, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 62);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_2.Properties.Resources.Imagen_de_WhatsApp_2025_09_05_a_las_11_38_25_46b497bc;
            this.pictureBox2.Location = new System.Drawing.Point(31, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolestadisticas,
            this.toolsalir});
            this.toolStrip1.Location = new System.Drawing.Point(201, 100);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1273, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolestadisticas
            // 
            this.toolestadisticas.AutoSize = false;
            this.toolestadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoDeVentasMensualesToolStripMenuItem,
            this.toolStripSeparator1,
            this.productosMasVendidosToolStripMenuItem});
            this.toolestadisticas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolestadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.toolestadisticas.IconColor = System.Drawing.Color.Black;
            this.toolestadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toolestadisticas.IconSize = 200;
            this.toolestadisticas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolestadisticas.Name = "toolestadisticas";
            this.toolestadisticas.Size = new System.Drawing.Size(150, 24);
            this.toolestadisticas.Text = "Estadisticas";
            this.toolestadisticas.ToolTipText = "Estadisticas de Ventas";
            // 
            // gráficoDeVentasMensualesToolStripMenuItem
            // 
            this.gráficoDeVentasMensualesToolStripMenuItem.Name = "gráficoDeVentasMensualesToolStripMenuItem";
            this.gráficoDeVentasMensualesToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.gráficoDeVentasMensualesToolStripMenuItem.Text = "Gráfico de Ventas Mensuales";
            this.gráficoDeVentasMensualesToolStripMenuItem.Click += new System.EventHandler(this.gráficoDeVentasMensualesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // productosMasVendidosToolStripMenuItem
            // 
            this.productosMasVendidosToolStripMenuItem.Name = "productosMasVendidosToolStripMenuItem";
            this.productosMasVendidosToolStripMenuItem.Size = new System.Drawing.Size(315, 28);
            this.productosMasVendidosToolStripMenuItem.Text = "Productos mas vendidos";
            this.productosMasVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosMasVendidosToolStripMenuItem_Click);
            // 
            // toolsalir
            // 
            this.toolsalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.toolsalir.IconColor = System.Drawing.Color.Black;
            this.toolsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toolsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsalir.Name = "toolsalir";
            this.toolsalir.Size = new System.Drawing.Size(120, 24);
            this.toolsalir.Text = "Cerrar Sesion";
            this.toolsalir.Click += new System.EventHandler(this.toolsalir_Click);
            // 
            // paneldinamico
            // 
            this.paneldinamico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneldinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldinamico.Location = new System.Drawing.Point(201, 127);
            this.paneldinamico.Name = "paneldinamico";
            this.paneldinamico.Size = new System.Drawing.Size(1273, 794);
            this.paneldinamico.TabIndex = 5;
            this.paneldinamico.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldinamico_Paint);
            // 
            // MDIGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 921);
            this.Controls.Add(this.paneldinamico);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIGerente";
            this.Text = "MDIGerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcabeza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblgerente;
        private FontAwesome.Sharp.IconButton icontrabajadores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton icondetalle;
        private FontAwesome.Sharp.IconButton iconventas;
        private FontAwesome.Sharp.IconButton iconProductos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconDropDownButton toolestadisticas;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeVentasMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem productosMasVendidosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel paneldinamico;
        private FontAwesome.Sharp.IconToolStripButton toolsalir;
    }
}



