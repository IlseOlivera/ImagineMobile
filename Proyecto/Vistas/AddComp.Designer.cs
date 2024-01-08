namespace Proyecto_BD.Components
{
    partial class AddComp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtbx_output = new TextBox();
            btn_accept = new Button();
            btn_cancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtbx_output, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_accept, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_cancel, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5, 0, 5, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(366, 208);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 69);
            label1.TabIndex = 0;
            label1.Text = "Agrega_mas_informacion";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbx_output
            // 
            txtbx_output.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtbx_output, 2);
            txtbx_output.Location = new Point(8, 92);
            txtbx_output.MaxLength = 30;
            txtbx_output.Name = "txtbx_output";
            txtbx_output.Size = new Size(350, 23);
            txtbx_output.TabIndex = 1;
            // 
            // btn_accept
            // 
            btn_accept.Anchor = AnchorStyles.None;
            btn_accept.Location = new Point(227, 160);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new Size(90, 25);
            btn_accept.TabIndex = 2;
            btn_accept.Text = "Aceptar";
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.None;
            btn_cancel.Location = new Point(49, 160);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(90, 25);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // AddComp
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(366, 208);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "AddComp";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Complementa la informacion";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtbx_output;
        private Button btn_accept;
        private Button btn_cancel;
    }
}