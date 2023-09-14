namespace Deportes;

public class Equipo
{
    private short cantidadDeJugadores;
    private List<Jugador> jugadores;
    private string nombre;

    private Equipo()
    {
        jugadores = new List<Jugador>();
        cantidadDeJugadores = 0;
        nombre = string.Empty;
    }

    //VER ESTO
    public Equipo(short cantidad, string nombre):this()
    {
        cantidadDeJugadores = cantidad;
        this.nombre = nombre;
    }

    public static bool operator +(Equipo e, Jugador j)
    {
        if (e.jugadores.Count < e.cantidadDeJugadores)
        {
            if (e.jugadores.Count == 0)
            {
                e.jugadores.Add(j);
                return true;
            }

            else
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador != j)
                    {
                        e.jugadores.Add(j);
                        return true;
                    }
                }
            }
            
        }
        return false;
    }

}