using System;
namespace EjercicioC01
{
	public class NumeroBinario
	{
		private string numero;

		private NumeroBinario(string numero)
		{
			this.numero = numero;
		}

		public string GetNumero()
		{
			return numero;
		}


		public static string operator +(NumeroBinario b, NumeroDecimal d)
		{
			double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
			double suma = convertido + d.GetNumero();

			return Conversor.ConvertirDecimalABinario(suma);
		}

		public static string operator -(NumeroBinario b, NumeroDecimal d)
		{
            double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
            double resta = convertido - d.GetNumero();

            return Conversor.ConvertirDecimalABinario(resta);
        }


		public static bool operator ==(NumeroBinario b, NumeroDecimal d)
		{
            double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
			return convertido == d.GetNumero();
        }

		public static bool operator != (NumeroBinario b, NumeroDecimal d)
		{
			return !(b == d);
		}

        public static implicit operator NumeroBinario(string b)
		{
			return new NumeroBinario(b);
		}

        public static explicit operator string(NumeroBinario b)
        {
			return b.GetNumero();
        }


    }
}

