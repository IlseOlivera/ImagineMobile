using Proyecto_BD.Components;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using System.Drawing;

namespace Proyecto_BD.Vistas
{
    public partial class Form_Add_product_for_supplier : Form
    {
        //Instanciamos la lista de los productos que se agregaron
        public List<Productos> productos_agregados = new List<Productos>();
        //Contructor del formulario
        public Form_Add_product_for_supplier()
        {
            //Pintamos el formulario
            InitializeComponent();
        }
        //Delegado o evento para cuando se carga el formulario
        private void Form_Add_product_for_supplier_Load(object sender, EventArgs e)
        {
            //Se instancia la vista para agregar el Producto
            VistaAgregarActualizarProducto vista = new VistaAgregarActualizarProducto(TypeOfView.Add_product_for_supplier, ref productos_agregados);
            //Se le da tamaño a la ventana
            vista.Size = new Size(650, 420);
            //Se crea el boton de salir
            Button salida = new Button() { Name = "btn_salida", Text = "Salir", Anchor = AnchorStyles.None, Size = new Size(90, 25) };
            //Se suscribe al delegado
            salida.Click += btn_salida_Click;
            //Se agrega a la tabla en la columna 0 fila 4
            vista.tableLayoutPanel1.Controls.Add(salida, 0, 4);
            //Se agrega el control
            this.Controls.Add(vista);
        }
        //Delegado para cuando se da el click de salir
        private void btn_salida_Click(object sender, EventArgs e)
        {
            //Message box para preguntar si quiere salir
            if (MessageBox.Show("¿Seguro que quiere salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
