using Proyecto_BD.Controles;
using Proyecto_BD.Enumerables;

namespace Proyecto_BD
{
    public partial class Vista_Administrador : Form
    {
        public Vista_Administrador()
        {
            InitializeComponent();
        }

        private void Vista_Administrador_Load(object sender, EventArgs e)
        {
            VistaModificarAgregarUsuario vista = new VistaModificarAgregarUsuario(TypeOfView.Update_employee, "EMPHV6872");
            this.Controls.Add(vista);
        }
    }
}
