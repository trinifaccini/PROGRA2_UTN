using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace EjercicioI03
{
	public class Estudiante
	{
		private string apellido;
		private string legajo;
        private string nombre;
		private int notaPrimerParcial;
		private int notaSegundoParcial;
		private static Random random;

        static Estudiante()
		{
			random = new Random();
		}

		public Estudiante(string nombre, string apellido, string legajo)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.legajo = legajo;
		}

		public double CalcularNotaFinal()
		{
			int notaFinal = -1; 
			if(notaSegundoParcial >= 4 && notaPrimerParcial >= 4)
			{
				notaFinal = random.Next(6,10);
			}

			return notaFinal;
		}

		private float CalcularPromedio()
		{
			return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

		public string Mostrar()
		{
			StringBuilder datos = new StringBuilder("DATOS DEL ALUMNO\n");

			datos.AppendFormat($"Nombre y apellido: {nombre} {apellido}\n");
			datos.AppendFormat($"Legajo: {legajo}\n");
			datos.AppendFormat($"Nota primer parcial: {notaPrimerParcial}\n");
			datos.AppendFormat($"Nota segundo parcial: {notaSegundoParcial}\n");
			datos.AppendFormat($"Promedio: {CalcularPromedio()}\n");
			string final = CalcularNotaFinal() > 0 ? ("Final: " + CalcularNotaFinal().ToString()) : "Alumno desaprobado";
			datos.AppendFormat($"{final}");

			return datos.ToString();
        }

		public void SetNotaPrimerParcial(int nota)
		{
			this.notaPrimerParcial = nota;
		}

		public void SetNotaSegundoParcial(int nota)
		{
			this.notaSegundoParcial = nota;
		}

	}
}

