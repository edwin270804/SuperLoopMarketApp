namespace Proyecto_Final_2
{
    partial class MDIEstadisticas
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconcerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btninforme.Location = new System.Drawing.Point(782, 5);
            this.btninforme.Name = "btninforme";
            this.btninforme.ShadowDecoration.Parent = this.btninforme;
            this.btninforme.Size = new System.Drawing.Size(232, 52);
            this.btninforme.TabIndex = 2;
            this.btninforme.Text = "Generar Informe";
            this.btninforme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip.SetToolTip(this.btninforme, "        Generar un informe detallado de las ventas realizadas\r\n");
            this.btninforme.Click += new System.EventHandler(this.btninforme_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "Panel de Estadisticas";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Panel de Estadisticas";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Panel de Estadisticas";
            series1.Legend = "Legend1";
            series1.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1061, 428);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtpInicio);
            this.panel3.Controls.Add(this.dtpFin);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 864);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(838, 701);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(838, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha Inicial:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpInicio.BorderRadius = 9;
            this.dtpInicio.CheckedState.Parent = this.dtpInicio;
            this.dtpInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpInicio.HoverState.Parent = this.dtpInicio;
            this.dtpInicio.Location = new System.Drawing.Point(782, 650);
            this.dtpInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShadowDecoration.Parent = this.dtpInicio;
            this.dtpInicio.Size = new System.Drawing.Size(253, 36);
            this.dtpInicio.TabIndex = 5;
            this.dtpInicio.Value = new System.DateTime(2025, 10, 4, 19, 47, 4, 4);
            // 
            // dtpFin
            // 
            this.dtpFin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpFin.BorderRadius = 9;
            this.dtpFin.CheckedState.Parent = this.dtpFin;
            this.dtpFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.HoverState.Parent = this.dtpFin;
            this.dtpFin.Location = new System.Drawing.Point(782, 738);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShadowDecoration.Parent = this.dtpFin;
            this.dtpFin.Size = new System.Drawing.Size(253, 36);
            this.dtpFin.TabIndex = 4;
            this.dtpFin.Value = new System.DateTime(2025, 10, 4, 19, 47, 4, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconcerrar);
            this.panel1.Controls.Add(this.btninforme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 795);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 69);
            this.panel1.TabIndex = 3;
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
            this.iconcerrar.Location = new System.Drawing.Point(12, 15);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(150, 42);
            this.iconcerrar.TabIndex = 6;
            this.iconcerrar.Text = "Volver";
            this.iconcerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconcerrar.UseVisualStyleBackColor = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // MDIEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 864);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIEstadisticas";
            this.Text = "MDIEstadisticas";
            this.Load += new System.EventHandler(this.MDIEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btninforme;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInicio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconcerrar;
    }
}



