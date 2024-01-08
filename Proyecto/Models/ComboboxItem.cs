namespace Proyecto_BD.Models
{
    //Item para que los combobox puedan tener valor
    public class ComboboxItem
    {
        //El texto que se mostrara en el combo
        public string Text { get; set; }
        //El valor que es que este tendra
        public object Value { get; set; }
        //Sobre escribimos el metodo to string
        public override string ToString()
        {
            return Text;
        }
        public ComboboxItem()
        {

        }
        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }
    }
}
