namespace Clase4
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            Cosa cosa1 = new();
            Cosa cosa2 = new("chau");
            Cosa cosa3 = new(15, "hola");

            DateTime fecha = new(2000, 10, 10);
            Cosa cosa4 = new(fecha,20, "jaja");

            cosa1.Mostrar();
            cosa2.Mostrar();
            cosa3.Mostrar();
            cosa4.Mostrar();
        }
    }
}