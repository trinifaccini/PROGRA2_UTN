using Automovilismo;

internal class Program
{
    private static void Main(string[] args)
    {

        AutoF1 auto1 = new(12, "Ferrari");
        AutoF1 auto2 = new(12, "Ferrari");
        AutoF1 auto3 = new(15, "Mercedes");
        AutoF1 auto4 = new(20, "Peugot");
        AutoF1 auto5 = new(12, "Peugot");
        AutoF1 auto6 = new(1, "Nissan");

        Competencia competencia = new(10, 4);

        bool agregado1 = competencia + auto1; //True
        bool agregado2 = competencia + auto2; //False
        bool agregado3 = competencia + auto3; //True
        bool agregado4  = competencia + auto4; //True
        bool agregado5 = competencia + auto5;// True
        bool agregado6 = competencia + auto6;// False

        Console.WriteLine(agregado1);
        Console.WriteLine(agregado2);
        Console.WriteLine(agregado3);
        Console.WriteLine(agregado4);
        Console.WriteLine(agregado5);
        Console.WriteLine(agregado6);

        Console.WriteLine(competencia.MostrarDatos());



    }

}
