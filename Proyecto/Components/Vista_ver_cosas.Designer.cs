namespace Proyecto_BD.Views
{
    partial class Vista_ver_cosas
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
            lbl_title = new Label();
            txtbx_searchBar = new TextBox();
            Panel_vista_cartas = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lbl_title, 0, 0);
            tableLayoutPanel1.Controls.Add(txtbx_searchBar, 1, 0);
            tableLayoutPanel1.Controls.Add(Panel_vista_cartas, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(810, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Location = new Point(3, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(237, 102);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "NaN";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_searchBar
            // 
            txtbx_searchBar.Anchor = AnchorStyles.None;
            txtbx_searchBar.Location = new Point(249, 39);
            txtbx_searchBar.Name = "txtbx_searchBar";
            txtbx_searchBar.Size = new Size(554, 23);
            txtbx_searchBar.TabIndex = 1;
            // 
            // Panel_vista_cartas
            // 
            Panel_vista_cartas.AutoScroll = true;
            tableLayoutPanel1.SetColumnSpan(Panel_vista_cartas, 2);
            Panel_vista_cartas.Dock = DockStyle.Fill;
            Panel_vista_cartas.Location = new Point(3, 105);
            Panel_vista_cartas.Name = "Panel_vista_cartas";
            Panel_vista_cartas.Size = new Size(804, 402);
            Panel_vista_cartas.TabIndex = 2;
            // 
            // Vista_ver_cosas
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(tableLayoutPanel1);
            Name = "Vista_ver_cosas";
            Size = new Size(810, 510);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_title;
        private TextBox txtbx_searchBar;
        private FlowLayoutPanel Panel_vista_cartas;
    }
}
