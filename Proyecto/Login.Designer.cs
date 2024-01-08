namespace Proyecto_BD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Titulo = new Label();
            Main_body = new TableLayoutPanel();
            Btn_iniciar_sesion = new Button();
            TxtBox_pass = new TextBox();
            Login_title = new Label();
            TxtBx_usr = new TextBox();
            Usr_label = new Label();
            Lbl_contrasena = new Label();
            tableLayoutPanel1.SuspendLayout();
            Main_body.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Titulo, 0, 0);
            tableLayoutPanel1.Controls.Add(Main_body, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.Anchor = AnchorStyles.None;
            Titulo.Location = new Point(350, 33);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(100, 23);
            Titulo.TabIndex = 0;
            Titulo.Text = "Imagine Mobile";
            Titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main_body
            // 
            Main_body.Anchor = AnchorStyles.None;
            Main_body.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Main_body.BackColor = SystemColors.ButtonShadow;
            Main_body.ColumnCount = 1;
            Main_body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Main_body.Controls.Add(Btn_iniciar_sesion, 0, 5);
            Main_body.Controls.Add(TxtBox_pass, 0, 4);
            Main_body.Controls.Add(Login_title, 0, 0);
            Main_body.Controls.Add(TxtBx_usr, 0, 2);
            Main_body.Controls.Add(Usr_label, 0, 1);
            Main_body.Controls.Add(Lbl_contrasena, 0, 3);
            Main_body.Location = new Point(233, 112);
            Main_body.Name = "Main_body";
            Main_body.RowCount = 6;
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Main_body.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            Main_body.Size = new Size(333, 316);
            Main_body.TabIndex = 1;
            // 
            // Btn_iniciar_sesion
            // 
            Btn_iniciar_sesion.Anchor = AnchorStyles.None;
            Btn_iniciar_sesion.Location = new Point(100, 261);
            Btn_iniciar_sesion.Name = "Btn_iniciar_sesion";
            Btn_iniciar_sesion.Size = new Size(133, 44);
            Btn_iniciar_sesion.TabIndex = 6;
            Btn_iniciar_sesion.Text = "Iniciar Sesion";
            Btn_iniciar_sesion.UseVisualStyleBackColor = true;
            Btn_iniciar_sesion.Click += Btn_iniciar_sesion_Click;
            // 
            // TxtBox_pass
            // 
            TxtBox_pass.Anchor = AnchorStyles.None;
            TxtBox_pass.Location = new Point(43, 208);
            TxtBox_pass.Name = "TxtBox_pass";
            TxtBox_pass.Size = new Size(247, 23);
            TxtBox_pass.TabIndex = 1;
            // 
            // Login_title
            // 
            Login_title.Dock = DockStyle.Fill;
            Login_title.Location = new Point(3, 0);
            Login_title.Name = "Login_title";
            Login_title.Size = new Size(327, 63);
            Login_title.TabIndex = 2;
            Login_title.Text = "Iniciar Sesión";
            Login_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtBx_usr
            // 
            TxtBx_usr.Anchor = AnchorStyles.None;
            TxtBx_usr.Location = new Point(49, 114);
            TxtBx_usr.Name = "TxtBx_usr";
            TxtBx_usr.Size = new Size(235, 23);
            TxtBx_usr.TabIndex = 0;
            // 
            // Usr_label
            // 
            Usr_label.Anchor = AnchorStyles.None;
            Usr_label.Location = new Point(116, 67);
            Usr_label.Name = "Usr_label";
            Usr_label.Size = new Size(100, 23);
            Usr_label.TabIndex = 4;
            Usr_label.Text = "Usuario";
            Usr_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lbl_contrasena
            // 
            Lbl_contrasena.Anchor = AnchorStyles.None;
            Lbl_contrasena.AutoSize = true;
            Lbl_contrasena.Location = new Point(133, 165);
            Lbl_contrasena.Name = "Lbl_contrasena";
            Lbl_contrasena.Size = new Size(67, 15);
            Lbl_contrasena.TabIndex = 5;
            Lbl_contrasena.Text = "Contraseña";
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            FormClosed += Login_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            Main_body.ResumeLayout(false);
            Main_body.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Titulo;
        private TableLayoutPanel Main_body;
        private Label Login_title;
        private TextBox TxtBx_usr;
        private Label Usr_label;
        private Label Lbl_contrasena;
        private TextBox TxtBox_pass;
        private Button Btn_iniciar_sesion;
    }
}
