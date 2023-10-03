using System;
using System.Text;

namespace Lavadero2016
{
	public class Moto : Vehiculo
	{
		protected float cilindrada;

        public Moto(string patente, Byte cantRuedas, EMarcas marca, float cilindrada) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Cilindrada:" + cilindrada);

            return sb.ToString();
        }
    }

}

