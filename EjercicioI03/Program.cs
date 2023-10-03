namespace EjercicioI03
{

    public class Program
    {
        public static void Main(string[] arg)
        {
            
            Estudiante estudiante1 = new("Trinidad", "Faccini","111010");
            Estudiante estudiante2 = new("Thiago", "Lopez","111020");
            Estudiante estudiante3 = new("Olivia", "Fernandez","111030");

            estudiante1.SetNotaPrimerParcial(8);
            estudiante1.SetNotaSegundoParcial(7);
            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(3);
            estudiante3.SetNotaPrimerParcial(7);
            estudiante3.SetNotaSegundoParcial(9);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}