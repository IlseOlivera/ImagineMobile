using Proyecto_BD.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Proveedor
    {
        //Id para identificar el proveedor
        public string Id_Prov { get; set; }
        //Data annotation, donde decimos que la propiedad es requerida
        [Required(ErrorMessage = "Es necesario un RFC", ErrorMessageResourceName = null)]
        //Data annotation para validar el tamaño de la propiedad
        [StringLength(13, ErrorMessage = "El RFC no debe ser mayor a 13 caracteres", ErrorMessageResourceName = null)]
        //Data annotation para validar que se cumpla el patron
        [RegularExpression(@"^\w{4}\d{6}\w{3}$", ErrorMessage = "Esto no es un RFC", ErrorMessageResourceName = null)]
        //Propiedad que guarda el RFC del proveedor
        public string rfc_Prov { get; set; }
        //Data annotation, donde decimos que la propiedad es requerida
        [Required(ErrorMessage = "Es necesario un Nombre de la empresa", ErrorMessageResourceName = null)]
        //Data annotation para validar el tamaño de la propiedad
        [StringLength(25, ErrorMessage = "El nombre no puede exceder de los 25 caracteres", ErrorMessageResourceName = null)]
        //Propiedad que guarda el nombre del proveedor
        public string Nom_Prov { get; set; }
        [StringLength(35, ErrorMessage = "El nombre del representante no puede exceder de los 35 caracteres", ErrorMessageResourceName = null)]
        //Propiedad que guarda el nombre del representante del proveedor, si no cuenta con un representante este sera nulo
        public string? Rep_prov { get; set; }
        //Data annotation, donde decimos que la propiedad es requerida
        [Required(ErrorMessage = "Es necesario una direccion", ErrorMessageResourceName = null)]
        //Data annotation para validar el tamaño de la propiedad
        [StringLength(50, ErrorMessage = "La direccion no puede exceder de los 50 caracateres", ErrorMessageResourceName = null)]
        //Propiedad que guarda la direccion del proveedor
        public string Dir_prov { get; set; }
        //Data annotation, donde decimos que la propiedad es requerida
        [Required(ErrorMessage = "El correo es necesario", ErrorMessageResourceName = null)]
        //Data annotation para validar que se cumpla el patron
        [RegularExpression(@"^\w{1,64}@(\w{1,255})\.com$", ErrorMessage = "Esto no es un correo electronico", ErrorMessageResourceName = null)]
        //Propiedad que guarda el correo del proveedor
        public string Correo_prov { get; set; }
        //Data annotation, donde decimos que la propiedad es requerida
        [Required(ErrorMessage = "Es necesario un RFC", ErrorMessageResourceName = null)]
        //Data annotation para validar el tamaño de la propiedad
        [StringLength(13, ErrorMessage = "El RFC no debe ser mayor a 13 caracteres", ErrorMessageResourceName = null)]
        //Propiedad que guarda el numero del proveedor
        public string Num_Prov { get; set; }
        //Propiedad que guarda el status del proveedor, esta encapsulado para su uso
        private TypeStatus status;
        //Propiedad que permite solo leer el status
        public TypeStatus Status { get => status; }
        //Lista de todos los productos que vende el proveedor
        public List<Productos> productos_que_vende = new List<Productos>();
        //Metodo para generar el ID del proveedor, es la palabra PROV, 3 numeros y 3 letras (generado de manera aleatorio)
        private string GenerateID()
        {
            string new_ID = "PROV";

            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                if (i < 2)
                {
                    new_ID += (char)random.Next(65, 90);
                }
                else
                {
                    new_ID += random.Next(10000).ToString("0000");
                }
            }
            return new_ID;
        }
        //Constructor para almacenar el id del proveedor, recibe como parametro su ID
        public Proveedor(string Id_Prov)
        {
            this.Id_Prov = Id_Prov;
            status = TypeStatus.ACTIVE;
        }
        //Constructor para generar un nuevo proveedor
        public Proveedor()
        {
            Id_Prov = GenerateID();
            status = TypeStatus.ACTIVE;
        }
        //Sobre escribimos el metodo to string, para devolver la descripcion, en el caso de los nulos se toma cambia por la leyenda "No se tienen datos"
        public override string ToString()
        {
            string retorno = $"""
                Nombre de la empresa: {Nom_Prov}
                RFC: {rfc_Prov}
                Nombre del representante: {Rep_prov ?? "No se tienen datos"}
                Direccion: {Dir_prov}
                Correo: {Correo_prov}
                Numero telefonico: {Num_Prov}
                """;
            return retorno;
        }
    }
}
