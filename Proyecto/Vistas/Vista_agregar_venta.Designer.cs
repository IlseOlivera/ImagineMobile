namespace Proyecto_BD.Vistas
{
    partial class Vista_agregar_venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView_productos = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            Btn_cancelar = new Button();
            btn_acceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_productos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_productos
            // 
            dataGridView_productos.AllowUserToAddRows = false;
            dataGridView_productos.AllowUserToDeleteRows = false;
            dataGridView_productos.AllowUserToResizeColumns = false;
            dataGridView_productos.AllowUserToResizeRows = false;
            dataGridView_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_productos.Dock = DockStyle.Top;
            dataGridView_productos.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView_productos.Location = new Point(0, 0);
            dataGridView_productos.Name = "dataGridView_productos";
            dataGridView_productos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_productos.RowHeadersVisible = false;
            dataGridView_productos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_productos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_productos.ShowCellErrors = false;
            dataGridView_productos.ShowCellToolTips = false;
            dataGridView_productos.ShowEditingIcon = false;
            dataGridView_productos.ShowRowErrors = false;
            dataGridView_productos.Size = new Size(884, 355);
            dataGridView_productos.TabIndex = 0;
            dataGridView_productos.CellLeave += dataGridView_productos_CellLeave;
            dataGridView_productos.EditingControlShowing += dataGridView_productos_EditingControlShowing;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Btn_cancelar, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_acceptar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 352);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(884, 129);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_cancelar
            // 
            Btn_cancelar.Anchor = AnchorStyles.None;
            Btn_cancelar.Location = new Point(603, 49);
            Btn_cancelar.Name = "Btn_cancelar";
            Btn_cancelar.Size = new Size(120, 30);
            Btn_cancelar.TabIndex = 1;
            Btn_cancelar.Text = "Cancelar";
            Btn_cancelar.UseVisualStyleBackColor = true;
            Btn_cancelar.Click += Btn_cancelar_Click;
            // 
            // btn_acceptar
            // 
            btn_acceptar.Anchor = AnchorStyles.None;
            btn_acceptar.Location = new Point(161, 49);
            btn_acceptar.Name = "btn_acceptar";
            btn_acceptar.Size = new Size(120, 30);
            btn_acceptar.TabIndex = 0;
            btn_acceptar.Text = "Realizar Venta";
            btn_acceptar.UseVisualStyleBackColor = true;
            btn_acceptar.Click += btn_acceptar_Click;
            // 
            // Vista_ventas
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(884, 481);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView_productos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Vista_ventas";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Realizar Venta";
            ((System.ComponentModel.ISupportInitialize)dataGridView_productos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_productos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_cancelar;
        private Button btn_acceptar;
    }
}