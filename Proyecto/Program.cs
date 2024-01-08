using Proyecto_BD.Models;
using Proyecto_BD.Vistas;

namespace Proyecto_BD
{
    public static class Program
    {
        // Creamos una instancia del startup estatico para usarlo en las demas clases
        public static Startup startup = new Startup();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //Iniciamos la configuracion de la aplicacion
            ApplicationConfiguration.Initialize();
            //Suscribimos el evento al cerrar la aplicacion
            Application.ApplicationExit += DBContext.OnApplicationExit;
            //Declaramos un nuevo formulario, si lo colocaramos en el run este seria el principal
            Login login = new Login();
            //Mostramos el formulario como dialogo
            login.ShowDialog();
            //Cuando se cierre le preguntamos que fue lo que devolvio
            switch (login.returnable)
            {
                case Enumerables.TypeRole.ADMINISTRADOR:
                    {
                        // Corremos la aplicacion usando como aplicacion principal la vista del administrador
                        Application.Run(new Vista_Administrador());
                        break;
                    }
                case Enumerables.TypeRole.EMPLEADO:
                    {
                        // Corremos la aplicacion usando como aplicacion principal la vista del empleado
                        Application.Run(new Vista_Empleados());
                        break;
                    }
                case Enumerables.TypeRole.None:
                    {
                        //Salimos de la aplicacion
                        Application.Exit();
                        break;
                    }
            }

        }
    }
}