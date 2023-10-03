namespace EjercicioI02
{

    public class Program
    {
        public static void Main(string[] arg)
        {
            // año mes dia
            DateTime fecha1 = new(2001, 3, 28);
            DateTime fecha2 = new(2020, 5, 4);
            DateTime fecha3 = new(2005, 10, 18);

            Persona persona1 = new ("Trinidad Faccini", fecha1, "43243054");
            Persona persona2 = new ("Thiago Lopez", fecha2, "50987909");
            Persona persona3 = new ("Olivia Gonzales", fecha3, "45678901");

            persona1.Mostrar();
            Console.WriteLine(persona1.EsMayorDeEdad());

            persona2.Mostrar();
            Console.WriteLine(persona2.EsMayorDeEdad());

            persona3.Mostrar();
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}