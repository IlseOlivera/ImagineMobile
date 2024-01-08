namespace Proyecto_BD.Controles
{
    partial class VistaModificarAgregarUsuario
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
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelNombre = new TableLayoutPanel();
            txtbx_Nombre = new TextBox();
            lbl_nombre = new Label();
            Panel_Ap = new TableLayoutPanel();
            lbl_Ap = new Label();
            txtbx_AP = new TextBox();
            Panel_AM = new TableLayoutPanel();
            lbl_AM = new Label();
            txtbx_AM = new TextBox();
            Panel_Tel = new TableLayoutPanel();
            lbl_numTel = new Label();
            txtbx_tel = new TextBox();
            Panel_nss = new TableLayoutPanel();
            lbl_NSS = new Label();
            txtbx_NSS = new TextBox();
            Panel_Fecha_nacimiento = new TableLayoutPanel();
            lbl_fechaN = new Label();
            Dtpck_FCN = new DateTimePicker();
            Panel_RFC = new TableLayoutPanel();
            lbl_RFC = new Label();
            txtbx_RFC = new TextBox();
            Panel_CURP = new TableLayoutPanel();
            lbl_CURP = new Label();
            txtbx_CURP = new TextBox();
            Panel_correo = new TableLayoutPanel();
            lbl_correo = new Label();
            txtbx_correo = new TextBox();
            Panel_Contraseña = new TableLayoutPanel();
            Contraseña = new Label();
            txtbx_psswrd = new TextBox();
            Panel_municipio = new TableLayoutPanel();
            lbl_Municipio = new Label();
            txtbx_Municipio = new TextBox();
            Panel_CP = new TableLayoutPanel();
            lbl_Cp = new Label();
            txtbx_CP = new TextBox();
            Panel_Ciudad = new TableLayoutPanel();
            lbl_Ciudad = new Label();
            txtbx_ciudad = new TextBox();
            Panel_estado = new TableLayoutPanel();
            lbl_edo = new Label();
            txtbx_estado = new TextBox();
            Lbl_title = new Label();
            Panel_botones = new Panel();
            Tabla_btn_registrar = new TableLayoutPanel();
            btn_registrar = new Button();
            btn_limpiar = new Button();
            Tabla_btn_actualizar_usuario = new TableLayoutPanel();
            btn_bloquear = new Button();
            btn_actualizar = new Button();
            Tabla_botones_registrar = new TableLayoutPanel();
            Error = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            PanelNombre.SuspendLayout();
            Panel_Ap.SuspendLayout();
            Panel_AM.SuspendLayout();
            Panel_Tel.SuspendLayout();
            Panel_nss.SuspendLayout();
            Panel_Fecha_nacimiento.SuspendLayout();
            Panel_RFC.SuspendLayout();
            Panel_CURP.SuspendLayout();
            Panel_correo.SuspendLayout();
            Panel_Contraseña.SuspendLayout();
            Panel_municipio.SuspendLayout();
            Panel_CP.SuspendLayout();
            Panel_Ciudad.SuspendLayout();
            Panel_estado.SuspendLayout();
            Panel_botones.SuspendLayout();
            Tabla_btn_registrar.SuspendLayout();
            Tabla_btn_actualizar_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Error).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(PanelNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(Panel_Ap, 2, 1);
            tableLayoutPanel1.Controls.Add(Panel_AM, 3, 1);
            tableLayoutPanel1.Controls.Add(Panel_Tel, 1, 2);
            tableLayoutPanel1.Controls.Add(Panel_nss, 2, 2);
            tableLayoutPanel1.Controls.Add(Panel_Fecha_nacimiento, 3, 2);
            tableLayoutPanel1.Controls.Add(Panel_RFC, 0, 3);
            tableLayoutPanel1.Controls.Add(Panel_CURP, 1, 3);
            tableLayoutPanel1.Controls.Add(Panel_correo, 2, 3);
            tableLayoutPanel1.Controls.Add(Panel_Contraseña, 3, 3);
            tableLayoutPanel1.Controls.Add(Panel_municipio, 0, 4);
            tableLayoutPanel1.Controls.Add(Panel_CP, 1, 4);
            tableLayoutPanel1.Controls.Add(Panel_Ciudad, 2, 4);
            tableLayoutPanel1.Controls.Add(Panel_estado, 3, 4);
            tableLayoutPanel1.Controls.Add(Lbl_title, 0, 0);
            tableLayoutPanel1.Controls.Add(Panel_botones, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(830, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelNombre
            // 
            PanelNombre.ColumnCount = 1;
            PanelNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelNombre.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelNombre.Controls.Add(txtbx_Nombre, 0, 0);
            PanelNombre.Controls.Add(lbl_nombre, 0, 1);
            PanelNombre.Dock = DockStyle.Fill;
            PanelNombre.Location = new Point(210, 88);
            PanelNombre.Name = "PanelNombre";
            PanelNombre.RowCount = 2;
            PanelNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelNombre.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelNombre.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PanelNombre.Size = new Size(201, 79);
            PanelNombre.TabIndex = 2;
            // 
            // txtbx_Nombre
            // 
            txtbx_Nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_Nombre.Location = new Point(33, 3);
            txtbx_Nombre.MaxLength = 20;
            txtbx_Nombre.Name = "txtbx_Nombre";
            txtbx_Nombre.Size = new Size(135, 23);
            txtbx_Nombre.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Dock = DockStyle.Fill;
            lbl_nombre.Location = new Point(3, 39);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(195, 40);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            lbl_nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Ap
            // 
            Panel_Ap.ColumnCount = 1;
            Panel_Ap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_Ap.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_Ap.Controls.Add(lbl_Ap, 0, 1);
            Panel_Ap.Controls.Add(txtbx_AP, 0, 0);
            Panel_Ap.Dock = DockStyle.Fill;
            Panel_Ap.Location = new Point(417, 88);
            Panel_Ap.Name = "Panel_Ap";
            Panel_Ap.RowCount = 2;
            Panel_Ap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Ap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Ap.Size = new Size(201, 79);
            Panel_Ap.TabIndex = 1;
            // 
            // lbl_Ap
            // 
            lbl_Ap.AutoSize = true;
            lbl_Ap.Dock = DockStyle.Fill;
            lbl_Ap.Location = new Point(3, 39);
            lbl_Ap.Name = "lbl_Ap";
            lbl_Ap.Size = new Size(195, 40);
            lbl_Ap.TabIndex = 2;
            lbl_Ap.Text = "Apellido paterno";
            lbl_Ap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_AP
            // 
            txtbx_AP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_AP.Location = new Point(33, 3);
            txtbx_AP.MaxLength = 15;
            txtbx_AP.Name = "txtbx_AP";
            txtbx_AP.Size = new Size(135, 23);
            txtbx_AP.TabIndex = 2;
            // 
            // Panel_AM
            // 
            Panel_AM.ColumnCount = 1;
            Panel_AM.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_AM.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_AM.Controls.Add(lbl_AM, 0, 1);
            Panel_AM.Controls.Add(txtbx_AM, 0, 0);
            Panel_AM.Dock = DockStyle.Fill;
            Panel_AM.Location = new Point(624, 88);
            Panel_AM.Name = "Panel_AM";
            Panel_AM.RowCount = 2;
            Panel_AM.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_AM.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_AM.Size = new Size(203, 79);
            Panel_AM.TabIndex = 2;
            // 
            // lbl_AM
            // 
            lbl_AM.AutoSize = true;
            lbl_AM.Dock = DockStyle.Fill;
            lbl_AM.Location = new Point(3, 39);
            lbl_AM.Name = "lbl_AM";
            lbl_AM.Size = new Size(197, 40);
            lbl_AM.TabIndex = 2;
            lbl_AM.Text = "Apellido Materno";
            lbl_AM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_AM
            // 
            txtbx_AM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_AM.Location = new Point(34, 3);
            txtbx_AM.MaxLength = 15;
            txtbx_AM.Name = "txtbx_AM";
            txtbx_AM.Size = new Size(135, 23);
            txtbx_AM.TabIndex = 3;
            // 
            // Panel_Tel
            // 
            Panel_Tel.ColumnCount = 1;
            Panel_Tel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_Tel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_Tel.Controls.Add(lbl_numTel, 0, 1);
            Panel_Tel.Controls.Add(txtbx_tel, 0, 0);
            Panel_Tel.Dock = DockStyle.Fill;
            Panel_Tel.Location = new Point(210, 173);
            Panel_Tel.Name = "Panel_Tel";
            Panel_Tel.RowCount = 2;
            Panel_Tel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Tel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Tel.Size = new Size(201, 79);
            Panel_Tel.TabIndex = 2;
            // 
            // lbl_numTel
            // 
            lbl_numTel.AutoSize = true;
            lbl_numTel.Dock = DockStyle.Fill;
            lbl_numTel.Location = new Point(3, 39);
            lbl_numTel.Name = "lbl_numTel";
            lbl_numTel.Size = new Size(195, 40);
            lbl_numTel.TabIndex = 2;
            lbl_numTel.Text = "Numero de telefono";
            lbl_numTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_tel
            // 
            txtbx_tel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_tel.Location = new Point(33, 3);
            txtbx_tel.MaxLength = 10;
            txtbx_tel.Name = "txtbx_tel";
            txtbx_tel.PlaceholderText = "0";
            txtbx_tel.Size = new Size(135, 23);
            txtbx_tel.TabIndex = 4;
            txtbx_tel.KeyPress += OnOnlyNumberKeyPress;
            // 
            // Panel_nss
            // 
            Panel_nss.ColumnCount = 1;
            Panel_nss.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_nss.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_nss.Controls.Add(lbl_NSS, 0, 1);
            Panel_nss.Controls.Add(txtbx_NSS, 0, 0);
            Panel_nss.Dock = DockStyle.Fill;
            Panel_nss.Location = new Point(417, 173);
            Panel_nss.Name = "Panel_nss";
            Panel_nss.RowCount = 2;
            Panel_nss.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nss.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_nss.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Panel_nss.Size = new Size(201, 79);
            Panel_nss.TabIndex = 2;
            // 
            // lbl_NSS
            // 
            lbl_NSS.AutoSize = true;
            lbl_NSS.Dock = DockStyle.Fill;
            lbl_NSS.Location = new Point(3, 39);
            lbl_NSS.Name = "lbl_NSS";
            lbl_NSS.Size = new Size(195, 40);
            lbl_NSS.TabIndex = 2;
            lbl_NSS.Text = "Numero de seguro social";
            lbl_NSS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_NSS
            // 
            txtbx_NSS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_NSS.Location = new Point(33, 3);
            txtbx_NSS.MaxLength = 11;
            txtbx_NSS.Name = "txtbx_NSS";
            txtbx_NSS.Size = new Size(135, 23);
            txtbx_NSS.TabIndex = 5;
            txtbx_NSS.KeyPress += OnOnlyNumberKeyPress;
            // 
            // Panel_Fecha_nacimiento
            // 
            Panel_Fecha_nacimiento.ColumnCount = 1;
            Panel_Fecha_nacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_Fecha_nacimiento.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_Fecha_nacimiento.Controls.Add(lbl_fechaN, 0, 1);
            Panel_Fecha_nacimiento.Controls.Add(Dtpck_FCN, 0, 0);
            Panel_Fecha_nacimiento.Dock = DockStyle.Fill;
            Panel_Fecha_nacimiento.Location = new Point(624, 173);
            Panel_Fecha_nacimiento.Name = "Panel_Fecha_nacimiento";
            Panel_Fecha_nacimiento.RowCount = 2;
            Panel_Fecha_nacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Fecha_nacimiento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Fecha_nacimiento.Size = new Size(203, 79);
            Panel_Fecha_nacimiento.TabIndex = 2;
            // 
            // lbl_fechaN
            // 
            lbl_fechaN.AutoSize = true;
            lbl_fechaN.Dock = DockStyle.Fill;
            lbl_fechaN.Location = new Point(3, 39);
            lbl_fechaN.Name = "lbl_fechaN";
            lbl_fechaN.Size = new Size(197, 40);
            lbl_fechaN.TabIndex = 2;
            lbl_fechaN.Text = "Fecha de nacimiento";
            lbl_fechaN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dtpck_FCN
            // 
            Dtpck_FCN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Dtpck_FCN.Location = new Point(20, 3);
            Dtpck_FCN.MaxDate = DateTime.Now.AddYears(-4);
            Dtpck_FCN.Name = "Dtpck_FCN";
            Dtpck_FCN.Size = new Size(163, 23);
            Dtpck_FCN.TabIndex = 6;
            Dtpck_FCN.Value = DateTime.Now.AddYears(-5);
            // 
            // Panel_RFC
            // 
            Panel_RFC.ColumnCount = 1;
            Panel_RFC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_RFC.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_RFC.Controls.Add(lbl_RFC, 0, 1);
            Panel_RFC.Controls.Add(txtbx_RFC, 0, 0);
            Panel_RFC.Dock = DockStyle.Fill;
            Panel_RFC.Location = new Point(3, 258);
            Panel_RFC.Name = "Panel_RFC";
            Panel_RFC.RowCount = 2;
            Panel_RFC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_RFC.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_RFC.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Panel_RFC.Size = new Size(201, 79);
            Panel_RFC.TabIndex = 2;
            // 
            // lbl_RFC
            // 
            lbl_RFC.AutoSize = true;
            lbl_RFC.Dock = DockStyle.Fill;
            lbl_RFC.Location = new Point(3, 39);
            lbl_RFC.Name = "lbl_RFC";
            lbl_RFC.Size = new Size(195, 40);
            lbl_RFC.TabIndex = 2;
            lbl_RFC.Text = "RFC";
            lbl_RFC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_RFC
            // 
            txtbx_RFC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_RFC.Location = new Point(33, 3);
            txtbx_RFC.MaxLength = 13;
            txtbx_RFC.Name = "txtbx_RFC";
            txtbx_RFC.Size = new Size(135, 23);
            txtbx_RFC.TabIndex = 7;
            // 
            // Panel_CURP
            // 
            Panel_CURP.ColumnCount = 1;
            Panel_CURP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_CURP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_CURP.Controls.Add(lbl_CURP, 0, 1);
            Panel_CURP.Controls.Add(txtbx_CURP, 0, 0);
            Panel_CURP.Dock = DockStyle.Fill;
            Panel_CURP.Location = new Point(210, 258);
            Panel_CURP.Name = "Panel_CURP";
            Panel_CURP.RowCount = 2;
            Panel_CURP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_CURP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_CURP.Size = new Size(201, 79);
            Panel_CURP.TabIndex = 2;
            // 
            // lbl_CURP
            // 
            lbl_CURP.AutoSize = true;
            lbl_CURP.Dock = DockStyle.Fill;
            lbl_CURP.Location = new Point(3, 39);
            lbl_CURP.Name = "lbl_CURP";
            lbl_CURP.Size = new Size(195, 40);
            lbl_CURP.TabIndex = 2;
            lbl_CURP.Text = "CURP";
            lbl_CURP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_CURP
            // 
            txtbx_CURP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_CURP.Location = new Point(33, 3);
            txtbx_CURP.MaxLength = 18;
            txtbx_CURP.Name = "txtbx_CURP";
            txtbx_CURP.Size = new Size(135, 23);
            txtbx_CURP.TabIndex = 8;
            // 
            // Panel_correo
            // 
            Panel_correo.ColumnCount = 1;
            Panel_correo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_correo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_correo.Controls.Add(lbl_correo, 0, 1);
            Panel_correo.Controls.Add(txtbx_correo, 0, 0);
            Panel_correo.Dock = DockStyle.Fill;
            Panel_correo.Location = new Point(417, 258);
            Panel_correo.Name = "Panel_correo";
            Panel_correo.RowCount = 2;
            Panel_correo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_correo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_correo.Size = new Size(201, 79);
            Panel_correo.TabIndex = 2;
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Dock = DockStyle.Fill;
            lbl_correo.Location = new Point(3, 39);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(195, 40);
            lbl_correo.TabIndex = 2;
            lbl_correo.Text = "Correo electronico";
            lbl_correo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_correo
            // 
            txtbx_correo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_correo.Location = new Point(33, 3);
            txtbx_correo.MaxLength = 30;
            txtbx_correo.Name = "txtbx_correo";
            txtbx_correo.Size = new Size(135, 23);
            txtbx_correo.TabIndex = 9;
            // 
            // Panel_Contraseña
            // 
            Panel_Contraseña.ColumnCount = 1;
            Panel_Contraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_Contraseña.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_Contraseña.Controls.Add(Contraseña, 0, 1);
            Panel_Contraseña.Controls.Add(txtbx_psswrd, 0, 0);
            Panel_Contraseña.Dock = DockStyle.Fill;
            Panel_Contraseña.Location = new Point(624, 258);
            Panel_Contraseña.Name = "Panel_Contraseña";
            Panel_Contraseña.RowCount = 2;
            Panel_Contraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Contraseña.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Contraseña.Size = new Size(203, 79);
            Panel_Contraseña.TabIndex = 2;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Dock = DockStyle.Fill;
            Contraseña.Location = new Point(3, 39);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(197, 40);
            Contraseña.TabIndex = 2;
            Contraseña.Text = "Contraseña";
            Contraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_psswrd
            // 
            txtbx_psswrd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_psswrd.Location = new Point(34, 3);
            txtbx_psswrd.Name = "txtbx_psswrd";
            txtbx_psswrd.Size = new Size(135, 23);
            txtbx_psswrd.TabIndex = 10;
            // 
            // Panel_municipio
            // 
            Panel_municipio.ColumnCount = 1;
            Panel_municipio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_municipio.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_municipio.Controls.Add(lbl_Municipio, 0, 1);
            Panel_municipio.Controls.Add(txtbx_Municipio, 0, 0);
            Panel_municipio.Dock = DockStyle.Fill;
            Panel_municipio.Location = new Point(3, 343);
            Panel_municipio.Name = "Panel_municipio";
            Panel_municipio.RowCount = 2;
            Panel_municipio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_municipio.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_municipio.Size = new Size(201, 79);
            Panel_municipio.TabIndex = 2;
            // 
            // lbl_Municipio
            // 
            lbl_Municipio.AutoSize = true;
            lbl_Municipio.Dock = DockStyle.Fill;
            lbl_Municipio.Location = new Point(3, 39);
            lbl_Municipio.Name = "lbl_Municipio";
            lbl_Municipio.Size = new Size(195, 40);
            lbl_Municipio.TabIndex = 2;
            lbl_Municipio.Text = "Municipio/alcaldia";
            lbl_Municipio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_Municipio
            // 
            txtbx_Municipio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_Municipio.Location = new Point(33, 3);
            txtbx_Municipio.Name = "txtbx_Municipio";
            txtbx_Municipio.Size = new Size(135, 23);
            txtbx_Municipio.TabIndex = 1;
            // 
            // Panel_CP
            // 
            Panel_CP.ColumnCount = 1;
            Panel_CP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_CP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_CP.Controls.Add(lbl_Cp, 0, 1);
            Panel_CP.Controls.Add(txtbx_CP, 0, 0);
            Panel_CP.Dock = DockStyle.Fill;
            Panel_CP.Location = new Point(210, 343);
            Panel_CP.Name = "Panel_CP";
            Panel_CP.RowCount = 2;
            Panel_CP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_CP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_CP.Size = new Size(201, 79);
            Panel_CP.TabIndex = 2;
            // 
            // lbl_Cp
            // 
            lbl_Cp.AutoSize = true;
            lbl_Cp.Dock = DockStyle.Fill;
            lbl_Cp.Location = new Point(3, 39);
            lbl_Cp.Name = "lbl_Cp";
            lbl_Cp.Size = new Size(195, 40);
            lbl_Cp.TabIndex = 2;
            lbl_Cp.Text = "Codigo Postal";
            lbl_Cp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_CP
            // 
            txtbx_CP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_CP.Location = new Point(33, 3);
            txtbx_CP.Name = "txtbx_CP";
            txtbx_CP.Size = new Size(135, 23);
            txtbx_CP.TabIndex = 1;
            txtbx_CP.KeyPress += OnOnlyNumberKeyPress;
            // 
            // Panel_Ciudad
            // 
            Panel_Ciudad.ColumnCount = 1;
            Panel_Ciudad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_Ciudad.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_Ciudad.Controls.Add(lbl_Ciudad, 0, 1);
            Panel_Ciudad.Controls.Add(txtbx_ciudad, 0, 0);
            Panel_Ciudad.Dock = DockStyle.Fill;
            Panel_Ciudad.Location = new Point(417, 343);
            Panel_Ciudad.Name = "Panel_Ciudad";
            Panel_Ciudad.RowCount = 2;
            Panel_Ciudad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Ciudad.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_Ciudad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Panel_Ciudad.Size = new Size(201, 79);
            Panel_Ciudad.TabIndex = 2;
            // 
            // lbl_Ciudad
            // 
            lbl_Ciudad.AutoSize = true;
            lbl_Ciudad.Dock = DockStyle.Fill;
            lbl_Ciudad.Location = new Point(3, 39);
            lbl_Ciudad.Name = "lbl_Ciudad";
            lbl_Ciudad.Size = new Size(195, 40);
            lbl_Ciudad.TabIndex = 2;
            lbl_Ciudad.Text = "Ciudad";
            lbl_Ciudad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_ciudad
            // 
            txtbx_ciudad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_ciudad.Location = new Point(33, 3);
            txtbx_ciudad.Name = "txtbx_ciudad";
            txtbx_ciudad.Size = new Size(135, 23);
            txtbx_ciudad.TabIndex = 1;
            // 
            // Panel_estado
            // 
            Panel_estado.ColumnCount = 1;
            Panel_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Panel_estado.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Panel_estado.Controls.Add(lbl_edo, 0, 1);
            Panel_estado.Controls.Add(txtbx_estado, 0, 0);
            Panel_estado.Dock = DockStyle.Fill;
            Panel_estado.Location = new Point(624, 343);
            Panel_estado.Name = "Panel_estado";
            Panel_estado.RowCount = 2;
            Panel_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_estado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Panel_estado.Size = new Size(203, 79);
            Panel_estado.TabIndex = 2;
            // 
            // lbl_edo
            // 
            lbl_edo.AutoSize = true;
            lbl_edo.Dock = DockStyle.Fill;
            lbl_edo.Location = new Point(3, 39);
            lbl_edo.Name = "lbl_edo";
            lbl_edo.Size = new Size(197, 40);
            lbl_edo.TabIndex = 2;
            lbl_edo.Text = "Estado";
            lbl_edo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_estado
            // 
            txtbx_estado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtbx_estado.Location = new Point(34, 3);
            txtbx_estado.Name = "txtbx_estado";
            txtbx_estado.Size = new Size(135, 23);
            txtbx_estado.TabIndex = 1;
            // 
            // Lbl_title
            // 
            tableLayoutPanel1.SetColumnSpan(Lbl_title, 2);
            Lbl_title.Dock = DockStyle.Fill;
            Lbl_title.Location = new Point(3, 0);
            Lbl_title.Name = "Lbl_title";
            Lbl_title.Padding = new Padding(5, 20, 5, 5);
            Lbl_title.Size = new Size(408, 85);
            Lbl_title.TabIndex = 0;
            Lbl_title.Text = "NAN";
            Lbl_title.TextAlign = ContentAlignment.TopCenter;
            // 
            // Panel_botones
            // 
            tableLayoutPanel1.SetColumnSpan(Panel_botones, 4);
            Panel_botones.Controls.Add(Tabla_btn_registrar);
            Panel_botones.Controls.Add(Tabla_btn_actualizar_usuario);
            Panel_botones.Dock = DockStyle.Fill;
            Panel_botones.Location = new Point(3, 428);
            Panel_botones.Name = "Panel_botones";
            Panel_botones.Size = new Size(824, 79);
            Panel_botones.TabIndex = 3;
            // 
            // Tabla_btn_registrar
            // 
            Tabla_btn_registrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tabla_btn_registrar.ColumnCount = 2;
            Tabla_btn_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_btn_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_btn_registrar.Controls.Add(btn_registrar, 0, 0);
            Tabla_btn_registrar.Controls.Add(btn_limpiar, 1, 0);
            Tabla_btn_registrar.Dock = DockStyle.Fill;
            Tabla_btn_registrar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            Tabla_btn_registrar.Location = new Point(0, 0);
            Tabla_btn_registrar.Name = "Tabla_btn_registrar";
            Tabla_btn_registrar.RowCount = 1;
            Tabla_btn_registrar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tabla_btn_registrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_btn_registrar.Size = new Size(824, 79);
            Tabla_btn_registrar.TabIndex = 6;
            // 
            // btn_registrar
            // 
            btn_registrar.Anchor = AnchorStyles.None;
            btn_registrar.Location = new Point(118, 21);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(176, 37);
            btn_registrar.TabIndex = 11;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Anchor = AnchorStyles.None;
            btn_limpiar.Location = new Point(530, 21);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(176, 37);
            btn_limpiar.TabIndex = 12;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += Btn_limpiar_Click;
            // 
            // Tabla_btn_actualizar_usuario
            // 
            Tabla_btn_actualizar_usuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tabla_btn_actualizar_usuario.ColumnCount = 2;
            Tabla_btn_actualizar_usuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_btn_actualizar_usuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_btn_actualizar_usuario.Controls.Add(btn_bloquear, 1, 0);
            Tabla_btn_actualizar_usuario.Controls.Add(btn_actualizar, 0, 0);
            Tabla_btn_actualizar_usuario.Dock = DockStyle.Fill;
            Tabla_btn_actualizar_usuario.Location = new Point(0, 0);
            Tabla_btn_actualizar_usuario.Name = "Tabla_btn_actualizar_usuario";
            Tabla_btn_actualizar_usuario.RowCount = 1;
            Tabla_btn_actualizar_usuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tabla_btn_actualizar_usuario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_btn_actualizar_usuario.Size = new Size(824, 79);
            Tabla_btn_actualizar_usuario.TabIndex = 7;
            // 
            // btn_bloquear
            // 
            btn_bloquear.Anchor = AnchorStyles.None;
            btn_bloquear.Location = new Point(495, 27);
            btn_bloquear.Margin = new Padding(0, 0, 100, 0);
            btn_bloquear.MaximumSize = new Size(145, 25);
            btn_bloquear.Name = "btn_bloquear";
            btn_bloquear.Size = new Size(145, 25);
            btn_bloquear.TabIndex = 11;
            btn_bloquear.Text = "Desbloquear";
            btn_bloquear.UseVisualStyleBackColor = true;
            btn_bloquear.Click += btn_bloquear_Click;
            // 
            // btn_actualizar
            // 
            btn_actualizar.Anchor = AnchorStyles.None;
            btn_actualizar.Location = new Point(183, 27);
            btn_actualizar.Margin = new Padding(100, 0, 0, 0);
            btn_actualizar.MaximumSize = new Size(145, 25);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(145, 25);
            btn_actualizar.TabIndex = 12;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // Tabla_botones_registrar
            // 
            Tabla_botones_registrar.ColumnCount = 2;
            Tabla_botones_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_botones_registrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Tabla_botones_registrar.Dock = DockStyle.Fill;
            Tabla_botones_registrar.Location = new Point(0, 0);
            Tabla_botones_registrar.Name = "Tabla_botones_registrar";
            Tabla_botones_registrar.RowCount = 1;
            Tabla_botones_registrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Tabla_botones_registrar.Size = new Size(200, 100);
            Tabla_botones_registrar.TabIndex = 0;
            // 
            // Error
            // 
            Error.ContainerControl = this;
            // 
            // VistaModificarAgregarUsuario
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "VistaModificarAgregarUsuario";
            Size = new Size(830, 510);
            tableLayoutPanel1.ResumeLayout(false);
            PanelNombre.ResumeLayout(false);
            PanelNombre.PerformLayout();
            Panel_Ap.ResumeLayout(false);
            Panel_Ap.PerformLayout();
            Panel_AM.ResumeLayout(false);
            Panel_AM.PerformLayout();
            Panel_Tel.ResumeLayout(false);
            Panel_Tel.PerformLayout();
            Panel_nss.ResumeLayout(false);
            Panel_nss.PerformLayout();
            Panel_Fecha_nacimiento.ResumeLayout(false);
            Panel_Fecha_nacimiento.PerformLayout();
            Panel_RFC.ResumeLayout(false);
            Panel_RFC.PerformLayout();
            Panel_CURP.ResumeLayout(false);
            Panel_CURP.PerformLayout();
            Panel_correo.ResumeLayout(false);
            Panel_correo.PerformLayout();
            Panel_Contraseña.ResumeLayout(false);
            Panel_Contraseña.PerformLayout();
            Panel_municipio.ResumeLayout(false);
            Panel_municipio.PerformLayout();
            Panel_CP.ResumeLayout(false);
            Panel_CP.PerformLayout();
            Panel_Ciudad.ResumeLayout(false);
            Panel_Ciudad.PerformLayout();
            Panel_estado.ResumeLayout(false);
            Panel_estado.PerformLayout();
            Panel_botones.ResumeLayout(false);
            Tabla_btn_registrar.ResumeLayout(false);
            Tabla_btn_actualizar_usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Error).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_title;
        private TableLayoutPanel Panel_Tel;
        private TableLayoutPanel Panel_nss;
        private TableLayoutPanel Panel_estado;
        private TableLayoutPanel Panel_Contraseña;
        private TableLayoutPanel Panel_Ciudad;
        private TableLayoutPanel Panel_correo;
        private TableLayoutPanel Panel_CP;
        private TableLayoutPanel Panel_CURP;
        private TableLayoutPanel Panel_municipio;
        private TableLayoutPanel Panel_RFC;
        private TableLayoutPanel Panel_AM;
        private TableLayoutPanel Panel_Ap;
        private TableLayoutPanel PanelNombre;
        private TableLayoutPanel Panel_Fecha_nacimiento;
        private TextBox txtbx_NSS;
        private TextBox txtbx_tel;
        private TextBox txtbx_psswrd;
        private TextBox txtbx_ciudad;
        private TextBox txtbx_correo;
        private TextBox txtbx_CP;
        private TextBox txtbx_CURP;
        private TextBox txtbx_Municipio;
        private TextBox txtbx_RFC;
        private TextBox txtbx_AM;
        private TextBox txtbx_AP;
        private TextBox txtbx_Nombre;
        private DateTimePicker Dtpck_FCN;
        private Label lbl_nombre;
        private Label lbl_fechaN;
        private Label lbl_NSS;
        private Label lbl_numTel;
        private Label Contraseña;
        private Label lbl_Ciudad;
        private Label lbl_correo;
        private Label lbl_Cp;
        private Label lbl_CURP;
        private Label lbl_Municipio;
        private Label lbl_RFC;
        private Label lbl_AM;
        private Label lbl_Ap;
        private TableLayoutPanel Tabla_btn_registrar;
        private TableLayoutPanel Tabla_botones_registrar;
        private TableLayoutPanel Tabla_btn_actualizar_usuario;
        private Button btn_bloquear;
        private Button btn_actualizar;
        private Panel Panel_botones;
        private Button btn_registrar;
        private Button btn_limpiar;
        private ErrorProvider Error;
        private Label lbl_edo;
        private TextBox txtbx_estado;
    }
}
