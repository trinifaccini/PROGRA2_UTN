using System;
namespace Clase4
{
	public class Cosa
	{
		private int entero;
		private string cadena;
		private DateTime fecha;

		public void EstablecerValor(int valor)
		{
			this.entero = valor;
		}

		public void EstablecerValor(string valor)
		{
			this.cadena = valor;
		}

		public void EstablecerValor(DateTime valor)
		{
			this.fecha = valor;
		}


        public void Mostrar()
        {
            Console.WriteLine($"Entero: {this.entero}\n");
            Console.WriteLine($"Fecha: {this.fecha.ToString()}\n");
            Console.WriteLine($"Cadena: {this.cadena}\n");
        }


        public Cosa()
		{
			this.fecha = DateTime.Now;
			this.cadena = "sin valor";
			this.entero = 10;
		}

        public Cosa(string cadena):this()
        {
            this.cadena = cadena;
        }

        public Cosa(int entero, string cadena):this(cadena)
        {
            this.entero = entero;
        }

        public Cosa(DateTime fecha, int entero, string cadena):this(entero, cadena)
		{
			this.fecha = fecha;
			this.entero = entero;
			this.cadena = cadena;
		}
	}
}

