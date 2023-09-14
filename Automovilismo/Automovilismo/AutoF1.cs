using System.Text;

namespace Automovilismo
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Numero: " + numero);
            sb.AppendLine("Escuderia: " + escuderia);
            string compite = enCompetencia ? "Si" : "No";
            sb.AppendLine("Compite: " + compite);
            sb.AppendLine("Combustible: " + cantidadCombustible);
            sb.AppendLine("Vueltas restantes: " + vueltasRestantes);
            
            return sb.ToString();
        }

        public void SetCantidadCombustible(short cantidad)
        {
            cantidadCombustible = cantidad;
        }

        public void SetEnCompetencia(bool compitiendo)
        {
            enCompetencia = compitiendo;
        }

        public void SetVueltasRestantes(short cantidad)
        {
            vueltasRestantes = cantidad;
        }

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.escuderia == a2.escuderia && a1.numero == a2.numero)
                return true;
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


    }
}