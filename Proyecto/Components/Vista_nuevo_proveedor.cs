using MySql.Data.MySqlClient;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using Proyecto_BD.Vistas;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_BD.Components
{
    public partial class Vista_nuevo_proveedor : UserControl
    {
        private TypeOfView tipoDeVista;

        private bool textbox_enable = false;

        private Proveedor provedor_a_actualizar;

        private Form_Add_product_for_supplier vista = new Form_Add_product_for_supplier();

        private void GenerarHeaders()
        {
            DataGridViewColumn[] columnas = new DataGridViewColumn[0];
            if (tipoDeVista == TypeOfView.Update_supplier)
                columnas = new DataGridViewColumn[]
                {
                new DataGridViewTextBoxColumn() { Visible = false, Name = "Id_producto" },
                new DataGridViewTextBoxColumn() { Name = "Modelo", HeaderText="Modelo del producto", ReadOnly = true},
                new DataGridViewButtonColumn() { Text = "Editar", Name = "btnPlay", UseColumnTextForButtonValue = true }
            };
            else
                columnas = new DataGridViewColumn[] {
                 new DataGridViewTextBoxColumn() { Visible = false, Name = "Id_producto", HeaderText="ID"} ,
                new DataGridViewTextBoxColumn() { Name = "Modelo", HeaderText="Modelo del producto" , ReadOnly = true},
                new DataGridViewCheckBoxColumn(){Name= "chbx_selected", HeaderText="Selected",FalseValue = false, TrueValue = true}
                };
            DataGridVerProductos.Columns.AddRange(columnas);
        }
        private void LimpiarCheckDElDataGrid(List<Productos> productos)
        {
            foreach (DataGridViewRow fila in DataGridVerProductos.Rows)
                fila.Cells["chbx_selected"].Value = null;
        }
        private void ActualizarProductosEnDataGRid(List<Productos> productos)
        {
            List<string> filasSeleccionadas = new List<string>();
            foreach (DataGridViewRow fila in DataGridVerProductos.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["chbx_selected"].Value))
                {
                    filasSeleccionadas.Add(fila.Cells["Id_producto"].Value.ToString());
                }
            }
            DataGridVerProductos.Rows.Clear();
            foreach (Productos producto in productos)
                ordenarProductoEnElDataGrid(producto);
            foreach (DataGridViewRow fila in DataGridVerProductos.Rows)
            {
                string idProducto = fila.Cells["Id_producto"].Value.ToString();
                fila.Cells["chbx_selected"].Value = filasSeleccionadas.Contains(idProducto);
            }
        }
        private void ordenarProductoEnElDataGrid(Productos productos)
        {
            DataGridVerProductos.Rows.Add(productos.Id_productos, productos.modelo);
        }

        private void limpiar_txtbx()
        {
            txtbx_calle_num.Text = string.Empty;
            txtbx_ciudad.Text = string.Empty;
            txtbx_colonia.Text = string.Empty;
            txtbx_cp.Text = string.Empty;
            txtbx_estado.Text = string.Empty;
            txtbx_municipio.Text = string.Empty;
            txtbx_nombre_empresa.Text = string.Empty;
            txtbx_nombre_rep.Text = string.Empty;
            txtbx_rfc.Text = string.Empty;
            txtbx_tel.Text = string.Empty;
            txtbx_correo.Text = string.Empty;
        }
        public void ocultarYmostrarBotones(bool mostrar)
        {
            Panel_botones_registrar.Visible = mostrar;
            Panel_botones_actualizar.Visible = !mostrar;
        }
        private void ordenar_datos(Proveedor proveedor)
        {
            txtbx_nombre_empresa.Text = proveedor.Nom_Prov;
            txtbx_rfc.Text = proveedor.rfc_Prov;
            txtbx_nombre_rep.Text = proveedor.Rep_prov ?? "No hay informacion";
            txtbx_tel.Text = proveedor.Num_Prov;
            txtbx_correo.Text = proveedor.Correo_prov;
            string[] direccion = proveedor.Dir_prov.Split(',');
            txtbx_calle_num.Text = direccion[0];
            txtbx_colonia.Text = direccion.Length > 2 ? direccion[1] : "No hay informacion";
            txtbx_municipio.Text = direccion.Length > 3 ? direccion[2] : "No hay informacion";
            txtbx_cp.Text = direccion.Length > 4 ? direccion[3] : "No hay informacion";
            txtbx_ciudad.Text = direccion.Length > 5 ? direccion[4] : "No hay informacion";
            txtbx_estado.Text = direccion.Length > 6 ? direccion[5] : "No hay informacion";
        }
        private void deshabilitar_habilitar_textBox(bool enable)
        {
            txtbx_calle_num.Enabled = enable;
            txtbx_ciudad.Enabled = enable;
            txtbx_colonia.Enabled = enable;
            txtbx_cp.Enabled = enable;
            txtbx_estado.Enabled = enable;
            txtbx_municipio.Enabled = enable;
            txtbx_nombre_empresa.Enabled = enable;
            txtbx_nombre_rep.Enabled = enable;
            txtbx_rfc.Enabled = enable;
            txtbx_tel.Enabled = enable;
            txtbx_correo.Enabled = enable;
            textbox_enable = enable;
        }
        public Vista_nuevo_proveedor(TypeOfView tipoDeVista, string? id_Prov)
        {
            InitializeComponent();
            this.tipoDeVista = tipoDeVista;
            GenerarHeaders();
            switch (tipoDeVista)
            {
                case TypeOfView.Regist_new_supplier:
                    {
                        lbl_title.Text = "Registrar nuevo Proveedor";
                        ocultarYmostrarBotones(true);
                        List<Productos> productos = DBContext.Return_productAll();
                        foreach (Productos producto in productos)
                            ordenarProductoEnElDataGrid(producto);
                        break;
                    }
                case TypeOfView.Update_supplier:
                    {
                        lbl_title.Text = "Modificar empleado";
                        ocultarYmostrarBotones(false);
                        deshabilitar_habilitar_textBox(textbox_enable);
                        if (id_Prov is not null)
                        {
                            provedor_a_actualizar = DBContext.Return_Supplier(id_Prov);
                            foreach (Productos producto in provedor_a_actualizar.productos_que_vende)
                                ordenarProductoEnElDataGrid(producto);
                            ordenar_datos(provedor_a_actualizar);
                        }
                        else
                            throw new ArgumentException("El parametro enviado es nulo");
                        break;
                    }
            }
        }


        private void btn_bloquear_campos_Click(object sender, EventArgs e)
        {
            if (!textbox_enable)
                textbox_enable = true;
            else
                textbox_enable = false;

            deshabilitar_habilitar_textBox(textbox_enable);
            btn_bloquear_campos.Text = textbox_enable ? "Bloquear" : "Desbloquear";
        }

        private void btn_actualizar_datos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere actualizar los productos que suminstra el productor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vista.ShowDialog();
                provedor_a_actualizar.productos_que_vende.AddRange(vista.productos_agregados);

            }
        }

        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            limpiar_txtbx();
        }

        private List<Productos> AgregarProductosDelCheckBox()
        {
            List<string> seleccionados = new List<string>();

            foreach (DataGridViewRow row in DataGridVerProductos.Rows)
                if (Convert.ToBoolean(row.Cells[2].Value) == true)
                    seleccionados.Add(row.Cells[0].Value.ToString());
            return DBContext.Return_productAll().Where(producto => seleccionados.Contains(producto.Id_productos)).ToList();
        }

        private void btn_registrar_proveedor_Click(object sender, EventArgs e)
        {
            string direccion_completa = string.Empty;
            Proveedor nvo_proveedor = new Proveedor()
            {
                rfc_Prov = txtbx_rfc.Text,
                Nom_Prov = txtbx_nombre_empresa.Text,
                Rep_prov = txtbx_nombre_rep.Text == string.Empty ? null : txtbx_nombre_rep.Text,
                Num_Prov = txtbx_tel.Text,
                Correo_prov = txtbx_correo.Text

            };

            if (txtbx_calle_num.Text == string.Empty)
                Error.SetError(txtbx_calle_num, "El campo no puede estar vacio");
            else
                direccion_completa += txtbx_calle_num.Text;
            if (txtbx_colonia.Text == string.Empty)
                Error.SetError(txtbx_colonia, "El campo no puede estar vacio");
            else
                direccion_completa += "," + txtbx_colonia.Text;
            if (txtbx_municipio.Text == string.Empty)
                Error.SetError(txtbx_municipio, "El campo no puede estar vacio");
            else
                direccion_completa += "," + txtbx_municipio.Text;
            if (txtbx_cp.Text == string.Empty)
                Error.SetError(txtbx_cp, "El campo no puede estar vacio");
            else
                direccion_completa += "," + txtbx_cp.Text;
            if (txtbx_ciudad.Text == string.Empty)
                Error.SetError(txtbx_ciudad, "El campo no puede estar vacio");
            else
                direccion_completa += "," + txtbx_ciudad;
            if (txtbx_estado.Text == string.Empty)
                Error.SetError(txtbx_estado, "El campo no puede estar vacio");
            else
                direccion_completa += "," + txtbx_estado;
            nvo_proveedor.Dir_prov = direccion_completa;
            nvo_proveedor.productos_que_vende.AddRange(AgregarProductosDelCheckBox());
            nvo_proveedor.productos_que_vende.AddRange(vista.productos_agregados);
            if (vista.productos_agregados.Count == 0 && nvo_proveedor.productos_que_vende.Count == 0)
                Error.SetError(btn_agregar_producto, "Falta agregar productos para el proveedor");
            ValidationContext context = new ValidationContext(nvo_proveedor, null, null);
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            if (Validator.TryValidateObject(nvo_proveedor, context, validationContexts, true) || !Error.HasErrors)
            {
                try
                {
                    if (DBContext.InsertarCompleteTheSupplier(nvo_proveedor, vista.productos_agregados))
                    {
                        MessageBox.Show("El Proveedor fue agregado correctamente", "Proveedor Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_txtbx();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al actualizar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (ValidationResult error in validationContexts)
                {
                    switch (error.MemberNames.First())
                    {
                        case "rfc_Prov":
                            {
                                Error.SetError(txtbx_rfc, error.ErrorMessage);
                                break;
                            }
                        case "Nom_Prov":
                            {
                                Error.SetError(txtbx_nombre_empresa, error.ErrorMessage);
                                break;
                            }
                        case "Rep_prov":
                            {
                                Error.SetError(txtbx_nombre_rep, error.ErrorMessage);
                                break;
                            }
                        case "Correo_prov":
                            {
                                Error.SetError(txtbx_correo, error.ErrorMessage);
                                break;
                            }
                        case "Num_Prov":
                            {
                                Error.SetError(txtbx_tel, error.ErrorMessage);
                                break;
                            }
                    }
                }
            }
        }

        private void OnOnlyNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            { e.Handled = false; }
            else
            { e.Handled = true; }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            vista.ShowDialog();
            List<Productos> productos = DBContext.Return_productAll();
            ActualizarProductosEnDataGRid(productos);
        }
    }
}
