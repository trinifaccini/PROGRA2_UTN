using System;
namespace _9_EjercicioI01
{
	public  abstract class Sobrescrita
	{
        #region PARTE 2

        protected string miAtributo;

        public Sobrescrita()
        {
            miAtributo = "Probar abstractos";
        }

        // solo definimos, no implementamos los metodos abstractos
        protected abstract string MiPropiedad
        {
            get;
        }

        protected abstract string MiMetodo();
        #endregion 

        #region PARTE 1
        public override string ToString()
        {
            return "¡Este es mi metodo ToString sobreescrito!";
        }

        // Recordar que no se pueede cambiar la firma si estamos sobreescribiendo
        public override bool Equals(object? obj)
        {
            if (obj is Sobrescrita)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
        #endregion
    }
}

