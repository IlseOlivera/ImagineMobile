using Proyecto_BD.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Caracteristica_especifica
    {
        //Id de la caracterisitca
        public string Id_Ca { get; }
        //El tipo de caracteristica que es
        public TypeExtra tipo { get; }
        //Data annotation para decir que este campo es requerido
        [Required(ErrorMessage = "Es necesario que de una descripcion de la caracteristica", ErrorMessageResourceName = null)]
        //Data annotation para limitar la cantidad de caracteres que puede tener
        [StringLength(30, ErrorMessage = "La descripcion debe ser menor a 30 caracteres", ErrorMessageResourceName = null)]
        //Propiedad donde se guarda la caracteristica 
        public string caracteristica { get; set; }
         //Metodo para generar el ID, dependideno del tipo puede iniciar de una manera pero siempre lleva 3 numeros y 3 letras de manera aleatoria
        private string GenerateID()
        {
            string new_ID = string.Empty;
            switch (tipo)
            {
                case TypeExtra.TECNOLOGIAS:
                    new_ID += "TECN";
                    break;
                case TypeExtra.METODOS_DE_COMUNICACION:
                    new_ID += "COMU";
                    break;

                case TypeExtra.COMPATIBILIDAD:
                    new_ID += "COMP";
                    break;

                case TypeExtra.ESPECIFICACIONES:
                    new_ID += "SPEC";
                    break;
                case TypeExtra.ACCESORIOS:
                    new_ID += "ACCP";
                    break;
            }
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

        //Constructor para asignar una caracterisitca especifica que ya se sabe su id
        public Caracteristica_especifica(TypeExtra tipo, string Id_Ca)
        {
            this.tipo = tipo;
            this.Id_Ca = Id_Ca;
        }
        //Constructor para crear una nueva caracteristica especifica
        public Caracteristica_especifica(TypeExtra tipo)
        {
            this.tipo = tipo;
            Id_Ca = GenerateID();
        }
    }
}
