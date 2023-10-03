using System;
namespace _9_EjercicioI02
{
	public class Circulo : Figura
	{
        private double radio;

		public Circulo(double radio)
		{
            this.radio = radio;
		}

        public override string Dibujar()
        {
            return "Dibujando círculo";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

    }
}

