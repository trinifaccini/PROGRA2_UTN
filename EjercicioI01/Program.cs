namespace EjercicioI01
{

    public class Program
    {
        public static void Main(string[] arg)
        {
            Cuenta cuenta = new Cuenta("Trinidad Faccini", 1000);

            cuenta.mostrar();
            cuenta.ingresar(200);
            cuenta.mostrar();
            cuenta.ingresar(-1000);
            cuenta.mostrar();
            cuenta.retirar(200);
            cuenta.mostrar();

        }
    }
}