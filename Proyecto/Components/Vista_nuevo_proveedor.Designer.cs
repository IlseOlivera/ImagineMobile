namespace Proyecto_BD.Components
{
    partial class Vista_nuevo_proveedor
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_title = new Label();
            foto_proveedor = new Panel();
            Panel_nombre = new TableLayoutPanel();
            txtbx_nombre_empresa = new TextBox();
            label1 = new Label();
            Panel_RFC = new TableLayoutPanel();
            label2 = new Label();
            txtbx_rfc = new TextBox();
            Panel_nombre_representatne = new TableLayoutPanel();
            label11 = new Label();
            txtbx_nombre_rep = new TextBox();
            Panel_tel = new TableLayoutPanel();
            label3 = new Label();
            txtbx_tel = new TextBox();
            Panel_correo = new TableLayoutPanel();
            label12 = new Label();
            txtbx_correo = new TextBox();
            Panel_calle_numero = new TableLayoutPanel();
            label4 = new Label();
            txtbx_calle_num = new TextBox();
            Panel_colonia = new TableLayoutPanel();
            label5 = new Label();
            txtbx_colonia = new TextBox();
            Panel_municipio = new TableLayoutPanel();
            label6 = new Label();
            txtbx_municipio = new TextBox();
            Panel_codigo_postal = new TableLayoutPanel();
            label7 = new Label();
            txtbx_cp = new TextBox();
            Panel_ciudad = new TableLayoutPanel();
            label8 = new Label();
            txtbx_ciudad = new TextBox();
            Panel_estado = new TableLayoutPanel();
            label9 = new Label();
            txtbx_estado = new TextBox();
            panelBotones = new Panel();
            Panel_botones_registrar = new TableLayoutPanel();
            btn_limpiar_datos = new Button();
            btn_registrar_proveedor = new Button();
            Panel_botones_actualizar = new TableLayoutPanel();
            btn_bloquear_campos = new Button();
            btn_actualizar_datos = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label10 = new Label();
            textBox1 = new TextBox();
            Error = new ErrorProvider(components);
            tableLayoutPanel3 = new TableLayoutPanel();
            DataGridVerProductos = new DataGridView();
            panel1 = new Panel();
            btn_agregar_producto = new Button();
            tableLayoutPanel1.SuspendLayout();
            Panel_nombre.SuspendLayout();
            Panel_RFC.SuspendLayout();
            Panel_nombre_representatne.SuspendLayout();
            Panel_tel.SuspendLayout();
            Panel_correo.SuspendLayout();
            Panel_calle_numero.SuspendLayout();
            Panel_colonia.SuspendLayout();
            Panel_municipio.SuspendLayout();
            Panel_codigo_postal.SuspendLayout();
            Panel_ciudad.SuspendLayout();
            Panel_estado.SuspendLayout();
            panelBotones.SuspendLayout();
            Panel_botones_registrar.SuspendLayout();
            Panel_botones_actualizar.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Error).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVerProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lbl_title, 2, 0);
            tableLayoutPanel1.Controls.Add(foto_proveedor, 0, 0);
            tableLayoutPanel1.Controls.Add(Panel_nombre, 1, 1);
            tableLayoutPanel1.Controls.Add(Panel_RFC, 2, 1);
            tableLayoutPanel1.Controls.Add(Panel_nombre_representatne, 3, 1);
            tableLayoutPanel1.Controls.Add(Panel_tel, 0, 2);
            tableLayoutPanel1.Controls.Add(Panel_correo, 1, 2);
            tableLayoutPanel1.Controls.Add(Panel_calle_numero, 2, 2);
            tableLayoutPanel1.Controls.Add(Panel_colonia, 3, 2);
            tableLayoutPanel1.Controls.Add(Panel_municipio, 0, 3);
            tableLayoutPanel1.Controls.Add(Panel_codigo_postal, 1, 3);
            tableLayoutPanel1.Controls.Add(Panel_ciudad, 2, 3);
            tableLayoutPanel1.Controls.Add(Panel_estado, 3, 3);
            tableLayoutPanel1.Controls.Add(panelBotones, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(626, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lbl_title, 2);
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Location = new Point(315, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(308, 102);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "NAN";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foto_proveedor
            // 
            foto_proveedor.Dock = DockStyle.Fill;
            foto_proveedor.Location = new Point(3, 3);
            foto_proveedor.Name = "foto_proveedor";
            tableLayoutPanel1.SetRowSpan(foto_proveedor, 2);
            foto_proveedor.Size = new Size(150, 198);
            foto_proveedor.TabIndex = 1;
            // 
            // Panel_nombre
            // 
            Panel_nombre.ColumnCount = 1;
            Panel_nombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_nombre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_nombre.Controls.Add(txtbx_nombre_empresa, 0, 0);
            Panel_nombre.Controls.Add(label1, 0, 1);
            Panel_nombre.Dock = DockStyle.Fill;
            Panel_nombre.Location = new Point(159, 105);
            Panel_nombre.Name = "Panel_nombre";
            Panel_nombre.Padding = new Padding(10, 0, 10, 0);
            Panel_nombre.RowCount = 2;
            Panel_nombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nombre.Size = new Size(150, 96);
            Panel_nombre.TabIndex = 2;
            // 
            // txtbx_nombre_empresa
            // 
            txtbx_nombre_empresa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_nombre_empresa.Location = new Point(13, 12);
            txtbx_nombre_empresa.MaxLength = 25;
            txtbx_nombre_empresa.Name = "txtbx_nombre_empresa";
            txtbx_nombre_empresa.Size = new Size(124, 23);
            txtbx_nombre_empresa.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(124, 48);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la empresa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_RFC
            // 
            Panel_RFC.ColumnCount = 1;
            Panel_RFC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_RFC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_RFC.Controls.Add(label2, 0, 1);
            Panel_RFC.Controls.Add(txtbx_rfc, 0, 0);
            Panel_RFC.Dock = DockStyle.Fill;
            Panel_RFC.Location = new Point(315, 105);
            Panel_RFC.Name = "Panel_RFC";
            Panel_RFC.Padding = new Padding(10, 0, 10, 0);
            Panel_RFC.RowCount = 2;
            Panel_RFC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_RFC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_RFC.Size = new Size(150, 96);
            Panel_RFC.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(13, 48);
            label2.Name = "label2";
            label2.Size = new Size(124, 48);
            label2.TabIndex = 2;
            label2.Text = "RFC";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_rfc
            // 
            txtbx_rfc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_rfc.Location = new Point(13, 12);
            txtbx_rfc.MaxLength = 13;
            txtbx_rfc.Name = "txtbx_rfc";
            txtbx_rfc.Size = new Size(124, 23);
            txtbx_rfc.TabIndex = 1;
            // 
            // Panel_nombre_representatne
            // 
            Panel_nombre_representatne.ColumnCount = 1;
            Panel_nombre_representatne.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_nombre_representatne.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_nombre_representatne.Controls.Add(label11, 0, 1);
            Panel_nombre_representatne.Controls.Add(txtbx_nombre_rep, 0, 0);
            Panel_nombre_representatne.Dock = DockStyle.Fill;
            Panel_nombre_representatne.Location = new Point(471, 105);
            Panel_nombre_representatne.Name = "Panel_nombre_representatne";
            Panel_nombre_representatne.Padding = new Padding(10, 0, 10, 0);
            Panel_nombre_representatne.RowCount = 2;
            Panel_nombre_representatne.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nombre_representatne.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nombre_representatne.Size = new Size(152, 96);
            Panel_nombre_representatne.TabIndex = 12;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.Location = new Point(13, 48);
            label11.Name = "label11";
            label11.Size = new Size(126, 48);
            label11.TabIndex = 2;
            label11.Text = "Nombre del representante";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_nombre_rep
            // 
            txtbx_nombre_rep.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_nombre_rep.Location = new Point(13, 12);
            txtbx_nombre_rep.MaxLength = 35;
            txtbx_nombre_rep.Name = "txtbx_nombre_rep";
            txtbx_nombre_rep.Size = new Size(126, 23);
            txtbx_nombre_rep.TabIndex = 2;
            // 
            // Panel_tel
            // 
            Panel_tel.ColumnCount = 1;
            Panel_tel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_tel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_tel.Controls.Add(label3, 0, 1);
            Panel_tel.Controls.Add(txtbx_tel, 0, 0);
            Panel_tel.Dock = DockStyle.Fill;
            Panel_tel.Location = new Point(3, 207);
            Panel_tel.Name = "Panel_tel";
            Panel_tel.Padding = new Padding(10, 0, 10, 0);
            Panel_tel.RowCount = 2;
            Panel_tel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_tel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_tel.Size = new Size(150, 96);
            Panel_tel.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(13, 48);
            label3.Name = "label3";
            label3.Size = new Size(124, 48);
            label3.TabIndex = 2;
            label3.Text = "Numero de telefono";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_tel
            // 
            txtbx_tel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_tel.Location = new Point(13, 12);
            txtbx_tel.MaxLength = 10;
            txtbx_tel.Name = "txtbx_tel";
            txtbx_tel.Size = new Size(124, 23);
            txtbx_tel.TabIndex = 3;
            txtbx_tel.KeyPress += OnOnlyNumberKeyPress;
            // 
            // Panel_correo
            // 
            Panel_correo.ColumnCount = 1;
            Panel_correo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_correo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_correo.Controls.Add(label12, 0, 1);
            Panel_correo.Controls.Add(txtbx_correo, 0, 0);
            Panel_correo.Dock = DockStyle.Fill;
            Panel_correo.Location = new Point(159, 207);
            Panel_correo.Name = "Panel_correo";
            Panel_correo.Padding = new Padding(10, 0, 10, 0);
            Panel_correo.RowCount = 2;
            Panel_correo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_correo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_correo.Size = new Size(150, 96);
            Panel_correo.TabIndex = 13;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.Location = new Point(13, 48);
            label12.Name = "label12";
            label12.Size = new Size(124, 48);
            label12.TabIndex = 2;
            label12.Text = "Correo electronico";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_correo
            // 
            txtbx_correo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_correo.Location = new Point(13, 12);
            txtbx_correo.MaxLength = 25;
            txtbx_correo.Name = "txtbx_correo";
            txtbx_correo.Size = new Size(124, 23);
            txtbx_correo.TabIndex = 3;
            // 
            // Panel_calle_numero
            // 
            Panel_calle_numero.ColumnCount = 1;
            Panel_calle_numero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_calle_numero.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_calle_numero.Controls.Add(label4, 0, 1);
            Panel_calle_numero.Controls.Add(txtbx_calle_num, 0, 0);
            Panel_calle_numero.Dock = DockStyle.Fill;
            Panel_calle_numero.Location = new Point(315, 207);
            Panel_calle_numero.Name = "Panel_calle_numero";
            Panel_calle_numero.Padding = new Padding(10, 0, 10, 0);
            Panel_calle_numero.RowCount = 2;
            Panel_calle_numero.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_calle_numero.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_calle_numero.Size = new Size(150, 96);
            Panel_calle_numero.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(13, 48);
            label4.Name = "label4";
            label4.Size = new Size(124, 48);
            label4.TabIndex = 2;
            label4.Text = "Calle y numero";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_calle_num
            // 
            txtbx_calle_num.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_calle_num.Location = new Point(13, 12);
            txtbx_calle_num.MaxLength = 60;
            txtbx_calle_num.Name = "txtbx_calle_num";
            txtbx_calle_num.Size = new Size(124, 23);
            txtbx_calle_num.TabIndex = 4;
            // 
            // Panel_colonia
            // 
            Panel_colonia.ColumnCount = 1;
            Panel_colonia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_colonia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_colonia.Controls.Add(label5, 0, 1);
            Panel_colonia.Controls.Add(txtbx_colonia, 0, 0);
            Panel_colonia.Dock = DockStyle.Fill;
            Panel_colonia.Location = new Point(471, 207);
            Panel_colonia.Name = "Panel_colonia";
            Panel_colonia.Padding = new Padding(10, 0, 10, 0);
            Panel_colonia.RowCount = 2;
            Panel_colonia.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_colonia.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_colonia.Size = new Size(152, 96);
            Panel_colonia.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Location = new Point(13, 48);
            label5.Name = "label5";
            label5.Size = new Size(126, 48);
            label5.TabIndex = 2;
            label5.Text = "Colonia";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_colonia
            // 
            txtbx_colonia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_colonia.Location = new Point(13, 12);
            txtbx_colonia.MaxLength = 60;
            txtbx_colonia.Name = "txtbx_colonia";
            txtbx_colonia.Size = new Size(126, 23);
            txtbx_colonia.TabIndex = 5;
            // 
            // Panel_municipio
            // 
            Panel_municipio.ColumnCount = 1;
            Panel_municipio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_municipio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_municipio.Controls.Add(label6, 0, 1);
            Panel_municipio.Controls.Add(txtbx_municipio, 0, 0);
            Panel_municipio.Dock = DockStyle.Fill;
            Panel_municipio.Location = new Point(3, 309);
            Panel_municipio.Name = "Panel_municipio";
            Panel_municipio.Padding = new Padding(10, 0, 10, 0);
            Panel_municipio.RowCount = 2;
            Panel_municipio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_municipio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_municipio.Size = new Size(150, 96);
            Panel_municipio.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Location = new Point(13, 48);
            label6.Name = "label6";
            label6.Size = new Size(124, 48);
            label6.TabIndex = 2;
            label6.Text = "Municipio/alcaldia";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_municipio
            // 
            txtbx_municipio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_municipio.Location = new Point(13, 12);
            txtbx_municipio.MaxLength = 60;
            txtbx_municipio.Name = "txtbx_municipio";
            txtbx_municipio.Size = new Size(124, 23);
            txtbx_municipio.TabIndex = 6;
            // 
            // Panel_codigo_postal
            // 
            Panel_codigo_postal.ColumnCount = 1;
            Panel_codigo_postal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_codigo_postal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_codigo_postal.Controls.Add(label7, 0, 1);
            Panel_codigo_postal.Controls.Add(txtbx_cp, 0, 0);
            Panel_codigo_postal.Dock = DockStyle.Fill;
            Panel_codigo_postal.Location = new Point(159, 309);
            Panel_codigo_postal.Name = "Panel_codigo_postal";
            Panel_codigo_postal.Padding = new Padding(10, 0, 10, 0);
            Panel_codigo_postal.RowCount = 2;
            Panel_codigo_postal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_codigo_postal.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_codigo_postal.Size = new Size(150, 96);
            Panel_codigo_postal.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.Location = new Point(13, 48);
            label7.Name = "label7";
            label7.Size = new Size(124, 48);
            label7.TabIndex = 2;
            label7.Text = "Codigo postal";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_cp
            // 
            txtbx_cp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_cp.Location = new Point(13, 12);
            txtbx_cp.MaxLength = 5;
            txtbx_cp.Name = "txtbx_cp";
            txtbx_cp.Size = new Size(124, 23);
            txtbx_cp.TabIndex = 7;
            txtbx_cp.KeyPress += OnOnlyNumberKeyPress;
            // 
            // Panel_ciudad
            // 
            Panel_ciudad.ColumnCount = 1;
            Panel_ciudad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_ciudad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_ciudad.Controls.Add(label8, 0, 1);
            Panel_ciudad.Controls.Add(txtbx_ciudad, 0, 0);
            Panel_ciudad.Dock = DockStyle.Fill;
            Panel_ciudad.Location = new Point(315, 309);
            Panel_ciudad.Name = "Panel_ciudad";
            Panel_ciudad.Padding = new Padding(10, 0, 10, 0);
            Panel_ciudad.RowCount = 2;
            Panel_ciudad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_ciudad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_ciudad.Size = new Size(150, 96);
            Panel_ciudad.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.Location = new Point(13, 48);
            label8.Name = "label8";
            label8.Size = new Size(124, 48);
            label8.TabIndex = 2;
            label8.Text = "Ciudad";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_ciudad
            // 
            txtbx_ciudad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_ciudad.Location = new Point(13, 12);
            txtbx_ciudad.MaxLength = 60;
            txtbx_ciudad.Name = "txtbx_ciudad";
            txtbx_ciudad.Size = new Size(124, 23);
            txtbx_ciudad.TabIndex = 8;
            // 
            // Panel_estado
            // 
            Panel_estado.ColumnCount = 1;
            Panel_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_estado.Controls.Add(label9, 0, 1);
            Panel_estado.Controls.Add(txtbx_estado, 0, 0);
            Panel_estado.Dock = DockStyle.Fill;
            Panel_estado.Location = new Point(471, 309);
            Panel_estado.Name = "Panel_estado";
            Panel_estado.Padding = new Padding(10, 0, 10, 0);
            Panel_estado.RowCount = 2;
            Panel_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_estado.Size = new Size(152, 96);
            Panel_estado.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.Location = new Point(13, 48);
            label9.Name = "label9";
            label9.Size = new Size(126, 48);
            label9.TabIndex = 2;
            label9.Text = "Estado";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_estado
            // 
            txtbx_estado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtbx_estado.Location = new Point(13, 12);
            txtbx_estado.MaxLength = 60;
            txtbx_estado.Name = "txtbx_estado";
            txtbx_estado.Size = new Size(126, 23);
            txtbx_estado.TabIndex = 9;
            // 
            // panelBotones
            // 
            tableLayoutPanel1.SetColumnSpan(panelBotones, 4);
            panelBotones.Controls.Add(Panel_botones_registrar);
            panelBotones.Controls.Add(Panel_botones_actualizar);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(3, 411);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(620, 96);
            panelBotones.TabIndex = 11;
            // 
            // Panel_botones_registrar
            // 
            Panel_botones_registrar.ColumnCount = 2;
            Panel_botones_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_botones_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_botones_registrar.Controls.Add(btn_limpiar_datos, 0, 0);
            Panel_botones_registrar.Controls.Add(btn_registrar_proveedor, 1, 0);
            Panel_botones_registrar.Dock = DockStyle.Fill;
            Panel_botones_registrar.Location = new Point(0, 0);
            Panel_botones_registrar.Name = "Panel_botones_registrar";
            Panel_botones_registrar.RowCount = 1;
            Panel_botones_registrar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_botones_registrar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_botones_registrar.Size = new Size(620, 96);
            Panel_botones_registrar.TabIndex = 0;
            // 
            // btn_limpiar_datos
            // 
            btn_limpiar_datos.Anchor = AnchorStyles.None;
            btn_limpiar_datos.Location = new Point(110, 35);
            btn_limpiar_datos.Name = "btn_limpiar_datos";
            btn_limpiar_datos.Size = new Size(90, 25);
            btn_limpiar_datos.TabIndex = 10;
            btn_limpiar_datos.Text = "Limpiar";
            btn_limpiar_datos.UseVisualStyleBackColor = true;
            btn_limpiar_datos.Click += btn_limpiar_datos_Click;
            // 
            // btn_registrar_proveedor
            // 
            btn_registrar_proveedor.Anchor = AnchorStyles.None;
            btn_registrar_proveedor.Location = new Point(420, 35);
            btn_registrar_proveedor.Name = "btn_registrar_proveedor";
            btn_registrar_proveedor.Size = new Size(90, 25);
            btn_registrar_proveedor.TabIndex = 11;
            btn_registrar_proveedor.Text = "Registrar";
            btn_registrar_proveedor.UseVisualStyleBackColor = true;
            btn_registrar_proveedor.Click += btn_registrar_proveedor_Click;
            // 
            // Panel_botones_actualizar
            // 
            Panel_botones_actualizar.ColumnCount = 2;
            Panel_botones_actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_botones_actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Panel_botones_actualizar.Controls.Add(btn_bloquear_campos, 0, 0);
            Panel_botones_actualizar.Controls.Add(btn_actualizar_datos, 1, 0);
            Panel_botones_actualizar.Dock = DockStyle.Fill;
            Panel_botones_actualizar.Location = new Point(0, 0);
            Panel_botones_actualizar.Name = "Panel_botones_actualizar";
            Panel_botones_actualizar.RowCount = 1;
            Panel_botones_actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_botones_actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_botones_actualizar.Size = new Size(620, 96);
            Panel_botones_actualizar.TabIndex = 1;
            // 
            // btn_bloquear_campos
            // 
            btn_bloquear_campos.Anchor = AnchorStyles.None;
            btn_bloquear_campos.Location = new Point(110, 35);
            btn_bloquear_campos.Name = "btn_bloquear_campos";
            btn_bloquear_campos.Size = new Size(90, 25);
            btn_bloquear_campos.TabIndex = 10;
            btn_bloquear_campos.Text = "Desbloquear";
            btn_bloquear_campos.UseVisualStyleBackColor = true;
            btn_bloquear_campos.Click += btn_bloquear_campos_Click;
            // 
            // btn_actualizar_datos
            // 
            btn_actualizar_datos.Anchor = AnchorStyles.None;
            btn_actualizar_datos.Location = new Point(420, 35);
            btn_actualizar_datos.Name = "btn_actualizar_datos";
            btn_actualizar_datos.Size = new Size(90, 25);
            btn_actualizar_datos.TabIndex = 11;
            btn_actualizar_datos.Text = "Actualizar";
            btn_actualizar_datos.UseVisualStyleBackColor = true;
            btn_actualizar_datos.Click += btn_actualizar_datos_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label10, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(10, 0, 10, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(13, 20);
            label10.Name = "label10";
            label10.Size = new Size(174, 80);
            label10.TabIndex = 2;
            label10.Text = "Numero de telefono";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(13, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // Error
            // 
            Error.ContainerControl = this;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(DataGridVerProductos, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(630, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(200, 510);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // DataGridVerProductos
            // 
            DataGridVerProductos.AllowUserToAddRows = false;
            DataGridVerProductos.AllowUserToDeleteRows = false;
            DataGridVerProductos.AllowUserToResizeColumns = false;
            DataGridVerProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridVerProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridVerProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridVerProductos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridVerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridVerProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVerProductos.Dock = DockStyle.Fill;
            DataGridVerProductos.EditMode = DataGridViewEditMode.EditOnEnter;
            DataGridVerProductos.EnableHeadersVisualStyles = false;
            DataGridVerProductos.Location = new Point(3, 3);
            DataGridVerProductos.MultiSelect = false;
            DataGridVerProductos.Name = "DataGridVerProductos";
            DataGridVerProductos.RowHeadersVisible = false;
            DataGridVerProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            DataGridVerProductos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridVerProductos.Size = new Size(194, 427);
            DataGridVerProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_agregar_producto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 71);
            panel1.TabIndex = 2;
            // 
            // btn_agregar_producto
            // 
            btn_agregar_producto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_agregar_producto.Location = new Point(42, 23);
            btn_agregar_producto.Name = "btn_agregar_producto";
            btn_agregar_producto.Size = new Size(110, 25);
            btn_agregar_producto.TabIndex = 0;
            btn_agregar_producto.Text = "Agregar producto";
            btn_agregar_producto.UseVisualStyleBackColor = true;
            btn_agregar_producto.Click += btn_agregar_producto_Click;
            // 
            // Vista_nuevo_proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "Vista_nuevo_proveedor";
            Size = new Size(830, 510);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            Panel_nombre.ResumeLayout(false);
            Panel_nombre.PerformLayout();
            Panel_RFC.ResumeLayout(false);
            Panel_RFC.PerformLayout();
            Panel_nombre_representatne.ResumeLayout(false);
            Panel_nombre_representatne.PerformLayout();
            Panel_tel.ResumeLayout(false);
            Panel_tel.PerformLayout();
            Panel_correo.ResumeLayout(false);
            Panel_correo.PerformLayout();
            Panel_calle_numero.ResumeLayout(false);
            Panel_calle_numero.PerformLayout();
            Panel_colonia.ResumeLayout(false);
            Panel_colonia.PerformLayout();
            Panel_municipio.ResumeLayout(false);
            Panel_municipio.PerformLayout();
            Panel_codigo_postal.ResumeLayout(false);
            Panel_codigo_postal.PerformLayout();
            Panel_ciudad.ResumeLayout(false);
            Panel_ciudad.PerformLayout();
            Panel_estado.ResumeLayout(false);
            Panel_estado.PerformLayout();
            panelBotones.ResumeLayout(false);
            Panel_botones_registrar.ResumeLayout(false);
            Panel_botones_actualizar.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Error).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridVerProductos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_title;
        private Panel foto_proveedor;
        private TableLayoutPanel Panel_nombre;
        private TableLayoutPanel Panel_RFC;
        private TableLayoutPanel Panel_tel;
        private TableLayoutPanel Panel_calle_numero;
        private TableLayoutPanel Panel_colonia;
        private TableLayoutPanel Panel_municipio;
        private TableLayoutPanel Panel_codigo_postal;
        private TableLayoutPanel Panel_ciudad;
        private TableLayoutPanel Panel_estado;
        private Panel panelBotones;
        private TableLayoutPanel Panel_botones_registrar;
        private TableLayoutPanel Panel_botones_actualizar;
        private Button btn_bloquear_campos;
        private Button btn_actualizar_datos;
        private Button btn_limpiar_datos;
        private Button btn_registrar_proveedor;
        private TextBox txtbx_nombre_empresa;
        private TextBox txtbx_rfc;
        private TextBox txtbx_tel;
        private TextBox txtbx_calle_num;
        private TextBox txtbx_colonia;
        private TextBox txtbx_municipio;
        private TextBox txtbx_cp;
        private TextBox txtbx_ciudad;
        private TextBox txtbx_estado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private TextBox textBox1;
        private TableLayoutPanel Panel_nombre_representatne;
        private Label label11;
        private TextBox txtbx_nombre_rep;
        private ErrorProvider Error;
        private TableLayoutPanel Panel_correo;
        private Label label12;
        private TextBox txtbx_correo;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView DataGridVerProductos;
        private Panel panel1;
        private Button btn_agregar_producto;
    }
}
