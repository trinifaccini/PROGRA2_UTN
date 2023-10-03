using System;
using System.Text;

namespace Lavadero2016
{
	public class Camion : Vehiculo
	{

		protected float tara;

        public Camion(string patente, Byte cantRuedas, EMarcas marca, float tara) : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Tara:" + tara);

            return sb.ToString();
        }
    }
}

