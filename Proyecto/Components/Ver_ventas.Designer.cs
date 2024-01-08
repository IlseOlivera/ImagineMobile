namespace Proyecto_BD.Components
{
    partial class Ver_ventas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGrid_vista_datos = new DataGridView();
            panel_flow_muestra = new FlowLayoutPanel();
            Panel_tiles = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btn_limpiar = new Button();
            btn_generar_venta = new Button();
            txtbx_busqueda = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_vista_datos).BeginInit();
            panel_flow_muestra.SuspendLayout();
            Panel_tiles.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dataGrid_vista_datos, 0, 2);
            tableLayoutPanel1.Controls.Add(panel_flow_muestra, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Size = new Size(850, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGrid_vista_datos
            // 
            dataGrid_vista_datos.AllowUserToAddRows = false;
            dataGrid_vista_datos.AllowUserToDeleteRows = false;
            dataGrid_vista_datos.AllowUserToOrderColumns = true;
            dataGrid_vista_datos.AllowUserToResizeColumns = false;
            dataGrid_vista_datos.AllowUserToResizeRows = false;
            dataGrid_vista_datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_vista_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_vista_datos.Dock = DockStyle.Fill;
            dataGrid_vista_datos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid_vista_datos.Location = new Point(3, 295);
            dataGrid_vista_datos.Name = "dataGrid_vista_datos";
            dataGrid_vista_datos.RowHeadersVisible = false;
            dataGrid_vista_datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGrid_vista_datos.ShowCellErrors = false;
            dataGrid_vista_datos.ShowCellToolTips = false;
            dataGrid_vista_datos.ShowEditingIcon = false;
            dataGrid_vista_datos.ShowRowErrors = false;
            dataGrid_vista_datos.Size = new Size(844, 352);
            dataGrid_vista_datos.TabIndex = 3;
            // 
            // panel_flow_muestra
            // 
            panel_flow_muestra.AutoScroll = true;
            panel_flow_muestra.AutoSize = true;
            panel_flow_muestra.Controls.Add(Panel_tiles);
            panel_flow_muestra.Dock = DockStyle.Fill;
            panel_flow_muestra.FlowDirection = FlowDirection.TopDown;
            panel_flow_muestra.Location = new Point(3, 100);
            panel_flow_muestra.Name = "panel_flow_muestra";
            panel_flow_muestra.Size = new Size(844, 189);
            panel_flow_muestra.TabIndex = 0;
            panel_flow_muestra.WrapContents = false;
            // 
            // Panel_tiles
            // 
            Panel_tiles.Anchor = AnchorStyles.None;
            Panel_tiles.ColumnCount = 3;
            Panel_tiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Panel_tiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Panel_tiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Panel_tiles.Controls.Add(label2, 0, 0);
            Panel_tiles.Controls.Add(label3, 1, 0);
            Panel_tiles.Controls.Add(label4, 2, 0);
            Panel_tiles.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Panel_tiles.Location = new Point(0, 0);
            Panel_tiles.Margin = new Padding(0, 0, 0, 10);
            Panel_tiles.Name = "Panel_tiles";
            Panel_tiles.RowCount = 1;
            Panel_tiles.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Panel_tiles.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Panel_tiles.Size = new Size(843, 55);
            Panel_tiles.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 55);
            label2.TabIndex = 0;
            label2.Text = "No de Venta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(283, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 55);
            label3.TabIndex = 1;
            label3.Text = "Fecha de venta";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(563, 0);
            label4.Name = "label4";
            label4.Size = new Size(277, 55);
            label4.TabIndex = 2;
            label4.Text = "Detalles";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_generar_venta);
            panel1.Controls.Add(txtbx_busqueda);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 91);
            panel1.TabIndex = 2;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(630, 50);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(90, 25);
            btn_limpiar.TabIndex = 3;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_generar_venta
            // 
            btn_generar_venta.Location = new Point(630, 15);
            btn_generar_venta.Name = "btn_generar_venta";
            btn_generar_venta.Size = new Size(90, 25);
            btn_generar_venta.TabIndex = 2;
            btn_generar_venta.Text = "Generar Venta";
            btn_generar_venta.UseVisualStyleBackColor = true;
            btn_generar_venta.Click += btn_generar_venta_Click;
            // 
            // txtbx_busqueda
            // 
            txtbx_busqueda.Location = new Point(330, 26);
            txtbx_busqueda.Name = "txtbx_busqueda";
            txtbx_busqueda.Size = new Size(295, 23);
            txtbx_busqueda.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 30);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar venta por numero de venta:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ver_ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Ver_ventas";
            Size = new Size(850, 650);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_vista_datos).EndInit();
            panel_flow_muestra.ResumeLayout(false);
            Panel_tiles.ResumeLayout(false);
            Panel_tiles.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel panel_flow_muestra;
        private Panel panel1;
        private TextBox txtbx_busqueda;
        private Label label1;
        private Button btn_generar_venta;
        private TableLayoutPanel Panel_tiles;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_limpiar;
        private DataGridView dataGrid_vista_datos;
    }
}
