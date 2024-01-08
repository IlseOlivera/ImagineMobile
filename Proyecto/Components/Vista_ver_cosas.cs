using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;

namespace Proyecto_BD.Views
{
    public partial class Vista_ver_cosas : UserControl
    {
        public Vista_ver_cosas(TypeOfView vista)
        {
            InitializeComponent();

            switch (vista)
            {
                case TypeOfView.See_products:
                    {
                        lbl_title.Text = "Buscar por numero de serie: ";
                        List<Productos> productos = DBContext.SeeAllProducts();
                        int i = 1, j = 0;
                        foreach (Productos p in productos)
                        {
                            Card carta = new Card(p, vista)
                            {
                                Location = new Point(273 * i, j),
                            };
                            i = i <= 3 ? i + 1 : 0;
                            j = i <= 3 ? j + 285 : j;
                            Panel_vista_cartas.Controls.Add(carta);
                        }
                        break;
                    }
                case TypeOfView.See_empleoyees:
                    {
                        lbl_title.Text = "Buscar por RFC o por CURP: ";
                        List<Usuarios> productos = DBContext.SeeAllEmployee();
                        int i = 1, j = 0;
                        foreach (Usuarios p in productos)
                        {
                            Card carta = new Card(p, vista)
                            {
                                Location = new Point(273 * i, j),
                            };
                            i = i <= 3 ? i + 1 : 0;
                            j = i <= 3 ? j + 285 : j;
                            Panel_vista_cartas.Controls.Add(carta);
                        }
                        break;
                    }
                    case TypeOfView.See_supplier:
                    {
                        lbl_title.Text = "Buscar por RFC o Por nombre al proveedor ";
                        List<Proveedor> productos = DBContext.SeeAllSupplier();
                        int i = 1, j = 0;
                        foreach (Proveedor p in productos)
                        {
                            Card carta = new Card(p, vista)
                            {
                                Location = new Point(273 * i, j),
                            };
                            i = i <= 3 ? i + 1 : 0;
                            j = i <= 3 ? j + 285 : j;
                            Panel_vista_cartas.Controls.Add(carta);
                        }
                        break;
                    }
            }
        }
    }
}
