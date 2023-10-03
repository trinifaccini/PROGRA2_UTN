namespace Billetes;

public class Dolar
{
    private double cantidad;
    private static double cotzRespectoDolar;

    static Dolar()
    {
        cotzRespectoDolar = 1;
    }

    public Dolar(double cantidad)
    {
        this.cantidad = cantidad;
    }

    public double GetCantidad()
    {
        return cantidad;
    }

    public static double GetCotizacion()
    {
        return cotzRespectoDolar;
    }

    public static bool operator ==(Dolar a, Dolar b)
    {
        return a.cantidad == b.cantidad;
    }

    public static bool operator !=(Dolar a, Dolar b)
    {
        return !(a == b);
    }
}
