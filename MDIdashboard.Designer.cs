namespace Proyecto_Final_2
{
    partial class MDIdashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuprincipal = new System.Windows.Forms.Panel();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox7 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox8 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuprincipal.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox7.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox8.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuprincipal
            // 
            this.menuprincipal.Controls.Add(this.guna2GroupBox4);
            this.menuprincipal.Controls.Add(this.guna2GroupBox3);
            this.menuprincipal.Controls.Add(this.guna2GroupBox2);
            this.menuprincipal.Controls.Add(this.guna2GroupBox1);
            this.menuprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuprincipal.Location = new System.Drawing.Point(0, 0);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Size = new System.Drawing.Size(1237, 786);
            this.menuprincipal.TabIndex = 4;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox4.BorderRadius = 15;
            this.guna2GroupBox4.BorderThickness = 2;
            this.guna2GroupBox4.Controls.Add(this.label1);
            this.guna2GroupBox4.Controls.Add(this.dgvdetalle);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(12, 15);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.ShadowDecoration.Parent = this.guna2GroupBox4;
            this.guna2GroupBox4.Size = new System.Drawing.Size(595, 759);
            this.guna2GroupBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-140, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas de la ultima semana";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvdetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Location = new System.Drawing.Point(28, 75);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.RowHeadersWidth = 51;
            this.dgvdetalle.RowTemplate.Height = 24;
            this.dgvdetalle.Size = new System.Drawing.Size(536, 648);
            this.dgvdetalle.TabIndex = 0;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.BorderRadius = 15;
            this.guna2GroupBox3.BorderThickness = 2;
            this.guna2GroupBox3.Controls.Add(this.guna2GroupBox7);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(626, 15);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(599, 175);
            this.guna2GroupBox3.TabIndex = 2;
            // 
            // guna2GroupBox7
            // 
            this.guna2GroupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox7.BorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox7.BorderRadius = 4;
            this.guna2GroupBox7.BorderThickness = 2;
            this.guna2GroupBox7.Controls.Add(this.guna2GroupBox5);
            this.guna2GroupBox7.Controls.Add(this.label2);
            this.guna2GroupBox7.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox7.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox7.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox7.Location = new System.Drawing.Point(18, 17);
            this.guna2GroupBox7.Name = "guna2GroupBox7";
            this.guna2GroupBox7.ShadowDecoration.Parent = this.guna2GroupBox7;
            this.guna2GroupBox7.Size = new System.Drawing.Size(564, 143);
            this.guna2GroupBox7.TabIndex = 3;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox5.BorderRadius = 4;
            this.guna2GroupBox5.BorderThickness = 2;
            this.guna2GroupBox5.Controls.Add(this.lblTotalVentas);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox5.Location = new System.Drawing.Point(115, 58);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.ShadowDecoration.Parent = this.guna2GroupBox5;
            this.guna2GroupBox5.Size = new System.Drawing.Size(300, 64);
            this.guna2GroupBox5.TabIndex = 2;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.White;
            this.lblTotalVentas.Location = new System.Drawing.Point(72, 13);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(81, 38);
            this.lblTotalVentas.TabIndex = 0;
            this.lblTotalVentas.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "  Total De Ventas ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.BorderRadius = 15;
            this.guna2GroupBox2.BorderThickness = 2;
            this.guna2GroupBox2.Controls.Add(this.guna2GroupBox8);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(626, 208);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(599, 175);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // guna2GroupBox8
            // 
            this.guna2GroupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.guna2GroupBox8.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox8.BorderRadius = 4;
            this.guna2GroupBox8.BorderThickness = 2;
            this.guna2GroupBox8.Controls.Add(this.guna2GroupBox6);
            this.guna2GroupBox8.Controls.Add(this.label3);
            this.guna2GroupBox8.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox8.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox8.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox8.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox8.Location = new System.Drawing.Point(18, 16);
            this.guna2GroupBox8.Name = "guna2GroupBox8";
            this.guna2GroupBox8.ShadowDecoration.Parent = this.guna2GroupBox8;
            this.guna2GroupBox8.Size = new System.Drawing.Size(564, 143);
            this.guna2GroupBox8.TabIndex = 4;
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BorderRadius = 4;
            this.guna2GroupBox6.BorderThickness = 2;
            this.guna2GroupBox6.Controls.Add(this.lblCantidadProductos);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox6.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox6.Location = new System.Drawing.Point(127, 66);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.ShadowDecoration.Parent = this.guna2GroupBox6;
            this.guna2GroupBox6.Size = new System.Drawing.Size(300, 64);
            this.guna2GroupBox6.TabIndex = 3;
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.BackColor = System.Drawing.Color.DarkGreen;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.White;
            this.lblCantidadProductos.Location = new System.Drawing.Point(120, 16);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(193, 38);
            this.lblCantidadProductos.TabIndex = 1;
            this.lblCantidadProductos.Text = "              Total";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productos Vendidos\r\n";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.chart1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(626, 399);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(599, 375);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(27, 17);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(542, 342);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            // 
            // MDIdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 786);
            this.Controls.Add(this.menuprincipal);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIdashboard";
            this.Text = "MDIdashboard";
            this.Load += new System.EventHandler(this.MDIdashboard_Load);
            this.menuprincipal.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox7.ResumeLayout(false);
            this.guna2GroupBox7.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox8.ResumeLayout(false);
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel menuprincipal;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdetalle;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblCantidadProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox8;
        private System.Windows.Forms.Timer timer1;
    }
}



