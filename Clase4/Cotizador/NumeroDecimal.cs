using System;
namespace EjercicioC01
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return numero;
        }


        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
            return convertido + d.GetNumero();
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
            return d.GetNumero() - convertido;
        }


        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            double convertido = Conversor.ConvertirBinarioADecimal(b.GetNumero());
            return convertido == d.GetNumero();
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(b == d);
        }

        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.GetNumero();
        }


    }
}


