using Proyecto_BD.Enumerables;

namespace Proyecto_BD.Models
{
    public class Venta
    {
        //Cadena que es el ide, se auto genera
        public string Id_venta { get; set; }
        //Fecha en al que se hace la venta
        public DateTime Fecha_venta { get; set; }
        //El timeSpan toma la hora, para la hora que se realizo la venta
        public TimeSpan Hora_Venta { get; set; }
        //Es la cantidad de productos que se vendieron
        public int Cant_venta { get; set; }
        //El precio de cada producto
        public int Precio_venta = 0;
        //El total de la venta que se realizo
        public double Total_Venta { get; set; }
        //El tipo de pago que se realizo
        public TypeOfPay Pago_venta { get; set; }
        //El status de la venta (si fue borrada)
        public TypeStatus status { get; set; }
        //metodo para generar el ID que es 4 digitos del año, dos para el mes y dos para el dia con otros cuatro numeros aleatorios
        private string GenerateID()
        {
            Random rnd = new Random();
            return $"{Fecha_venta.ToString("yyyy")}{Fecha_venta.ToString("MM")}{Fecha_venta.ToString("dd")}{rnd.Next(1000).ToString("0000")}";
        }
        //Constructor de la venta vacio
        public Venta()
        {
            //Se toma la fecha actual
            Fecha_venta = DateTime.Now;
            //Se toma la hora actual
            Hora_Venta = DateTime.Now.TimeOfDay;
            //Se genera el ID
            Id_venta = GenerateID();
            //Se coloca en activo
            status = TypeStatus.ACTIVE;
        }
        //Constructor que recibe el id 
        public Venta(string id_venta)
        {
            //Se asigna el id
            Id_venta = id_venta;
            //Se cambia el status a activo
            status = TypeStatus.ACTIVE;
        }

    }
}
