using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes;

public class Jugador
{
    private int dni;
    private string nombre;
    private int partidosJugados;
    private float promedioGoles;
    private int totalGoles;

    private Jugador()
    {
        dni = 0;
        nombre = "";
        partidosJugados = 0;
        promedioGoles = 0;
        totalGoles = 0;
    }

    public Jugador(int dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
    }

    public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni, nombre)
    {
        this.totalGoles = totalGoles;
        partidosJugados = totalPartidos;
    }

    public float GetPromedioGoles() { 
        promedioGoles = totalGoles / partidosJugados;
        return promedioGoles;
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
        return j1.dni == j2.dni;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
        return !(j1 == j2);
    }

    public string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Nombre: " + nombre);
        sb.AppendLine("DNI: " + dni);
        sb.AppendLine("Partidos jugados: " + partidosJugados);
        sb.AppendLine("Goles anotados: " + totalGoles);
        sb.AppendLine("Promedio de goles: " + promedioGoles);

        return sb.ToString();
    }



}
