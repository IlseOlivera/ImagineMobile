using Proyecto_BD.Controles;
using Proyecto_BD.Enumerables;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Pintamos el componente
            InitializeComponent();
            //Instanciamos la vista
            VistaModificarAgregarUsuario vista = new VistaModificarAgregarUsuario(TypeOfView.Regist_new_employee, null);
            //La mostramos en el formulario
            this.Controls.Add(vista);
        }
        public Form1(string id)
        {
            //Pintamos el componente
            InitializeComponent();
            //Instanciamos la vista
            VistaModificarAgregarUsuario vista = new VistaModificarAgregarUsuario(TypeOfView.Update_employee, id);
            //La mostramos en el formulario
            this.Controls.Add(vista);
        }
    }
}
