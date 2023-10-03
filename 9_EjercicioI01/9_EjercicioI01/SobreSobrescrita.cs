using System;

namespace _9_EjercicioI01
{
	public class SobreSobrescrita : Sobrescrita
	{

		// IMPLEMENTACION DE PROPIEDAD ABSTRACTA
		protected override string MiPropiedad
		{
			get { return miAtributo; }
		}

		// IMPLEMENTACION DE METODO ABSTRACTO
		protected override string MiMetodo()
		{
			return MiPropiedad;
		}

        public override string ToString()
        {
            return MiMetodo();
        }
    }
}

