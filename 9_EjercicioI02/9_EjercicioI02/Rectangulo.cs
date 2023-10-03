using System;
namespace _9_EjercicioI02
{
	public class Rectangulo : Figura
	{
        private double lado1;
        private double lado2;

		public Rectangulo(double lado1, double lado2)
		{
            this.lado1 = lado1;
            this.lado2 = lado2;
		}

        public override string Dibujar()
        {
            return "Dibujando rectángulo";
        }

        public override double CalcularPerimetro()
        {
            return (lado1 * 2 + lado2 * 2);
        }

        public override double CalcularSuperficie()
        {
            return (lado1 * lado2);
        }
    }
}

