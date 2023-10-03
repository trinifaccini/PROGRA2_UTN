using System;

/*
 * PREGUNTAR O AVERIGUAR SOBRE "BIBLIOTECA DE CLASES"
 * Crear una aplicación de consola y una biblioteca de clases que contenga la clase
Cuenta.
Deberá tener los atributos:
● titular que contendrá la razón social del titular de la cuenta.
● cantidad que será un número decimal que representa al monto actual de dinero
en la cuenta.
Construir los siguientes métodos para la clase:
● Un constructor que permita inicializar todos los atributos.
● Un método getter para cada atributo.
● mostrar retornará una cadena de texto con todos los datos de la cuenta.
● ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es
negativo, no se hará nada.
● retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en
negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir
mostrando como va variando el saldo.
*/

namespace EjercicioI01
{
	public class Cuenta
	{
		private string titular;
		private double cantidad;

		public Cuenta(string titular, double cantidad)
		{
			this.titular = titular;
			this.cantidad = cantidad;
		}

		public string getTitular()
		{
			return this.titular;
		}

        public double getCantidad()
        {
            return this.cantidad;
        }

		public void mostrar()
		{
			Console.WriteLine("Razon social: " + this.titular + " - Monto actual de dinero: " + this.cantidad);
		}

		public void ingresar(double monto)
		{
			if (monto >= 0)
			{
				this.cantidad += monto;
			}
		}

		public void retirar(double monto)
		{
			if (monto >= 0)
			{
				this.cantidad -= monto;
			}
		}
    }
}

