using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovilismo
{
    public class Competencia
    {

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> compeditores;
        private Competencia()
        {
            compeditores = new List<AutoF1>();

        }


        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad competidores: " + cantidadCompetidores);
            sb.AppendLine("Cantidad vueltas: " + cantidadVueltas);

            foreach(AutoF1 auto in compeditores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.compeditores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c.compeditores.Count < c.cantidadCompetidores)
            {
                if (c != a)
                {
                    c.compeditores.Add(a);
                    a.SetEnCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    Random random = new Random();
                    a.SetCantidadCombustible((short)random.Next(15,100));

                    return true;
                }
            }

            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (c.compeditores.Count == 0)
                return false;

            else
            {
                foreach (AutoF1 auto in c.compeditores)
                {
                    if (auto != a)
                        return false;
                    else
                        return true;
                }
            }

            return true;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
