using System.Text;

namespace Lavadero2016
{
	public class Auto: Vehiculo
	{
		protected int cantidadAsientos; 

		public Auto(string patente, Byte cantRuedas, EMarcas marca, int asientos): base(patente,cantRuedas, marca)
		{
			this.cantidadAsientos = asientos;
		}

		public string MostrarAuto()
		{

			StringBuilder sb = new StringBuilder();
			sb.Append(base.Mostrar());
			sb.AppendLine("Asiendos:" + cantidadAsientos);

			return sb.ToString();
		}
	}
}

