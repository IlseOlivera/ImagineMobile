using Microsoft.Extensions.Configuration;

namespace Proyecto_BD
{
    public class Startup
    {
        // Creamos una instancia para la configuracion
        private IConfiguration Configuration { get; }
        public Startup()
        {
            // generamos un constructor de la configuracion
            IConfigurationBuilder builder = new ConfigurationBuilder()
                //Le decimos donde es la base del directorio para que encuentre el constructor de la clase
                .SetBasePath(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName)
                // Le adjuntamos el appsetting.json
                .AddJsonFile("appsettings.json", false, true);
            Configuration = builder.Build();
        }

        public string ConectionString()
        {
            // Le decimos que del Json, regrese la cadena de conexion
            return Configuration.GetConnectionString("IMAGINE_MOBILE_DB");
        }
    }
}
