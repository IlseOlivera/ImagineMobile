namespace Proyecto_BD.Components
{
    public partial class AddComp : Form
    {
        //encampsulamiento del texto de salida
        private string outputText;
        //Devolucion del texto de salida
        public string OutputText { get => outputText; }

        //constructor vacio
        public AddComp()
        {
            //Dibujado del formulario
            InitializeComponent();
        }
        //delegado del boton cancelar
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Se da como el resultado del dialogo, cancelado
            DialogResult = DialogResult.Cancel;
            //Se cierrra el formulario
            this.Close();
        }
        //Se da aceptar
        private void btn_accept_Click(object sender, EventArgs e)
        {
            //Si el text box esta vacio se envia el error
            if (txtbx_output.Text == string.Empty)
            {
                //Envio del error
                MessageBox.Show("Debe escribir al menos un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Se le asigna el valor a la salida
                outputText = txtbx_output.Text;
                //Se da como resultado OK
                DialogResult = DialogResult.OK;
                //Se cierra el formulario
                this.Close();
            }
        }
    }
}
