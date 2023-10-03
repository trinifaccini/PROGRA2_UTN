namespace EjercicioI04
{

    public class Program
    {
        public static void Main(string[] arg)
        {

            Boligrafo azul = new(10, ConsoleColor.Blue);
            Boligrafo rojo = new(2, ConsoleColor.Red);

            Console.WriteLine(azul.GetColor());
            Console.WriteLine(rojo.GetColor());

            Console.WriteLine(azul.GetTinta());
            Console.WriteLine(rojo.GetTinta());

            string dibujoAzul = "";
            string dibujoRojo = "";

            azul.Pintar(5, out dibujoAzul);
            rojo.Pintar(3, out dibujoRojo);

            Console.WriteLine(dibujoAzul, azul.GetColor());
            Console.WriteLine(dibujoRojo, azul.GetColor());

            azul.Pintar(3, out dibujoAzul);
            rojo.Pintar(5, out dibujoRojo);

            Console.WriteLine(dibujoAzul, azul.GetColor());
            Console.WriteLine(dibujoRojo, azul.GetColor());

            azul.Recargar();
            rojo.Recargar();

            Console.WriteLine(azul.GetTinta());
            Console.WriteLine(rojo.GetTinta());


        }
    }
}