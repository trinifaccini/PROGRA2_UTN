using System;
namespace Sumador
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {
            cantidadSumas = 0;
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public int GetCantidadSumas()
        {
            return cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return string.Concat(a, b);
        }

        public static explicit operator string(Sumador s)
        {
            return s.cantidadSumas.ToString();
        }

        /*
         * Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El
resultado será un long correspondiente al resultado de la suma del atributo
cantidadSumas de cada argumento.
3. Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá
retornar true si ambos sumadores tienen igual valor en el atributo
cantidadSumas.

         * */
        public static long operator +(Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadSumas == b.cantidadSumas;
        }
    }
}

