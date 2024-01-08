using Proyecto_BD.Components;
using Proyecto_BD.Controles;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using Proyecto_BD.Vistas;
using System.Globalization;

namespace Proyecto_BD.Views
{
    public partial class Card : UserControl
    {
        private TextInfo info = new CultureInfo("es-MX", false).TextInfo;
        private TypeOfView parentView;
        public Card(object informacion, TypeOfView parentView)
        {
            this.parentView = parentView;
            InitializeComponent();
            switch (parentView)
            {
                case TypeOfView.See_products:
                    {
                        Productos producto = (Productos)informacion;
                        txtbx_hidden.Text = producto.Id_productos;
                        lbl_nombre_producto.Text = info.ToTitleCase(producto.tipo.ToString().ToLower());
                        lbl_info_extra.Text = informacion.ToString();
                        break;
                    }

                case TypeOfView.See_empleoyees:
                    {
                        Usuarios usuarios = (Usuarios)informacion;
                        txtbx_hidden.Text = usuarios.id_US;
                        lbl_nombre_producto.Text = usuarios.Nom_US;
                        lbl_info_extra.Text = usuarios.ToString();
                        break;
                    }
                case TypeOfView.See_supplier:
                    {
                        Proveedor proveedor = (Proveedor)informacion;
                        txtbx_hidden.Text = proveedor.Id_Prov;
                        lbl_nombre_producto.Text = proveedor.Nom_Prov;
                        lbl_info_extra.Text = proveedor.ToString();
                        break;
                    }
            }
        }

        private void btn_voltear_Click(object sender, EventArgs e)
        {
            Panel_info_basico.Visible = false;
            Panel_info.Visible = true;
        }

        private void OnClick_enviar_a_editar(object sender, EventArgs e)
        {
            Form FormularioPadre = Parent.TopLevelControl as Form;
            TableLayoutPanel Panel_vista = FormularioPadre.Controls[0] as TableLayoutPanel;
            Panel_vista.Controls.RemoveAt(1);
            if (parentView == TypeOfView.See_products)
            {
                Panel_vista.Controls.Add(new VistaAgregarActualizarProducto(TypeOfView.Update_product, this.Controls.Find("txtbx_hidden", true).FirstOrDefault().Text), 0, 1);
            }
            else if (parentView == TypeOfView.See_empleoyees)
            {
                //Panel_vista.Controls.Add(new VistaModificarAgregarUsuario(TypeOfView.Update_employee, this.Controls.Find("txtbx_hidden", true).FirstOrDefault().Text), 0, 1);
                Form1 form1 = new Form1(this.Controls.Find("txtbx_hidden", true).FirstOrDefault().Text);
                form1.ShowDialog();
            }
            else if (parentView == TypeOfView.See_supplier)
            {
                //Panel_vista.Controls.Add(new Vista_nuevo_proveedor(TypeOfView.Update_supplier, this.Controls.Find("txtbx_hidden", true).FirstOrDefault().Text), 0, 1);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Panel_info_basico.Visible = true;
            Panel_info.Visible = false;
        }
    }
}
