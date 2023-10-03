using System;

/*
 * Crear una aplicación de consola y una biblioteca de clases que contenga la clase
Persona.
Deberá tener los atributos:
● nombre
● fechaDeNacimiento
● dni
Deberá tener un constructor que inicialice todos los atributos.
Construir los siguientes métodos para la clase:
● Setter y getter para cada uno de los atributos.
● CalcularEdad será privado y retornará la edad de la persona calculándola a
partir de la fecha de nacimiento.
● Mostrar retornará una cadena de texto con todos los datos de la persona,
incluyendo la edad actual.
● EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino
devuelve “es menor”.
1. Instanciar 3 objetos de tipo Persona en el método Main.
2. Mostrar quiénes son mayores de edad y quiénes no.
 * */
namespace EjercicioI02
{
	public class Persona
	{
		private string nombre;
		private DateTime fechaDeNacimiento;
		private string dni;

		public Persona(string nombre, DateTime fecha, string dni)
		{
			this.nombre = nombre;
			this.fechaDeNacimiento = fecha;
			this.dni = dni;
		}

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public string getNombre()
		{
			return this.nombre;
		}

        public void setFechaDeNacimiento(DateTime fecha)
		{
			this.fechaDeNacimiento = fecha;
		}

        public DateTime getFechaDeNacimiento()
		{
			return this.fechaDeNacimiento;
		}

        public void setDni(string dni)
		{
			this.dni = dni;
		}

        public string getDni()
		{
			return this.dni;
		}

		private string CalcularEdad()
		{

            TimeSpan ts = (DateTime.Now - this.fechaDeNacimiento);
            return Math.Floor((ts.TotalDays)/360).ToString();
        }

		public void Mostrar()
		{
			Console.WriteLine("Nombre: " + this.nombre +
				" Fecha de nacimiento: " + this.fechaDeNacimiento.ToString() +
				" DNI: " + this.dni +
				" Edad: " + CalcularEdad());
		}

		public string EsMayorDeEdad()
		{
			if (double.Parse(CalcularEdad()) >= 18)
			{
				return this.nombre + " es mayor de edad";
			}

			else
				return this.nombre + " es menor de edad";
		}
    }
}

