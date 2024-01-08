using MySql.Data.MySqlClient;
using Proyecto_BD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD.Vistas
{
    public partial class Vista_agregar_venta : Form
    {
        // Metodo para generar todas las columnas del datagridview
        private void GenerateHeaders()
        {
            // Se genera el nombre de la columna, el texto de la misma, si esta en solo lectura y si es visible
            DataGridViewColumn[] columns = {
            new DataGridViewTextBoxColumn(){Name = "Id_venta", HeaderText="No de venta", ReadOnly = true, Visible = false},
            new DataGridViewTextBoxColumn(){Name = "modelo", HeaderText="Modelo del producto", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "precio", HeaderText="Precio", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "color", HeaderText="Color", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "material", HeaderText="Material", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "tamaño", HeaderText="Tamaño", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "especificacion", HeaderText="Caracteristicas especificas", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "comunicacion", HeaderText="Metodos de comunicacion", ReadOnly = true},
            new DataGridViewTextBoxColumn(){Name = "accesorios", HeaderText="Accesorios", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "tecnologias", HeaderText="Tecnologias", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "compatibilidad", HeaderText="Compatibilidad", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "Cantidad en stock", HeaderText="Cantidad", ReadOnly = true},
            new DataGridViewTextBoxColumn(){ Name = "Cantidad a vender", HeaderText="Cantidad", ReadOnly = true},
            new DataGridViewCheckBoxColumn(){Name= "chbx_selected", HeaderText="Selected",FalseValue = false, TrueValue = true}
            };
            //Se agrega todas las columnas
            dataGridView_productos.Columns.AddRange(columns);
        }
        // Metodo para ordenar los productos en las filas del data gridview
        private void ordenarProductoEnElDataGrid(Productos productos)
        {
            //Se toma el metodo y solo se ordena las propiedades conforme esta la columna
            dataGridView_productos.Rows.Add(
                productos.Id_productos,
                productos.modelo,
                productos.precio,
                productos.campos_Extra.color ?? "No hay informacion",
                productos.campos_Extra.material ?? "No hay informacion",
                productos.campos_Extra.Tamaño is not null ? string.Join("cm X", productos.campos_Extra.Tamaño) :
                "No hay informacion",
                productos.campos_Extra.especificacion?.caracteristica ?? "No hay informacion",
                productos.campos_Extra.comunicacion?.caracteristica ?? "No hay informacion",
                productos.campos_Extra.accesorios?.caracteristica ?? "No hay informacion",
                productos.campos_Extra.tecnologias?.caracteristica ?? "No hay informacion",
                productos.campos_Extra.comunicacion?.caracteristica ?? "No hay informacion",
                productos.cantidad,
                "",
                false);
        }
        //Metodo para actualizar las ventas
        public Vista_agregar_venta()
        {
            InitializeComponent();
            GenerateHeaders();
            List<Productos> productos = DBContext.Return_productAll();
            foreach (Productos producto in productos)
                ordenarProductoEnElDataGrid(producto);
        }
        //Cuando se acepta que ya se cumplieron las ventas
        private void btn_acceptar_Click(object sender, EventArgs e)
        {
            //Variable para calcular el total de la venta
            double venta_total = 0;
            //Variable para calcular cuantos productos se vendieron en total
            int vendidos_total = 0;
            //Variable para cuidar si es que hay un error
            bool error = false;
            //Lista de tuplas con cadena y entero, la cadena es el id del producto que se guardo y el entero es al cantidad que se compro
            List<(string, int)> vendidos = new List<(string, int)>();
            //Por cada fila (vamos a mapear el dateg gridview)
            foreach (DataGridViewRow fila in dataGridView_productos.Rows)
            {
                //Convertiremos la ultima columna que es el checkbox para saber si es booleana y esta palomeada
                if (Convert.ToBoolean(fila.Cells["chbx_selected"].Value))
                {
                    //Si el campo no esta vacio se guardara
                    if (fila.Cells[12].Value.ToString() != string.Empty)
                    {
                        //La cantidad que se vendio
                        int cant = int.Parse(fila.Cells[12].Value.ToString());
                        //El precio al que se vendio
                        int precio = int.Parse(fila.Cells[2].Value.ToString());
                        // total de la venta
                        venta_total += (cant * precio);
                        //El total vendido
                        vendidos_total += cant;
                        //Y se va a agregar a la lista de vendido
                        vendidos.Add((fila.Cells[0].Value.ToString(), cant));
                    }
                    // En caso contrario
                    else
                    {
                        //Se va a enviar un error, mostrando en que fila esta el error
                        MessageBox.Show($"En la fila No. {fila.Index + 1} el valor ingresado no es valido ingreselo de nuevo", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Se va a guardar el error
                        error = true;
                    }
                }
            }
            //Se tiene que tener almenos un producto vendido y debe cumplir con que se envio bien el formato
            if (vendidos.Count <= 0 && error)
                // Sino envia un mensaje de que se deben corregir
                MessageBox.Show("Para agregar la venta debe seleccionar algunos de los productos o corregir el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Se realiza un instancia de la venta con todos los parametros
                Venta venta = new Venta() { Total_Venta = venta_total, Cant_venta = vendidos.Count };
                //Se realiza un try
                try
                {
                    if (DBContext.InsertarVenta(venta) & DBContext.InsertarProductosVentas(vendidos, venta.Id_venta))
                    {
                     // Se envia la confirmacion de que se agrego la venta  
                        MessageBox.Show("La venta fue agregada correctamente", "Venta Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Se da un resultado del dialogo como aceptado
                        DialogResult = DialogResult.OK;
                        //Se cierra el formulario
                        this.Close();
                    }
                }
                //Si hubo un error de SQL, se va a mostrar que error y porque
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al registrar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            //Se da un resultado del dialogo como cancelado
            DialogResult = DialogResult.Cancel;
            //Se cierra el formulario
            this.Close();
        }
        //tenemos un delegado para cuando se va de a una de las celdas del datagridview
        private void dataGridView_productos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Si la columna es la 13, donde esta el checkbox
            if (e.ColumnIndex == 13)
            {
                //Se obtiene el checkbox
                DataGridViewCheckBoxCell cell = dataGridView_productos.Rows[e.RowIndex].Cells["chbx_selected"] as DataGridViewCheckBoxCell;
                //Se obtiene su valor, convirtiendolo en booleano
                if (Convert.ToBoolean(cell.Value))
                {
                    //Si se cancela, el textbox se limpiara
                    dataGridView_productos.Rows[cell.RowIndex].Cells[12].Value = "";
                    //Se volvera de solo lectura
                    dataGridView_productos.Rows[cell.RowIndex].Cells[12].ReadOnly = true;
                }
                else
                    //Se podra editar el combobox
                    dataGridView_productos.Rows[cell.RowIndex].Cells[12].ReadOnly = false;
            }
        }
        //delegado para cuando el combobox este siendo editado
        private void dataGridView_productos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Se revisa que el control sea un combobox
            if (e.Control is TextBox)
            {
                // Se asigna la variable
                TextBox textBox = e.Control as TextBox;
                //Si no es nulo
                if (textBox != null)
                {
                    //Se desuscribe del delegado o evento al presionar la tecla
                    textBox.KeyPress -= NumericTextBox_KeyPress;
                    // Se suscribe al delegado o evento de presionar la tecla
                    textBox.KeyPress += NumericTextBox_KeyPress;
                    //Se desuscribe del delegado o evento al abandonar el textbox 
                    textBox.Leave -= NumericTextBox_Leave;
                    // Se suscribe al delegado o evento de abandonar el textbox 
                    textBox.Leave += NumericTextBox_Leave;
                }
            }
        }
        //Delegado para cuando se presiona una tecla
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se revisa que lo que este siendo presionado sea valido (numero y para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar is (char)Keys.Back)
                //No se retiene el evento
                e.Handled = false;
            else
                //Se retiene el evento
                e.Handled = true;
        }
        //Delegado para cuando se sale del textbox
        private void NumericTextBox_Leave(object sender, EventArgs e)
        {
            //Se isntancia el objeto
            TextBox text = sender as TextBox;
            //Se revisa que el textbox no sea vacio y que no sea menor a 1
            if (text.Text != string.Empty && int.Parse(text.Text) < 1)
            {
                //Envia mensaje de error
                MessageBox.Show("El valor ingresado debe ser mayor a 0", "Error numerico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Se limpia el text box
                text.Text = string.Empty;
            }
        }

    }
}
