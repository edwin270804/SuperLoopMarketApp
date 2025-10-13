namespace Proyecto_Final_2
{
    partial class MDIVentas_
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btninforme = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconcerrar = new FontAwesome.Sharp.IconButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninforme
            // 
            this.btninforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btninforme.BorderRadius = 8;
            this.btninforme.CheckedState.Parent = this.btninforme;
            this.btninforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninforme.CustomImages.Parent = this.btninforme;
            this.btninforme.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninforme.ForeColor = System.Drawing.Color.White;
            this.btninforme.HoverState.Parent = this.btninforme;
            this.btninforme.Image = global::Proyecto_Final_2.Properties.Resources.solicitud;
            this.btninforme.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btninforme.Location = new System.Drawing.Point(822, 15);
            this.btninforme.Name = "btninforme";
            this.btninforme.ShadowDecoration.Parent = this.btninforme;
            this.btninforme.Size = new System.Drawing.Size(232, 52);
            this.btninforme.TabIndex = 3;
            this.btninforme.Text = "Generar Informe";
            this.btninforme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip.SetToolTip(this.btninforme, "        Generar un informe detallado de las ventas realizadas\r\n");
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 661);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconcerrar);
            this.panel2.Controls.Add(this.btninforme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 70);
            this.panel2.TabIndex = 3;
            // 
            // iconcerrar
            // 
            this.iconcerrar.BackColor = System.Drawing.Color.White;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.FlatAppearance.BorderSize = 0;
            this.iconcerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconcerrar.ForeColor = System.Drawing.Color.Black;
            this.iconcerrar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconcerrar.IconColor = System.Drawing.Color.Black;
            this.iconcerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcerrar.IconSize = 30;
            this.iconcerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconcerrar.Location = new System.Drawing.Point(12, 16);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(150, 42);
            this.iconcerrar.TabIndex = 7;
            this.iconcerrar.Text = "Volver";
            this.iconcerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconcerrar.UseVisualStyleBackColor = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1095, 495);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MDIVentas_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 661);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIVentas_";
            this.Text = "MDIVentas_";
            this.Load += new System.EventHandler(this.MDIVentas__Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btninforme;
        private FontAwesome.Sharp.IconButton iconcerrar;
    }
}



