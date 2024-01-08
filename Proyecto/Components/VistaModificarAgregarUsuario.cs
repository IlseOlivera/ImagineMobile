using MySql.Data.MySqlClient;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using System.ComponentModel.DataAnnotations;
namespace Proyecto_BD.Controles
{
    public partial class VistaModificarAgregarUsuario : UserControl
    {
        //Variable para el usuario a actualizare
        private Usuarios usuario_a_actualizar;
        //Variable para el tipo de vista que es
        private TypeOfView TipoDeVista;
        //Variable para habilitar los textBox
        private bool textbox_enable = false;
        //Metodo para limpiar lo textbox
        private void limpiar_txtbx()
        {
            txtbx_Nombre.Text = string.Empty;
            txtbx_AP.Text = string.Empty;
            txtbx_AM.Text = string.Empty;
            txtbx_correo.Text = string.Empty;
            txtbx_NSS.Text = string.Empty;
            //En este caso como es un Date time picker, hay que asignarle una fecha 
            Dtpck_FCN.Value = DateTime.Now.AddYears(-5);
            txtbx_RFC.Text = string.Empty;
            txtbx_CURP.Text = string.Empty;
            txtbx_correo.Text = string.Empty;
            txtbx_psswrd.Text = string.Empty;
            txtbx_Municipio.Text = string.Empty;
            txtbx_CP.Text = string.Empty;
            txtbx_ciudad.Text = string.Empty;
            txtbx_estado.Text = string.Empty;
        }
        //Metodo par deshabilitar los textbox
        private void deshabilitar_habilitar_textBox(bool enable)
        {
            txtbx_Nombre.Enabled = false;
            txtbx_AP.Enabled = false;
            txtbx_AM.Enabled = false;
            txtbx_RFC.Enabled = false;
            txtbx_CURP.Enabled = false;
            txtbx_NSS.Enabled = false;
            Dtpck_FCN.Enabled = false;
            txtbx_tel.Enabled = enable;
            txtbx_correo.Enabled = enable;
            txtbx_psswrd.Enabled = enable;
            txtbx_Municipio.Enabled = enable;
            txtbx_CP.Enabled = enable;
            txtbx_ciudad.Enabled = enable;
            txtbx_estado.Enabled = enable;
            textbox_enable = enable;
        }
        //Metodo para ordenar los datos cuando se le envie un usuario
        private void ordenar_datos(Usuarios usuario)
        {
            txtbx_Nombre.Text = usuario.Nom_US;
            txtbx_AP.Text = usuario.Ap_Us;
            txtbx_AM.Text = usuario.Am_Us;
            txtbx_tel.Text = usuario.Tel_Us.ToString();
            txtbx_NSS.Text = usuario.nss_Us;
            Dtpck_FCN.Value = usuario.fchNac_Us;
            txtbx_RFC.Text = usuario.rfc_Us;
            txtbx_CURP.Text = usuario.curp_us;
            txtbx_correo.Text = usuario.correo_electronico;
        }
        //Metodo para mostrar o ocultar paneles
        public void ocultarYmostrarBotones(bool mostrar)
        {
            //Panel para mostrar los botones para registrar
            Tabla_btn_registrar.Visible = mostrar;
            //Panel para actualizar
            Tabla_btn_actualizar_usuario.Visible = !mostrar;
        }
        //Constructor que recibe un tipo de vista y una variable (puede ser nulo)
        public VistaModificarAgregarUsuario(TypeOfView tipoDeVista, string? id_Us)
        {
            //Le asignamos la variable si valor
            TipoDeVista = tipoDeVista;
            //Pintamos el componente
            InitializeComponent();
            switch (tipoDeVista)
            {
                //En caso de que sea para registrar un empleado
                case TypeOfView.Regist_new_employee:
                    {
                        //Le cambiamos el titulo
                        Lbl_title.Text = "Registrar nuevo empleado";
                        //Mostramos los botones para registrar
                        ocultarYmostrarBotones(true);
                        break;
                    }
                //En caso de que sea para actualizar empleado
                case TypeOfView.Update_employee:
                    {
                        //Le cambiamos el titulo
                        Lbl_title.Text = "Modificar empleado";
                        //Le mostramos lo botones para actualiar
                        ocultarYmostrarBotones(false);
                        //Deshabilitamos los botones
                        deshabilitar_habilitar_textBox(textbox_enable);
                        //si el Id no es nulo
                        if (id_Us != null)
                        {
                            //Recibimos el usuario
                            usuario_a_actualizar = DBContext.Return_User(id_Us);
                            //Ordenamos los datos
                            ordenar_datos(usuario_a_actualizar);
                        }
                        else
                        {
                            //Enviamos un error
                            throw new ArgumentException("El parametro enviado es nulo");
                        }

                        break;
                    }
            }
        }
        //Delegado para limpiar los campos
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_txtbx();
        }
        //Dekegadi opara permitir si se escriben numeros o el backspace
        private void OnOnlyNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es un numero digito o la tecla es de borrar
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                //No se detienen
                e.Handled = false;
            }
            else
            //Se detiene
            { e.Handled = true; }
        }
        //Delegado para registrar el usuario
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //Asignamos una variable para la contraseña
            string nvo_pass = string.Empty;
            //Instanciamos un nuevo usuario y le damos sus valores
            Usuarios nvo_usuario = new Usuarios()
            {
                Nom_US = txtbx_Nombre.Text,
                Ap_Us = txtbx_AP.Text,
                Am_Us = txtbx_AM.Text,
                Tel_Us = txtbx_tel.Text == string.Empty ? 0 : double.Parse(txtbx_tel.Text),
                nss_Us = txtbx_NSS.Text,
                fchNac_Us = Dtpck_FCN.Value,
                rfc_Us = txtbx_RFC.Text,
                correo_electronico = txtbx_correo.Text,
                curp_us = txtbx_CURP.Text
            };
            //Si la contraseña esta vacia
            if (txtbx_psswrd.Text == string.Empty)
            {
                //Enviamos un error al combo
                Error.SetError(txtbx_psswrd, "Es necesaria una contraseña");
            }
            else
            {
                //Lo asignamos a la variable
                nvo_pass = txtbx_psswrd.Text;
            }
            //Generamos un objeto para que valide los data anotation
            ValidationContext context = new ValidationContext(nvo_usuario, null, null);
            //Generamos una lista de resultados, donde se valide el contexto
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            //Hacemos un intento de validar el objeto
            if (Validator.TryValidateObject(nvo_usuario, context, validationContexts, true))
            {
                //Colocamos un try para controlar quehaya errores de SQL
                try
                {
                    //Se realiza la insercion del nvo usuario
                    if (DBContext.InsertUser(nvo_usuario, nvo_pass))
                    {
                        //Se envia confirmacion de que se guardo correctamente
                        MessageBox.Show("El usuario fue guardado correctamente", "El usuario fue guardado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Se limpia los textbox
                        limpiar_txtbx();
                        //Se llama al formulario padre o donde esta contenido el control
                        Form padre = Parent.TopLevelControl as Form;
                        //Cerramos el padre
                        padre.Close();
                    }
                }
                //Si atrapa un erro de SQL, envia el error
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Por cada resultado va aver los posibles errores
                foreach (ValidationResult error in validationContexts)
                {
                    //Va a buscar los miembros que si tuvieron error
                    switch (error.MemberNames.First())
                    {
                        case "Nom_US":
                            Error.SetError(txtbx_Nombre, error.ErrorMessage);
                            break;
                        case "Ap_Us":
                            Error.SetError(txtbx_AP, error.ErrorMessage);
                            break;
                        case "Am_Us":
                            Error.SetError(txtbx_AM, error.ErrorMessage);
                            break;
                        case "rfc_Us":
                            Error.SetError(txtbx_RFC, error.ErrorMessage);
                            break;
                        case "curp_us":
                            Error.SetError(txtbx_CURP, error.ErrorMessage);
                            break;
                        case "nss_Us":
                            Error.SetError(txtbx_NSS, error.ErrorMessage);
                            break;
                        case "Tel_Us":
                            Error.SetError(txtbx_tel, error.ErrorMessage);
                            break;
                        case "correo_electronico":
                            Error.SetError(txtbx_correo, error.ErrorMessage);
                            break;
                        case "fchNac_Us":
                            Error.SetError(Dtpck_FCN, error.ErrorMessage);
                            break;
                    }
                }
            }
        }

        private void btn_bloquear_Click(object sender, EventArgs e)
        {
            if (!textbox_enable)
            {
                textbox_enable = true;
            }
            else
            {
                textbox_enable = false;
            }

            deshabilitar_habilitar_textBox(textbox_enable);
            btn_bloquear.Text = textbox_enable ? "Bloquear" : "Desbloquear";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            usuario_a_actualizar.Tel_Us = double.Parse(txtbx_tel.Text);
            usuario_a_actualizar.correo_electronico = txtbx_correo.Text;
            //Generamos un objeto para que valide los data anotation
            ValidationContext context = new ValidationContext(usuario_a_actualizar, null, null);
            //Generamos una lista de resultados, donde se valide el contexto
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            //Hacemos un intento de validar el objeto
            if (Validator.TryValidateObject(usuario_a_actualizar, context, validationContexts, true))
            {
                //Colocamos un try para controlar quehaya errores de SQL
                try
                {

                    if (DBContext.Actualizar_Usuario(usuario_a_actualizar))
                    {
                        //Se envia confirmacion de que se guardo correctamente
                        MessageBox.Show("El usuario fue actualizado correctamente", "Usuario Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Se limpia los textbox
                        limpiar_txtbx();
                        ordenar_datos(usuario_a_actualizar);
                        deshabilitar_habilitar_textBox(false);
                        //Se llama al formulario padre o donde esta contenido el control
                        Form padre = Parent.TopLevelControl as Form;
                        //Cerramos el padre
                        padre.Close();
                    }

                }
                //Si atrapa un erro de SQL, envia el error
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Por cada resultado va aver los posibles errores
                foreach (ValidationResult error in validationContexts)
                {
                    //Va a buscar los miembros que si tuvieron error
                    switch (error.MemberNames.First())
                    {
                        case "Nom_US":
                            Error.SetError(txtbx_Nombre, error.ErrorMessage);
                            break;
                        case "Ap_Us":
                            Error.SetError(txtbx_AP, error.ErrorMessage);
                            break;
                        case "Am_Us":
                            Error.SetError(txtbx_AM, error.ErrorMessage);
                            break;
                        case "rfc_Us":
                            Error.SetError(txtbx_RFC, error.ErrorMessage);
                            break;
                        case "curp_us":
                            Error.SetError(txtbx_CURP, error.ErrorMessage);
                            break;
                        case "nss_Us":
                            Error.SetError(txtbx_NSS, error.ErrorMessage);
                            break;
                        case "Tel_Us":
                            Error.SetError(txtbx_tel, error.ErrorMessage);
                            break;
                        case "correo_electronico":
                            Error.SetError(txtbx_correo, error.ErrorMessage);
                            break;
                        case "fchNac_Us":
                            Error.SetError(Dtpck_FCN, error.ErrorMessage);
                            break;
                    }
                }
            }
        }
    }
}
