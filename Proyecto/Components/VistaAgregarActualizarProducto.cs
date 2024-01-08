using MySql.Data.MySqlClient;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Components
{

    public partial class VistaAgregarActualizarProducto : UserControl
    {
        private TypeOfView tipoDeVista;

        private bool textbox_enable = false;

        private Productos producto_a_actualizar;

        private bool[] changes = new bool[5];

        private List<Productos> productos_agregados;
        public void ocultarYmostrarBotones(bool mostrar)
        {
            table_agregar.Visible = mostrar;
            table_actualizar.Visible = !mostrar;
        }
        private void AgregarProductoSinBD()
        {
            ComboboxItem item = combo_tipo_producto.SelectedItem as ComboboxItem;
            if (item.Value != null)
            {
                Productos nvo_producto = new Productos((TypeOfProductos)item.Value)
                {

                    modelo = txtbx_modelo.Text == string.Empty ? 0 : double.Parse(txtbx_modelo.Text),
                    cantidad = txtbx_cantidad.Text == string.Empty ? 0 : int.Parse(txtbx_cantidad.Text),
                    precio = txtbx_precio.Text == string.Empty ? 0 : int.Parse(txtbx_precio.Text),
                    campos_Extra = new Campos_extra()
                    {
                        color = txtbx_colo.Text == string.Empty ? null : txtbx_colo.Text,
                        material = txtbx_material.Text == string.Empty ? null : txtbx_material.Text,
                        capacida = txtbx_capacidad.Text == string.Empty ? null : int.Parse(txtbx_capacidad.Text),
                        Tamaño = new string[] { txtbx_largo.Text, txtbx_ancho.Text, txtbx_alto.Text }

                    }
                };
                item = combo_espec.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.especificacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ESPECIFICACIONES, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_com.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.compatibilidad = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.COMPATIBILIDAD, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_comu.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.comunicacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_acce.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.accesorios = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ACCESORIOS, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_tecno.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.tecnologias = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.TECNOLOGIAS, item.Value.ToString()) { caracteristica = item.Text };
                ValidationContext context = new ValidationContext(nvo_producto, null, null);
                List<ValidationResult> validationContexts = new List<ValidationResult>();
                if (Validator.TryValidateObject(nvo_producto, context, validationContexts, true))
                {
                    try
                    {


                        MessageBox.Show("El producto fue agregado correctamente", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_txtbx();
                        productos_agregados.Add(nvo_producto);

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Hubo un error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    foreach (ValidationResult error in validationContexts)
                    {
                        switch (error.MemberNames.First())
                        {
                            case "modelo":
                                {
                                    Error.SetError(txtbx_modelo, error.ErrorMessage);
                                    break;
                                }
                            case "precio":
                                {
                                    Error.SetError(txtbx_precio, error.ErrorMessage);
                                    break;
                                }
                            case "cantidad":
                                {
                                    Error.SetError(txtbx_cantidad, error.ErrorMessage);
                                    break;
                                }
                            case "color":
                                {
                                    Error.SetError(txtbx_colo, error.ErrorMessage);
                                    break;
                                }
                            case "material":
                                {
                                    Error.SetError(txtbx_material, error.ErrorMessage);
                                    break;
                                }
                            case "tamaño":
                                {
                                    Error.SetError(label12, error.ErrorMessage);
                                    break;
                                }
                            case "capacida":
                                {
                                    Error.SetError(txtbx_capacidad, error.ErrorMessage);
                                    break;
                                }

                        }
                    }
                }
            }
            else
                Error.SetError(combo_tipo_producto, "Debe seleccionar algun tipo de producto");
        }

        private void Agregar_Producto()
        {
            ComboboxItem item = combo_tipo_producto.SelectedItem as ComboboxItem;
            if (item.Value != null)
            {
                Productos nvo_producto = new Productos((TypeOfProductos)item.Value)
                {

                    modelo = txtbx_modelo.Text == string.Empty ? 0 : double.Parse(txtbx_modelo.Text),
                    cantidad = txtbx_cantidad.Text == string.Empty ? 0 : int.Parse(txtbx_cantidad.Text),
                    precio = txtbx_precio.Text == string.Empty ? 0 : int.Parse(txtbx_precio.Text),
                    campos_Extra = new Campos_extra()
                    {
                        color = txtbx_colo.Text == string.Empty ? null : txtbx_colo.Text,
                        material = txtbx_material.Text == string.Empty ? null : txtbx_material.Text,
                        capacida = txtbx_capacidad.Text == string.Empty ? null : int.Parse(txtbx_capacidad.Text),
                        Tamaño = new string[] { txtbx_largo.Text, txtbx_ancho.Text, txtbx_alto.Text }

                    }
                };
                item = combo_espec.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.especificacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ESPECIFICACIONES, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_com.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.compatibilidad = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.COMPATIBILIDAD, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_comu.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.comunicacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_acce.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.accesorios = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ACCESORIOS, item.Value.ToString()) { caracteristica = item.Text };
                item = combo_tecno.SelectedItem as ComboboxItem;
                nvo_producto.campos_Extra.tecnologias = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.TECNOLOGIAS, item.Value.ToString()) { caracteristica = item.Text };
                ValidationContext context = new ValidationContext(nvo_producto, null, null);
                List<ValidationResult> validationContexts = new List<ValidationResult>();
                if (Validator.TryValidateObject(nvo_producto, context, validationContexts, true))
                {
                    if (changes[0] && nvo_producto.campos_Extra.especificacion is not null)
                        DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.especificacion);
                    if (changes[1] && nvo_producto.campos_Extra.compatibilidad is not null)
                        DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.compatibilidad);
                    if (changes[2] && nvo_producto.campos_Extra.comunicacion is not null)
                        DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.comunicacion);
                    if (changes[3] && nvo_producto.campos_Extra.accesorios is not null)
                        DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.accesorios);
                    if (changes[4] && nvo_producto.campos_Extra.tecnologias is not null)
                        DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.tecnologias);
                    try
                    {

                        if (DBContext.InsertExtraCamps(nvo_producto.campos_Extra) && DBContext.InsertProduct(nvo_producto))
                        {
                            MessageBox.Show("El producto fue agregado correctamente", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar_txtbx();
                            if (productos_agregados is not null)
                                productos_agregados.Add(nvo_producto);
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Hubo un error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    foreach (ValidationResult error in validationContexts)
                    {
                        switch (error.MemberNames.First())
                        {
                            case "modelo":
                                {
                                    Error.SetError(txtbx_modelo, error.ErrorMessage);
                                    break;
                                }
                            case "precio":
                                {
                                    Error.SetError(txtbx_precio, error.ErrorMessage);
                                    break;
                                }
                            case "cantidad":
                                {
                                    Error.SetError(txtbx_cantidad, error.ErrorMessage);
                                    break;
                                }
                            case "color":
                                {
                                    Error.SetError(txtbx_colo, error.ErrorMessage);
                                    break;
                                }
                            case "material":
                                {
                                    Error.SetError(txtbx_material, error.ErrorMessage);
                                    break;
                                }
                            case "tamaño":
                                {
                                    Error.SetError(label12, error.ErrorMessage);
                                    break;
                                }
                            case "capacida":
                                {
                                    Error.SetError(txtbx_capacidad, error.ErrorMessage);
                                    break;
                                }

                        }
                    }
                }
            }
            else
                Error.SetError(combo_tipo_producto, "Debe seleccionar algun tipo de producto");
        }

        private void limpiar_txtbx()
        {
            txtbx_modelo.Text = string.Empty;
            txtbx_colo.Text = string.Empty;
            txtbx_material.Text = string.Empty;
            txtbx_cantidad.Text = string.Empty;
            txtbx_capacidad.Text = string.Empty;
            txtbx_capacidad.Text = string.Empty;
            txtbx_largo.Text = string.Empty;
            txtbx_alto.Text = string.Empty;
            txtbx_ancho.Text = string.Empty;
            combo_acce.SelectedIndex = 0;
            combo_com.SelectedIndex = 0;
            combo_espec.SelectedIndex = 0;
            combo_comu.SelectedIndex = 0;
            combo_tecno.SelectedIndex = 0;
            combo_tipo_producto.SelectedIndex = 0;
        }
        private void deshabilitar_habilitar_textBox(bool enable)
        {
            txtbx_modelo.Enabled = false;
            txtbx_colo.Enabled = enable;
            txtbx_material.Enabled = enable;
            txtbx_cantidad.Enabled = enable;
            combo_tipo_producto.Enabled = false;
            txtbx_capacidad.Enabled = enable;
            txtbx_precio.Enabled = enable;
            txtbx_largo.Enabled = enable;
            txtbx_alto.Enabled = enable;
            txtbx_ancho.Enabled = enable;
            combo_acce.Enabled = enable;
            combo_com.Enabled = enable;
            combo_espec.Enabled = enable;
            combo_comu.Enabled = enable;
            combo_tecno.Enabled = enable;
            btn_agregar_accesorios.Enabled = enable;
            btn_agregar_comunicacion.Enabled = enable;
            btn_agregar_com.Enabled = enable;
            btn_agregar_spec.Enabled = enable;
            btn_agregar_tecnologias.Enabled = enable;
        }
        private void OrdenarListaTipos()
        {
            combo_tipo_producto.Items.Add(new ComboboxItem { Text = "Seleccione un dato", Value = null });
            if (producto_a_actualizar is null)
                combo_tipo_producto.SelectedIndex = 0;
            for (int i = 1; i < (int)TypeOfProductos.TELEFONOS; i++)
            {
                ComboboxItem item = new ComboboxItem() { Text = ((TypeOfProductos)i).ToString(), Value = (TypeOfProductos)i };
                combo_tipo_producto.Items.Add(item);
                if (producto_a_actualizar is not null && producto_a_actualizar.tipo == (TypeOfProductos)i)
                    combo_tipo_producto.SelectedIndex = i;
            }
        }

        private void OrdenarListaSpecs(List<Caracteristica_especifica> specs, TypeExtra extra)
        {
            ComboBox comboAMod = extra == TypeExtra.ACCESORIOS ? combo_acce : extra == TypeExtra.COMPATIBILIDAD ? combo_com : extra == TypeExtra.ESPECIFICACIONES ? combo_espec : extra == TypeExtra.METODOS_DE_COMUNICACION ? combo_comu : combo_tecno;
            string caracteristica_ = string.Empty;
            comboAMod.Items.Add(new ComboboxItem { Text = "Seleccione un dato", Value = null });
            if (producto_a_actualizar is not null)
            {
                caracteristica_ = extra == TypeExtra.ACCESORIOS ? producto_a_actualizar.campos_Extra.accesorios.Id_Ca : extra == TypeExtra.COMPATIBILIDAD ? producto_a_actualizar.campos_Extra.compatibilidad.Id_Ca : extra == TypeExtra.ESPECIFICACIONES ? producto_a_actualizar.campos_Extra.especificacion.Id_Ca : extra == TypeExtra.METODOS_DE_COMUNICACION ? producto_a_actualizar.campos_Extra.comunicacion.Id_Ca : producto_a_actualizar.campos_Extra.tecnologias.Id_Ca;
                if (caracteristica_ == string.Empty)
                    comboAMod.SelectedIndex = 0;
            }
            else
                comboAMod.SelectedIndex = 0;

            for (int i = 0; i < specs.Count; i++)
            {
                ComboboxItem item = new ComboboxItem() { Text = specs[i].caracteristica, Value = specs[i].Id_Ca };
                comboAMod.Items.Add(item);
                if (caracteristica_ is not null && caracteristica_ == specs[i].Id_Ca)
                    comboAMod.SelectedIndex = i + 1;
            }
        }
        private void ordenar_datos(Productos producto)
        {
            txtbx_modelo.Text = producto.modelo.ToString();
            txtbx_colo.Text = producto.campos_Extra.color;
            txtbx_material.Text = producto.campos_Extra.material;
            txtbx_cantidad.Text = producto.cantidad.ToString();
            txtbx_capacidad.Text = producto.campos_Extra.capacida?.ToString() ?? string.Empty;
            txtbx_precio.Text = producto.precio.ToString();
            string[] dimensiones = producto.campos_Extra?.Tamaño ?? new string[0];
            txtbx_largo.Text = dimensiones[0] != string.Empty ? dimensiones[0] : "0";
            txtbx_alto.Text = dimensiones[1] != string.Empty ? dimensiones[1] : "0";
            txtbx_ancho.Text = dimensiones[2] != string.Empty ? dimensiones[2] : "0";
        }
        public VistaAgregarActualizarProducto(TypeOfView vista, ref List<Productos> productos_agregados)
        {
            tipoDeVista = vista;
            this.productos_agregados = productos_agregados;
            InitializeComponent();
            switch (vista)
            {
                case TypeOfView.Create_new_product:
                    {
                        lbl_title.Text = "Agregar nuevo producto";
                        ocultarYmostrarBotones(true);
                        break;
                    }
                case TypeOfView.Add_product_for_supplier:
                    {
                        lbl_title.Text = "Agregar nuevo producto";
                        ocultarYmostrarBotones(true);
                        break;
                    }
            }
            for (int i = 0; i <= (int)TypeExtra.ACCESORIOS; i++)
                OrdenarListaSpecs(DBContext.SeeAllSpecs((TypeExtra)i), (TypeExtra)i);
            OrdenarListaTipos();
        }
        public VistaAgregarActualizarProducto(TypeOfView vista, string? id_product)
        {
            tipoDeVista = vista;
            InitializeComponent();
            switch (vista)
            {
                case TypeOfView.Create_new_product:
                    {
                        lbl_title.Text = "Agregar nuevo producto";
                        ocultarYmostrarBotones(true);
                        break;
                    }
                case TypeOfView.Update_product:
                    {
                        lbl_title.Text = "Modificar producto";
                        ocultarYmostrarBotones(false);
                        deshabilitar_habilitar_textBox(textbox_enable);
                        if (id_product is not null)
                        {
                            producto_a_actualizar = DBContext.Return_product(id_product);
                            ordenar_datos(producto_a_actualizar);
                        }
                        else
                            throw new ArgumentException("El parametro enviado es nulo");
                        break;
                    }
            }
            for (int i = 0; i <= (int)TypeExtra.ACCESORIOS; i++)
                OrdenarListaSpecs(DBContext.SeeAllSpecs((TypeExtra)i), (TypeExtra)i);
            OrdenarListaTipos();
        }

        private void btn_bloquer_desbloquear_Click(object sender, EventArgs e)
        {
            if (!textbox_enable)
                textbox_enable = true;
            else
                textbox_enable = false;

            deshabilitar_habilitar_textBox(textbox_enable);
            btn_bloquer_desbloquear.Text = textbox_enable ? "Bloquear" : "Desbloquear";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Error.Clear();
            producto_a_actualizar.campos_Extra.color = txtbx_colo.Text == string.Empty ? null : txtbx_colo.Text;
            producto_a_actualizar.campos_Extra.material = txtbx_material.Text == string.Empty ? null : txtbx_material.Text;
            producto_a_actualizar.cantidad = txtbx_cantidad.Text == string.Empty ? 0 : int.Parse(txtbx_cantidad.Text);
            producto_a_actualizar.campos_Extra.capacida = txtbx_capacidad.Text == string.Empty ? null : int.Parse(txtbx_capacidad.Text);
            producto_a_actualizar.precio = txtbx_precio.Text == string.Empty ? 0 : int.Parse(txtbx_precio.Text);
            producto_a_actualizar.campos_Extra.Tamaño = new string[] { txtbx_largo.Text, txtbx_ancho.Text, txtbx_alto.Text };
            ComboboxItem item = combo_espec.SelectedItem as ComboboxItem;
            producto_a_actualizar.campos_Extra.especificacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ESPECIFICACIONES, item.Value.ToString()) { caracteristica = item.Text };
            item = combo_com.SelectedItem as ComboboxItem;
            producto_a_actualizar.campos_Extra.compatibilidad = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.COMPATIBILIDAD, item.Value.ToString()) { caracteristica = item.Text };
            item = combo_comu.SelectedItem as ComboboxItem;
            producto_a_actualizar.campos_Extra.comunicacion = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION, item.Value.ToString()) { caracteristica = item.Text };
            item = combo_acce.SelectedItem as ComboboxItem;
            producto_a_actualizar.campos_Extra.accesorios = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.ACCESORIOS, item.Value.ToString()) { caracteristica = item.Text };
            item = combo_tecno.SelectedItem as ComboboxItem;
            producto_a_actualizar.campos_Extra.tecnologias = item.Value is null ? null : new Caracteristica_especifica(TypeExtra.TECNOLOGIAS, item.Value.ToString()) { caracteristica = item.Text };
            ValidationContext context = new ValidationContext(producto_a_actualizar, null, null);
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            if (Validator.TryValidateObject(producto_a_actualizar, context, validationContexts, true))
            {
                if (changes[0] && producto_a_actualizar.campos_Extra.especificacion is not null)
                    DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.especificacion);
                if (changes[1] && producto_a_actualizar.campos_Extra.compatibilidad is not null)
                    DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.compatibilidad);
                if (changes[2] && producto_a_actualizar.campos_Extra.comunicacion is not null)
                    DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.comunicacion);
                if (changes[3] && producto_a_actualizar.campos_Extra.accesorios is not null)
                    DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.accesorios);
                if (changes[4] && producto_a_actualizar.campos_Extra.tecnologias is not null)
                    DBContext.InsertSpecificFeature(producto_a_actualizar.campos_Extra.tecnologias);
                try
                {

                    if (DBContext.Actualizar_producto(producto_a_actualizar) && DBContext.Actualizar_campos_extra(producto_a_actualizar.campos_Extra))
                    {
                        MessageBox.Show("El producto fue actualizado correctamente", "Producto Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_txtbx();
                        ordenar_datos(producto_a_actualizar);
                        deshabilitar_habilitar_textBox(false);
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
                        case "modelo":
                            {
                                Error.SetError(txtbx_modelo, error.ErrorMessage);
                                break;
                            }
                        case "precio":
                            {
                                Error.SetError(txtbx_precio, error.ErrorMessage);
                                break;
                            }
                        case "cantidad":
                            {
                                Error.SetError(txtbx_cantidad, error.ErrorMessage);
                                break;
                            }
                        case "color":
                            {
                                Error.SetError(txtbx_colo, error.ErrorMessage);
                                break;
                            }
                        case "material":
                            {
                                Error.SetError(txtbx_material, error.ErrorMessage);
                                break;
                            }
                        case "tamaño":
                            {
                                Error.SetError(label12, error.ErrorMessage);
                                break;
                            }
                        case "capacida":
                            {
                                Error.SetError(txtbx_capacidad, error.ErrorMessage);
                                break;
                            }

                    }
                }
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_txtbx();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (tipoDeVista == TypeOfView.Add_product_for_supplier)
                AgregarProductoSinBD();
            else
                Agregar_Producto();
        }

        private void btn_agregar_spec_Click(object sender, EventArgs e)
        {
            AddComp vista = new AddComp();
            vista.ShowDialog();
            if (vista.DialogResult == DialogResult.OK)
            {
                Caracteristica_especifica caracteristica = new Caracteristica_especifica(TypeExtra.ESPECIFICACIONES) { caracteristica = vista.OutputText };
                ComboboxItem item = new ComboboxItem() { Text = caracteristica.caracteristica, Value = caracteristica.Id_Ca };
                combo_espec.Items.Add(item);
                combo_espec.SelectedItem = item;
                changes[0] = true;
            }
        }

        private void btn_agregar_com_Click(object sender, EventArgs e)
        {
            AddComp vista = new AddComp();
            vista.ShowDialog();
            if (vista.DialogResult == DialogResult.OK)
            {
                Caracteristica_especifica caracteristica = new Caracteristica_especifica(TypeExtra.COMPATIBILIDAD) { caracteristica = vista.OutputText };
                ComboboxItem item = new ComboboxItem() { Text = caracteristica.caracteristica, Value = caracteristica.Id_Ca };
                combo_com.Items.Add(item);
                combo_com.SelectedItem = item;
                changes[1] = true;
            }
        }

        private void btn_agregar_comunicacion_Click(object sender, EventArgs e)
        {
            AddComp vista = new AddComp();
            vista.ShowDialog();
            if (vista.DialogResult == DialogResult.OK)
            {
                Caracteristica_especifica caracteristica = new Caracteristica_especifica(TypeExtra.METODOS_DE_COMUNICACION) { caracteristica = vista.OutputText };
                ComboboxItem item = new ComboboxItem() { Text = caracteristica.caracteristica, Value = caracteristica.Id_Ca };
                combo_comu.Items.Add(item);
                combo_comu.SelectedItem = item;
                changes[2] = true;
            }
        }

        private void btn_agregar_accesorios_Click(object sender, EventArgs e)
        {
            AddComp vista = new AddComp();
            vista.ShowDialog();
            if (vista.DialogResult == DialogResult.OK)
            {
                Caracteristica_especifica caracteristica = new Caracteristica_especifica(TypeExtra.ACCESORIOS) { caracteristica = vista.OutputText };
                ComboboxItem item = new ComboboxItem() { Text = caracteristica.caracteristica, Value = caracteristica.Id_Ca };
                combo_acce.Items.Add(item);
                combo_acce.SelectedItem = item;
                changes[3] = true;
            }
        }

        private void btn_agregar_tecnologias_Click(object sender, EventArgs e)
        {
            AddComp vista = new AddComp();
            vista.ShowDialog();
            if (vista.DialogResult == DialogResult.OK)
            {
                Caracteristica_especifica caracteristica = new Caracteristica_especifica(TypeExtra.TECNOLOGIAS) { caracteristica = vista.OutputText };
                ComboboxItem item = new ComboboxItem() { Text = caracteristica.caracteristica, Value = caracteristica.Id_Ca };
                combo_tecno.Items.Add(item);
                combo_tecno.SelectedItem = item;
                changes[4] = true;
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

        private void txtbx_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }

        private void txtbx_floatPoint(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)44)
            {
                e.Handled = false;
            }
            else
            { e.Handled = true; }
        }
    }
}
