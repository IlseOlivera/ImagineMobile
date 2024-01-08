namespace Proyecto_BD
{
    partial class Vista_Empleados
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
            table_vista = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btn_ver = new Button();
            btn_ver_ventas = new Button();
            btn_agregar_productor = new Button();
            btn_agregar_proveedor = new Button();
            table_vista.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // table_vista
            // 
            table_vista.ColumnCount = 1;
            table_vista.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table_vista.Controls.Add(tableLayoutPanel1, 0, 0);
            table_vista.Dock = DockStyle.Fill;
            table_vista.Location = new Point(0, 0);
            table_vista.Name = "table_vista";
            table_vista.RowCount = 2;
            table_vista.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table_vista.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            table_vista.Size = new Size(850, 752);
            table_vista.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btn_agregar_proveedor, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_agregar_productor, 5, 0);
            tableLayoutPanel1.Controls.Add(btn_ver_ventas, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_ver, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(844, 69);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 69);
            label1.TabIndex = 1;
            label1.Text = "Imagine Mobile\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_ver
            // 
            btn_ver.Dock = DockStyle.Fill;
            btn_ver.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_ver.Location = new Point(171, 3);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(162, 63);
            btn_ver.TabIndex = 2;
            btn_ver.Text = "Ver";
            btn_ver.UseVisualStyleBackColor = true;
            btn_ver.Click += btn_ver_Click;
            // 
            // btn_ver_ventas
            // 
            btn_ver_ventas.Dock = DockStyle.Fill;
            btn_ver_ventas.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_ver_ventas.Location = new Point(339, 3);
            btn_ver_ventas.Name = "btn_ver_ventas";
            btn_ver_ventas.Size = new Size(162, 63);
            btn_ver_ventas.TabIndex = 5;
            btn_ver_ventas.Text = "Ver Ventas";
            btn_ver_ventas.UseVisualStyleBackColor = true;
            btn_ver_ventas.Click += btn_ver_ventas_Click;
            // 
            // btn_agregar_productor
            // 
            btn_agregar_productor.Dock = DockStyle.Fill;
            btn_agregar_productor.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_agregar_productor.Location = new Point(675, 3);
            btn_agregar_productor.Name = "btn_agregar_productor";
            btn_agregar_productor.Size = new Size(166, 63);
            btn_agregar_productor.TabIndex = 6;
            btn_agregar_productor.Text = "Agregar Producto";
            btn_agregar_productor.UseVisualStyleBackColor = true;
            btn_agregar_productor.Click += btn_agregar_productor_Click;
            // 
            // btn_agregar_proveedor
            // 
            btn_agregar_proveedor.Dock = DockStyle.Fill;
            btn_agregar_proveedor.Font = new Font("Microsoft Sans Serif", 9.75F);
            btn_agregar_proveedor.Location = new Point(507, 3);
            btn_agregar_proveedor.Name = "btn_agregar_proveedor";
            btn_agregar_proveedor.Size = new Size(162, 63);
            btn_agregar_proveedor.TabIndex = 7;
            btn_agregar_proveedor.Text = "Agregar proveedor";
            btn_agregar_proveedor.UseVisualStyleBackColor = true;
            btn_agregar_proveedor.Click += btn_agregar_proveedor_Click;
            // 
            // Vista_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(850, 752);
            Controls.Add(table_vista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Vista_Empleados";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Imagine Mobile App";
            table_vista.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel table_vista;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btn_ver;
        private Button btn_ver_ventas;
        private Button btn_agregar_productor;
        private Button btn_agregar_proveedor;
    }
}