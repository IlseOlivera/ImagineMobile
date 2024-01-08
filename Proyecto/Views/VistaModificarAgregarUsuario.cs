using MySql.Data.MySqlClient;
using Proyecto_BD.Enumerables;
using Proyecto_BD.Models;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Proyecto_BD.Controles
{
    public partial class VistaModificarAgregarUsuario : UserControl
    {
        private Usuarios usuario_a_actualizar;

        public TypeOfView TipoDeVista { get; set; }

        private bool textbox_enable = false;

        private void limpiar_txtbx()
        {
            txtbx_Nombre.Text = string.Empty;
            txtbx_AP.Text = string.Empty;
            txtbx_AM.Text = string.Empty;
            txtbx_correo.Text = string.Empty;
            txtbx_NSS.Text = string.Empty;
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
        public void ocultarYmostrarBotones(bool mostrar)
        {
            Tabla_btn_registrar.Visible = mostrar;
            Tabla_btn_actualizar_usuario.Visible = !mostrar;
        }
        public VistaModificarAgregarUsuario(TypeOfView tipoDeVista, string? id_Us)
        {
            this.TipoDeVista = tipoDeVista;
            InitializeComponent();
            switch (tipoDeVista)
            {
                case TypeOfView.Regist_new_employee:
                    {
                        Lbl_title.Text = "Registrar nuevo empleado";
                        ocultarYmostrarBotones(true);
                        break;
                    }
                case TypeOfView.Update_employee:
                    {
                        Lbl_title.Text = "Modificar empleado";
                        ocultarYmostrarBotones(false);
                        deshabilitar_habilitar_textBox(textbox_enable);
                        if (id_Us != null)
                        {
                            usuario_a_actualizar = DBContext.Return_User(id_Us);
                            ordenar_datos(usuario_a_actualizar);
                        }
                        else
                            throw new ArgumentException("El parametro enviado es nulo");
                        break;
                    }
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar_txtbx();
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

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string nvo_pass = string.Empty;
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
            if (txtbx_psswrd.Text == string.Empty)
                Error.SetError(txtbx_psswrd, "Es necesaria una contraseña");
            else
                nvo_pass = txtbx_psswrd.Text;
            ValidationContext context = new ValidationContext(nvo_usuario, null, null);
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            if (Validator.TryValidateObject(nvo_usuario, context, validationContexts, true))
            {
                try
                {

                    if (DBContext.InsertUser(nvo_usuario, nvo_pass))
                    {
                        MessageBox.Show("El usuario fue guardado correctamente", "El usuario fue guardado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_txtbx();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (ValidationResult error in validationContexts)
                {
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
                textbox_enable = true;
            else
                textbox_enable = false;

            deshabilitar_habilitar_textBox(textbox_enable);
            btn_bloquear.Text = textbox_enable ? "Bloquear" : "Desbloquear";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            usuario_a_actualizar.Tel_Us = double.Parse(txtbx_tel.Text);
            usuario_a_actualizar.correo_electronico = txtbx_correo.Text;
            ValidationContext context = new ValidationContext(usuario_a_actualizar, null, null);
            List<ValidationResult> validationContexts = new List<ValidationResult>();
            if (Validator.TryValidateObject(usuario_a_actualizar, context, validationContexts, true))
            {
                try
                {

                    if (DBContext.Actualizar_Usuario(usuario_a_actualizar))
                    {
                        MessageBox.Show("El usuario fue actualizado correctamente", "Usuario Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar_txtbx();
                        ordenar_datos(usuario_a_actualizar);
                        deshabilitar_habilitar_textBox(false);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hubo un error al generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                foreach (ValidationResult error in validationContexts)
                {
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
