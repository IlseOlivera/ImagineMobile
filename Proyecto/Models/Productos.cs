using Proyecto_BD.Enumerables;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_BD.Models
{
    public class Productos
    {

        public string Id_productos { get; set; }
        //Data annotation que valida que la propiedad sea requerido
        [Required(ErrorMessage = "Es necesario campos extra para el producto", ErrorMessageResourceName = null)]
        //campo que guarda la relacion a los campos extra
        public Campos_extra campos_Extra { get; set; }
        //Campo que valida que tipo de producto es
        public TypeOfProductos tipo { get; set; }

        //Data annotation que valida que la propiedad sea requerido
        [Required(ErrorMessage = "Es necesario un modelo", ErrorMessageResourceName = null)]
        //Data annotation que valida que rango se encuentra los campos (numericos)
        [Range(1, 10000000000 - 1, ErrorMessage = "La cantidad insertada no es correcta", ErrorMessageResourceName = null)]
        public double modelo { get; set; }
        //Data annotation que valida que la propiedad sea requerido
        [Required(ErrorMessage = "Es necesario un modelo", ErrorMessageResourceName = null)]
        //Data annotation que valida que rango se encuentra los campos (numericos)
        [Range(1, 100000, ErrorMessage = "La cantidad insertada no es correcta", ErrorMessageResourceName = null)]
        public int precio { get; set; }
        //Data annotation que valida que la propiedad sea requerido
        [Required(ErrorMessage = "Es necesaria una cantidad", ErrorMessageResourceName = null)]
        //Data annotation que valida que rango se encuentra los campos (numericos)
        [Range(0, 10000, ErrorMessage = "La cantidad insertada no es correcta", ErrorMessageResourceName = null)]
        public int cantidad { get; set; }
        //El estatus de si esta activo o borrado el campo
        public TypeStatus status { get; set; }
        //Metodo para generar el ID, donde se toma las primeras 3 a 5 letras del producto y se tomara de 3 a 4 letras con 3 a 2 numeros (generado de manera aleatoria)
        private string GenerateID()
        {
            string new_ID = string.Empty;
            switch (tipo)
            {
                case TypeOfProductos.MICAS:
                    new_ID += "MICA"; //1-4
                    break;
                case TypeOfProductos.PROTECTORES:
                    new_ID += "PROT"; //2-4
                    break;
                case TypeOfProductos.AUDIFONOS:
                    new_ID += "AUD"; //1-3
                    break;
                case TypeOfProductos.BOCINAS:
                    new_ID += "BOC"; //2-3
                    break;
                case TypeOfProductos.CARGADORES:
                    new_ID += "CARG"; //3-4
                    break;
                case TypeOfProductos.MOUSE:
                    new_ID += "MOUS"; //4-4
                    break;
                case TypeOfProductos.TECLADO:
                    new_ID += "TECLA"; //1-5
                    break;
                case TypeOfProductos.MONITOR:
                    new_ID += "MONI"; //5-4
                    break;
                case TypeOfProductos.CHIP:
                    new_ID += "CHIP"; //6-4
                    break;
                case TypeOfProductos.MEMORIAS:
                    new_ID += "MEMO"; //7-4
                    break;
                case TypeOfProductos.RECARGAS:
                    new_ID += "REC"; //3-3
                    break;
                case TypeOfProductos.TELEFONOS:
                    new_ID += "TEL"; //4-3
                    break;
            }

            if (tipo == TypeOfProductos.TECLADO)
            {
                for (int i = 0; i < 4; i++)
                {
                    Random random = new Random();
                    if (i < 3)
                    {
                        new_ID += (char)random.Next(65, 90);
                    }
                    else
                    {
                        new_ID += random.Next(100).ToString("00");
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Random random = new Random();
                    if (i < 4)
                    {
                        new_ID += (char)random.Next(65, 90);
                    }
                    else
                    {
                        if (tipo == TypeOfProductos.AUDIFONOS || tipo == TypeOfProductos.BOCINAS || tipo == TypeOfProductos.RECARGAS || tipo == TypeOfProductos.TELEFONOS)
                        {
                            new_ID += random.Next(1000).ToString("000");
                        }
                        else
                        {
                            new_ID += random.Next(100).ToString("00");
                        }
                    }
                }
            }
            return new_ID;
        }
        //Constructor vacio para generar el producto cuando se tenga que seleccionar un producto en especifico
        public Productos() { }
        //Constructor con el tipo y el ID para cuando se seleccionen todos los productos
        public Productos(TypeOfProductos tipo, string Id_productos)
        {
            this.tipo = tipo;
            this.Id_productos = Id_productos;
            status = TypeStatus.ACTIVE;
        }
        //Constructor para generar un nuevo producto
        public Productos(TypeOfProductos tipo)
        {
            this.tipo = tipo;
            Id_productos = GenerateID();
            status = TypeStatus.ACTIVE;
        }
        //Metodo To string para la descripcion del producto incluyendo a los campos extra, si son nulos se muestra la leyenda "No hay informacion" o la cadena vacia
        public override string ToString()
        {
            string retorno = $"""
                    Modelo: {modelo}
                    Cantidad en stock: {cantidad}
                    Color del producto: {campos_Extra.color ?? "No hay informacion"}
                    Material: {campos_Extra.material ?? "No hay informacion"}
                    Dimensiones: 
                    """;
            if (campos_Extra.Tamaño != null)
            {
                for (int i = 0; i < campos_Extra.Tamaño.Length; i++)
                {
                    retorno += (campos_Extra.Tamaño[i] != string.Empty ? campos_Extra.Tamaño[i] : "0") + (i + 1 < campos_Extra.Tamaño.Length ? "cm X " : "cm\n");
                }
            }
            else
            {
                retorno += "No hay informacion";
            }

            retorno += $"""
                Especificaciones: {campos_Extra.especificacion?.caracteristica ?? String.Empty}
                Metodos de comunicacion: {campos_Extra.comunicacion?.caracteristica ?? String.Empty}
                Tecnologias que incluye: {campos_Extra.tecnologias?.caracteristica ?? String.Empty}
                Accesorios que inclye: {campos_Extra.accesorios?.caracteristica ?? String.Empty}
                """;
            return retorno;
        }
    }
}
