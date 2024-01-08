using MySql.Data.MySqlClient;
using Proyecto_BD.Models;
using System.Windows.Forms;

namespace Proyecto_BD
{
    public partial class Login : Form
    {
        public bool isClosed = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Hacemos la prueba de la base de datos
                DBContext.ConnectDataBase(Program.startup.ConectionString());
            }
            catch (Exception ex)
            {
                //Mandamos un mensaje de erro si es que no se pudo conectar
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Adjuntamos el boton para que inicie sesion al dar un click
        private void Btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            //Tomamos el usuario y la contraseña de los text box
            string user = TxtBx_usr.Text, password = TxtBox_pass.Text;
            try
            {
                //Conectamos al usuario que entra a la base de datos
                DBContext.Connect_userToDatabase(user, password);
                //Como no sabemos que vista vamos a abrir la declaramos dinamica para que se pueda asignar cualquier valor
                dynamic vista;
                //Vemos si el rol es de adminiestrador
                if (DBContext.rol == Enumerables.TypeRole.ADMINISTRADOR)
                    // Declaramos la vista de administrador
                    vista = new Vista_Administrador();
                else
                    //Declaramos la vista de Empleado
                    vista = new Vista_Empleados();
                //Mostramos la vista
                vista.Show();
                //Cerramos este formulario
                this.Close();
            }
            //Si hay algun error
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        //Hubo un fallo en el servidor
                        MessageBox.Show("El servidor a fallado y no se pudo conectar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1045:
                        {
                            //Le avisamos que tuvo un error en el usurio y contraseña que repita las credenciales o se salga
                            DialogResult result = MessageBox.Show("El usuario o la contraseña tienen un error", "Error al ingresar a la aplicacion", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            if (result == DialogResult.Cancel)
                                //Se sale de la aplicacion
                                Application.Exit();
                        }
                        break;
                }
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
           //if(e.CloseReason == CloseReason.UserClosing)
           //     Application.Exit();
        }
    }
}
