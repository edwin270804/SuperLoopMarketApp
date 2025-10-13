namespace Proyecto_Final_2
{
    partial class MDItrabajadores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.iconregistrar = new Guna.UI2.WinForms.Guna2Button();
            this.iconcerrar = new FontAwesome.Sharp.IconButton();
            this.dgvtrabajadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 585);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Location = new System.Drawing.Point(33, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 561);
            this.panel2.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 8;
            this.guna2GroupBox1.Controls.Add(this.iconregistrar);
            this.guna2GroupBox1.Controls.Add(this.iconcerrar);
            this.guna2GroupBox1.Controls.Add(this.dgvtrabajadores);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txtbuscar);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(24, 19);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1071, 539);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // iconregistrar
            // 
            this.iconregistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconregistrar.BorderRadius = 9;
            this.iconregistrar.CheckedState.Parent = this.iconregistrar;
            this.iconregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconregistrar.CustomImages.Parent = this.iconregistrar;
            this.iconregistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconregistrar.ForeColor = System.Drawing.Color.White;
            this.iconregistrar.HoverState.Parent = this.iconregistrar;
            this.iconregistrar.Location = new System.Drawing.Point(735, 57);
            this.iconregistrar.Name = "iconregistrar";
            this.iconregistrar.ShadowDecoration.Parent = this.iconregistrar;
            this.iconregistrar.Size = new System.Drawing.Size(307, 45);
            this.iconregistrar.TabIndex = 6;
            this.iconregistrar.Text = "  Registrar Nuevo Trabajador";
            this.iconregistrar.Click += new System.EventHandler(this.iconregistrar_Click_1);
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
            this.iconcerrar.Location = new System.Drawing.Point(6, 6);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(150, 42);
            this.iconcerrar.TabIndex = 5;
            this.iconcerrar.Text = "Volver";
            this.iconcerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconcerrar.UseVisualStyleBackColor = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click_1);
            // 
            // dgvtrabajadores
            // 
            this.dgvtrabajadores.AllowUserToAddRows = false;
            this.dgvtrabajadores.AllowUserToOrderColumns = true;
            this.dgvtrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtrabajadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvtrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtrabajadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvtrabajadores.Location = new System.Drawing.Point(6, 165);
            this.dgvtrabajadores.Name = "dgvtrabajadores";
            this.dgvtrabajadores.RowHeadersVisible = false;
            this.dgvtrabajadores.RowHeadersWidth = 51;
            this.dgvtrabajadores.RowTemplate.Height = 24;
            this.dgvtrabajadores.Size = new System.Drawing.Size(1045, 371);
            this.dgvtrabajadores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(574, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informacion de Trabajadores";
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.White;
            this.txtbuscar.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbuscar.BorderRadius = 8;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.Parent = this.txtbuscar;
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.FocusedState.Parent = this.txtbuscar;
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.Parent = this.txtbuscar;
            this.txtbuscar.IconLeft = global::Proyecto_Final_2.Properties.Resources.icons8_search_24;
            this.txtbuscar.Location = new System.Drawing.Point(6, 57);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "Buscar Empleado...";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(431, 55);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // MDItrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 585);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDItrabajadores";
            this.Text = "MDItrabajadores";
            this.Load += new System.EventHandler(this.MDItrabajadores_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrabajadores)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvtrabajadores;
        private FontAwesome.Sharp.IconButton iconcerrar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button iconregistrar;
    }
}



