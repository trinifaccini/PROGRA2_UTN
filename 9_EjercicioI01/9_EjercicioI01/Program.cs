using _9_EjercicioI01;

public class Program
{

    public static void Main(string[] args)
    {
        
        Console.Title = "Ejercicio Sobre-Sobrescrito";
        // Sobrescrita objetoSobrescrito = new Sobrescrita();
        SobreSobrescrita objetoSobrescrito = new SobreSobrescrita();
        Console.WriteLine(objetoSobrescrito.ToString());
        string objeto = "¡Este es mi método ToString sobrescrito!";
        Console.WriteLine("----------------------------------------------");
        Console.Write("Comparación Sobrecargas con String: ");
        Console.WriteLine(objetoSobrescrito.Equals(objeto));
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(objetoSobrescrito.GetHashCode());
        Console.ReadKey();
        


    }
}
