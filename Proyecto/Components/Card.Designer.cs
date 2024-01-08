namespace Proyecto_BD.Views
{
    partial class Card
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
            Panel_info_basico = new Panel();
            txtbx_hidden = new TextBox();
            lbl_nombre_producto = new Label();
            btn_editar = new Button();
            btn_voltear = new Button();
            Panel_info = new Panel();
            Editar_2 = new Button();
            btn_regresar = new Button();
            lbl_info_extra = new Label();
            Panel_info_basico.SuspendLayout();
            Panel_info.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_info_basico
            // 
            Panel_info_basico.BackColor = SystemColors.ActiveCaption;
            Panel_info_basico.Controls.Add(txtbx_hidden);
            Panel_info_basico.Controls.Add(lbl_nombre_producto);
            Panel_info_basico.Controls.Add(btn_editar);
            Panel_info_basico.Controls.Add(btn_voltear);
            Panel_info_basico.Dock = DockStyle.Fill;
            Panel_info_basico.Location = new Point(0, 0);
            Panel_info_basico.Name = "Panel_info_basico";
            Panel_info_basico.Size = new Size(208, 255);
            Panel_info_basico.TabIndex = 1;
            // 
            // txtbx_hidden
            // 
            txtbx_hidden.Location = new Point(5, 8);
            txtbx_hidden.Name = "txtbx_hidden";
            txtbx_hidden.Size = new Size(100, 23);
            txtbx_hidden.TabIndex = 3;
            txtbx_hidden.Visible = false;
            // 
            // lbl_nombre_producto
            // 
            lbl_nombre_producto.ForeColor = Color.WhiteSmoke;
            lbl_nombre_producto.Location = new Point(12, 229);
            lbl_nombre_producto.Name = "lbl_nombre_producto";
            lbl_nombre_producto.Size = new Size(100, 23);
            lbl_nombre_producto.TabIndex = 2;
            lbl_nombre_producto.Text = "Producto";
            lbl_nombre_producto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(130, 229);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 25);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += OnClick_enviar_a_editar;
            // 
            // btn_voltear
            // 
            btn_voltear.Location = new Point(130, 3);
            btn_voltear.Name = "btn_voltear";
            btn_voltear.Size = new Size(75, 25);
            btn_voltear.TabIndex = 0;
            btn_voltear.Text = "Ver mas";
            btn_voltear.UseVisualStyleBackColor = true;
            btn_voltear.Click += btn_voltear_Click;
            // 
            // Panel_info
            // 
            Panel_info.BackColor = SystemColors.ActiveCaption;
            Panel_info.Controls.Add(Editar_2);
            Panel_info.Controls.Add(btn_regresar);
            Panel_info.Controls.Add(lbl_info_extra);
            Panel_info.Dock = DockStyle.Fill;
            Panel_info.Location = new Point(0, 0);
            Panel_info.Name = "Panel_info";
            Panel_info.Padding = new Padding(5);
            Panel_info.Size = new Size(208, 255);
            Panel_info.TabIndex = 0;
            // 
            // Editar_2
            // 
            Editar_2.Location = new Point(5, 229);
            Editar_2.Name = "Editar_2";
            Editar_2.Size = new Size(75, 25);
            Editar_2.TabIndex = 2;
            Editar_2.Text = "Editar";
            Editar_2.UseVisualStyleBackColor = true;
            Editar_2.Click += OnClick_enviar_a_editar;
            // 
            // btn_regresar
            // 
            btn_regresar.Location = new Point(130, 229);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(75, 25);
            btn_regresar.TabIndex = 1;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // lbl_info_extra
            // 
            lbl_info_extra.Dock = DockStyle.Top;
            lbl_info_extra.ForeColor = Color.WhiteSmoke;
            lbl_info_extra.Location = new Point(5, 5);
            lbl_info_extra.Name = "lbl_info_extra";
            lbl_info_extra.Size = new Size(198, 221);
            lbl_info_extra.TabIndex = 0;
            lbl_info_extra.Text = "Informacion exta";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel_info_basico);
            Controls.Add(Panel_info);
            Margin = new Padding(15, 20, 15, 20);
            Name = "Card";
            Size = new Size(208, 255);
            Panel_info_basico.ResumeLayout(false);
            Panel_info_basico.PerformLayout();
            Panel_info.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_info_basico;
        private Button btn_voltear;
        private Button btn_editar;
        private Label lbl_nombre_producto;
        private Panel Panel_info;
        private Label lbl_info_extra;
        private Button btn_regresar;
        private TextBox txtbx_hidden;
        private Button Editar_2;
    }
}
