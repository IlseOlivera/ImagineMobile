using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Campos_extra
    {
        //ID de los campos extra
        public string ID_campos_extra { get; }
        //Propiedades opcionales (nulificables) que guardan informacion extra
        public Caracteristica_especifica? especificacion { get; set; }
        //Propiedades opcionales (nulificables) que guardan informacion extra
        public Caracteristica_especifica? comunicacion { get; set; }
        //Propiedades opcionales (nulificables) que guardan informacion extra
        public Caracteristica_especifica? accesorios { get; set; }
        //Propiedades opcionales (nulificables) que guardan informacion extra
        public Caracteristica_especifica? tecnologias { get; set; }
        //Propiedades opcionales (nulificables) que guardan informacion extra
        public Caracteristica_especifica? compatibilidad { get; set; }
        //Data annotation para decirle el limite de caracteres para describir la propiedad
        [StringLength(15, ErrorMessage = "El color debe ser solo de 15 caracteres", ErrorMessageResourceName = null)]
        //Propiedad opcional (nulificable) que guarda el color
        public string? color { get; set; }
        //Data annotation para decirle el limite de caracteres para describir la propiedad
        [StringLength(20, ErrorMessage = "El material debe ser de solo 20 caracteres", ErrorMessageResourceName = null)]
        //Propiedad opcional (nulificable) que guarda el material
        public string? material { get; set; }
        //Data annotation para decirle el limite de caracteres para describir la propiedad
        [StringLength(20, ErrorMessage = "La descripcion del tamaño solo debe contener 20 caracteres", ErrorMessageResourceName = null)]
        //Data annotation para limitar el minimo de letras que debe tener la propiedad
        [MinLength(1, ErrorMessage = "Debe de tener almenos una dimencion especificada", ErrorMessageResourceName = null)]
        //Propiedad opcional (nulificable) que guarda el tamaño
        public string? tamaño;
        //encapsulamiento del tamaño
        public string?[] Tamaño
        {
            get
            {
                //Separa el tamaño entre los puntos
                return tamaño?.Split('.') ?? null;
            }
            set
            {
                if (value is null)
                {
                    //Si es nulo el campo lo asigna como tal
                    tamaño = null;
                }
                else
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (value[i] is not null)
                        {
                            //Le da formato a la variable para guardarlo en la BD
                            tamaño += i + 1 == value.Length ? $"{value[i]}." : value[i];
                        }
                    }
                    if (tamaño.Length < 0)
                    {
                        //Si es de tamaño 0 lo asigna como nulo
                        tamaño = null;
                    }
                }

            }
        }
        //Data annotation para asigurar el rango de la variable numerica
        [Range(1, 1000000000000000, ErrorMessage = "Esa no es una capacidad correcta", ErrorMessageResourceName = null)]
        //variable opcional (nulificalbe) que guarda la capacidad
        public int? capacida { get; set; }
        //Metodoo para generar el ID empieza con CAMEX, 3 numeros y letras de manera aleatoria
        private string GenerateID()
        {
            string new_ID = "CAMEX";

            for (int i = 0; i < 4; i++)
            {
                Random random = new Random();
                if (i < 3)
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
        //Constructor para crear campos extra
        public Campos_extra()
        {
            ID_campos_extra = GenerateID();
        }
        //Constructor para un campo extra ya existente
        public Campos_extra(string ID_campos_extra)
        {
            this.ID_campos_extra = ID_campos_extra;
        }
    }
}
