using Proyecto_BD.Components;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using Proyecto_BD.Views;

namespace Proyecto_BD
{
    public partial class Vista_Empleados : Form
    {
        //Constructor del Formulario
        public Vista_Empleados()
        {
            //Pintamos el componente
            InitializeComponent();
        }
        //Generamos el delegado o el evento para cuando el combobox cambia de valor
        private void Combobox_selected_IndexChanged(object? sender, EventArgs e)
        {
            // El objeto que envia el delegado lo tomamos como combobox
            ComboBox combo = sender as ComboBox;
            //Obtenemos el objeto que se selecciono atraves del objeto enviado
            ComboboxItem item = combo.SelectedItem as ComboboxItem;
            //Creamos un objeto sin instancia para seleccionar que vamos a ver
            Vista_ver_cosas control_seleccionado;
            //Enviamos el valor
            switch (item.Value)
            {
                // Si es nulo enviamos un error
                case null:
                    {
                        MessageBox.Show("Seleccione una opcion valida por favor", "Opcion no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    // Si es para la vista de empleado
                case TypeOfView.See_empleoyees:
                    {
                        //Instanciamos la vista y le damos un parametro para que este seleccione lo que va a mostrar
                        control_seleccionado = new Vista_ver_cosas(TypeOfView.See_empleoyees);
                        //Removemos el segundo control que se encuentra en la tabla
                        table_vista.Controls.RemoveAt(1);
                        //Lo agregamos en la tabla en la columna 0 fila 1
                        table_vista.Controls.Add(control_seleccionado, 0, 1);
                        break;
                    }
                    //Si es para la vista de productos
                case TypeOfView.See_products:
                    {
                        //Instanciamos la vista y le damos un parametro para que este seleccione lo que va a mostrar
                        control_seleccionado = new Vista_ver_cosas(TypeOfView.See_products);
                        //Removemos el segundo control que se encuentra en la tabla
                        table_vista.Controls.RemoveAt(1);
                        //Lo agregamos en la tabla en la columna 0 fila 1
                        table_vista.Controls.Add(control_seleccionado, 0, 1);
                        break;
                    }
                    //Si es para al vista de proveedores
                case TypeOfView.See_supplier:
                    {
                        //Instanciamos la vista y le damos un parametro para que este seleccione lo que va a mostrar
                        control_seleccionado = new Vista_ver_cosas(TypeOfView.See_supplier);
                        //Removemos el segundo control que se encuentra en la tabla
                        table_vista.Controls.RemoveAt(1);
                        //Lo agregamos en la tabla en la columna 0 fila 1
                        table_vista.Controls.Add(control_seleccionado, 0, 1);
                        break;
                    }
            }
        }
        //Metodo o delegado para cuando se de clic
        private void btn_ver_Click(object sender, EventArgs e)
        {
            // Se busca si hay mas de un control en la tabla donde se ven los componentes
            if (table_vista.Controls.Count > 1)
                //Ya que sabemos que hay uno se borra
                table_vista.Controls.RemoveAt(1);
            //Se crea un objeto combobox para saber que tipo de tarjeta vamos a querer
            ComboBox combobox_select = new ComboBox()
            {
                //Le asignamos un nombre
                Name = "combobox_item",
                //Que no tenga ningun anchor (que se expanda para diseños responsivos)
                Anchor = AnchorStyles.None,
                //Le damos un tamaño de 200 pixeles x 50 pixeles
                Size = new Size(200, 50),
                //Le damos un margen de 30 pixeles
                Margin = new Padding(30)
            };
            //Generamos un item de combobox (clase generada por el programador)
            ComboboxItem[] items = new ComboboxItem[]
            {
                //Generamos un item estandar
                new ComboboxItem("Seleccione una opcion",null),
                //Generamos un item para que se vean los empleados
                new ComboboxItem("Ver empleados",TypeOfView.See_empleoyees),
                // Generamos unitem para que se vean los productos
                new ComboboxItem("Ver productos",TypeOfView.See_products),
                //Generamos un item para que se vean los proveedores
                new ComboboxItem("Ver Proveedores",TypeOfView.See_supplier),
            };
            //Agregamos el rango de items
            combobox_select.Items.AddRange(items);
            //Le decimos que seleccione el primero
            combobox_select.SelectedIndex = 0;
            //Le agregamos el evento o delegado para cuando haya un cambio de indice
            combobox_select.SelectedIndexChanged += Combobox_selected_IndexChanged;
            //Agregamos el combobox a la tabla en la columna 0 fila 1
            table_vista.Controls.Add(combobox_select, 0, 1);
        }       
        //Metodo o delegado para cuando se de clic

        private void btn_ver_ventas_Click(object sender, EventArgs e)
        {
            //Se vuelve a buscar si es que los controles son mas de uno
            if (table_vista.Controls.Count > 1)
                //Se borra el segundo control de la tabla
                table_vista.Controls.RemoveAt(1);
            //Se instancia el objeto para ser agregado a la tabla
            Ver_ventas vista = new Ver_ventas();
            //Se agrega a la tabla
            table_vista.Controls.Add(vista, 0, 1);
        }
        //Metodo o delegado para cuando se de clic
        private void btn_agregar_proveedor_Click(object sender, EventArgs e)
        {
            //Se vuelve a buscar si es que los controles son mas de uno
            if (table_vista.Controls.Count > 1)
                //Se borra el segundo control de la tabla
                table_vista.Controls.RemoveAt(1);
            //Se instancia el objeto para ser agregado a la tabla
            Vista_nuevo_proveedor vista = new Vista_nuevo_proveedor(TypeOfView.Regist_new_supplier, null);
            //Se agrega a la tabla
            table_vista.Controls.Add(vista, 0, 1);
        }
        //Metodo o delegado para cuando se de clic
        private void btn_agregar_productor_Click(object sender, EventArgs e)
        {
            //Se vuelve a buscar si es que los controles son mas de uno
            if (table_vista.Controls.Count > 1)
                //Se borra el segundo control de la tabla
                table_vista.Controls.RemoveAt(1);
            //Se instancia el objeto para ser agregado a la tabla
            VistaAgregarActualizarProducto vista = new VistaAgregarActualizarProducto(TypeOfView.Create_new_product, null);
            //Se agrega a la tabla
            table_vista.Controls.Add(vista, 0, 1);
        }
    }
}
