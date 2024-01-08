using Proyecto_BD.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Usuarios
    {
        //Id para identificar el usuario
        public string id_US { get; }
        //Usamos las data anotation para validar si es requerido
        [Required(ErrorMessage = "Es requerido tu nombre", ErrorMessageResourceName = null)]
        //' para validar el tamaño de la cadena si es menor
        [StringLength(20, ErrorMessage = "El usuario no puede ser mayor a 20 caracteres", ErrorMessageResourceName = null)]
        //Propiedad que guarda el nombre del usuario
        public string Nom_US { get; set; }
        //' para validad que si se lleno el campo
        [Required(ErrorMessage = "Es necesario un apellido paterno", ErrorMessageResourceName = null)]
        //'para validad el tamaño de la propiedad
        [StringLength(15, ErrorMessage = "El apellido paterno no debe ser mayor a 15 caracteres", ErrorMessageResourceName = null)]
        //Propiedad para guardar el apellido materno
        public string Ap_Us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "Es necesario un apellido materno", ErrorMessageResourceName = null)]
        //' para validar el tamaño de la propiedad
        [StringLength(15, ErrorMessage = "El apellido materno no debe ser mayor a 15 caracteres", ErrorMessageResourceName = null)]
        //propiedad para guardar el apellido materno
        public string Am_Us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "Es necesario un RFC", ErrorMessageResourceName = null)]
        //'para validad el tamaño de la propiedad
        [StringLength(13, ErrorMessage = "El RFC no debe ser mayor a 13 caracteres", ErrorMessageResourceName = null)]
        //' para validar que si sea un RFC valido
        [RegularExpression(@"^\w{4}\d{6}\w{3}$", ErrorMessage = "Esto no es un RFC", ErrorMessageResourceName = null)]
        //propiedad para guardar el RFC
        public string rfc_Us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "El CURP es necesario", ErrorMessageResourceName = null)]
        //'para validad el tamaño de la propiedad
        [StringLength(18, ErrorMessage = "El CURP  no debe ser mayor a 18 caracteres", ErrorMessageResourceName = null)]
        // Propiedad para guardar el CURP
        public string curp_us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "Es necesario un numero de seguro social", ErrorMessageResourceName = null)]
        //'para validad el tamaño de la propiedad
        [StringLength(11, ErrorMessage = "El numero de seguro social no es mayor a 11 caracteres", ErrorMessageResourceName = null)]
        //Propiedad para guardar el numero de seguro social
        public string nss_Us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "Es necesario un numero de telefono", ErrorMessageResourceName = null)]
        //' para validar de que rango a que rango es la propiedad
        [Range(1111111111, 9999999999, ErrorMessage = "Eso no es un numero de telefono", ErrorMessageResourceName = null)]
        //propiedad para guardar el telefono
        public double Tel_Us { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "El correo es necesario", ErrorMessageResourceName = null)]
        //' para validar que el correo electronico cumpla con el patron
        [RegularExpression(@"^\w{1,64}@(\w{1,255})\.com$", ErrorMessage = "Esto no es un correo electronico", ErrorMessageResourceName = null)]
        //propiedad para guardar el correo electronico
        public string correo_electronico { get; set; }
        //' para validar que si es requerido el campo
        [Required(ErrorMessage = "Es necesario una fecha de nacimiento", ErrorMessageResourceName = null)]
        // propiedad para guardar la fecha de nacimiento
        public DateTime fchNac_Us { get; set; }
        // propiedad para guardar la fecha de suscripcion, encapsulado para su uso
        private DateTime fching_Us;
        // solo se puede devolver y no modificar
        public DateTime Fching_Us { get => fching_Us; }
        //propiedad para asignarle el rol, encapsulado para su uso
        private TypeRole rol;
        // solo se puede devolver el valor
        public TypeRole Rol { get => rol; }
        //Estatus en el que se encuentra el usuario, encapsulado para su uso
        private TypeStatus status;
        //solo se puede devolver el valor
        public TypeStatus Status { get => status; }
        // Metodo para generar ID, es primero EMP, despues 3 letras y 3 numeros de manera aleatoria
        private string GenerateID()
        {
            string new_ID = "EMP";

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
        //Constructor vacio para que se genere el nuevo usuario
        public Usuarios()
        {
            //Se genera el id de manera automatica
            id_US = GenerateID();
            //Se le da el rol de empleado
            rol = TypeRole.EMPLEADO;
            //Se le da el estatus de activo
            status = TypeStatus.ACTIVE;
            //se da la fecha que se registro
            fching_Us = DateTime.Now;
        }
        //Constructor con los parametros de id, y la fecha de suscripcion para instanciar un usuario ya existente
        public Usuarios(string id_Us, TypeRole rol, DateTime fching_Us)
        {
            //Se asigna el id
            id_US = id_Us;
            //Se asigna el rol
            this.rol = rol;
            //Se le asigna el tipo de status
            status = TypeStatus.ACTIVE;
            //La fecha que se unio
            this.fching_Us = fching_Us;
        }
        //Sobre escribimos el metodo de toString
        public override string ToString()
        {
            //Retornamos el detalle de los productos
            string retorno = $"""
                Nombre del empleado: {Nom_US}
                Apellido paterno: {Ap_Us}
                Apellido materno: {Am_Us}
                RFC: {rfc_Us}
                CURP: {curp_us}
                Numero de seguro Social: {nss_Us}
                Telefono registrado: {Tel_Us}
                Correo electronico: {correo_electronico}
                Fecha de nacimiento: {fchNac_Us.ToString("dd/MM/yyyy")}
                Fecha registrado en el sistema: {Fching_Us.ToString("dd/MM/yyyy")}
                """;

            return retorno;

        }
    }
}
