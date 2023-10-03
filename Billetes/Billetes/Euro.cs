namespace Billetes;

public class Euro
{
    private double cantidad;
    private static double cotzRespectoDolar;
    static Euro()
    {
        cotzRespectoDolar = 1.17 / 1;
    }

    public Euro(double cantidad)
    {
        this.cantidad = cantidad;
    }

    public Euro(double cantidad, double cotizacion) : this(cantidad)
    {
        cotzRespectoDolar = cotizacion;
    }

    public double GetCantidad()
    {
        return cantidad;
    }

    public static double GetCotizacion()
    {
        return cotzRespectoDolar;
    }

    public static bool operator ==(Euro a, Euro b)
    {
        return a.cantidad == b.cantidad;
    }

    public static bool operator !=(Euro a, Euro b)
    {
        return !(a == b);
    }

    public static bool operator ==(Euro a, Dolar b)
    {
        return a == (Euro)b;
    }

    public static bool operator !=(Euro a, Dolar b)
    {
        return !(a == (Euro)b);
    }

    public static explicit operator Euro(Dolar d)
    {
        return new Euro(d.GetCantidad() * cotzRespectoDolar);
    }
}

