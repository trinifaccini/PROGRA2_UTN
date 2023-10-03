namespace Sumador
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            Sumador sumador1 = new();
            Sumador sumador2 = new(10);

            string cantidadSumas1 = (string)sumador1;
            string cantidadSumas2 = (string)sumador2;

            Console.WriteLine(cantidadSumas1);
            Console.WriteLine(cantidadSumas2);

            Console.WriteLine(sumador1.Sumar("hola", " como estas?"));
            Console.WriteLine(sumador1.Sumar(1, 2));

            cantidadSumas1 = (string)sumador1;
            cantidadSumas2 = (string)sumador2;

            Console.WriteLine(cantidadSumas1);
            Console.WriteLine(cantidadSumas2);

            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);


        }

    }
}