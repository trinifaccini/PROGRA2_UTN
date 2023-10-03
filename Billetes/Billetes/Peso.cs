namespace Billetes;

public class Peso
{

    private double cantidad;
    private static double cotzRespectoDolar;

    static Peso()
    {
        cotzRespectoDolar = 102.65;
    }

    public static explicit operator Euro(Peso p)
    {
        return (Euro)((Dolar)p);
    }

    public static explicit operator Dolar(Peso p)
    {
        return new Dolar(p.cantidad / Peso.GetCotizacion());
    }

    public Peso(double cantidad)
    {
        this.cantidad = cantidad;
    }

    public Peso(double cantidad, double cotizacion) : this(cantidad)
    {
        cotzRespectoDolar = cotizacion;
    }

    // SETTERS Y GETTERS

    public double GetCantidad()
    {
        return cantidad;
    }

    public static double GetCotizacion()
    {
        return cotzRespectoDolar;
    }

    // OPERADORES

    public static bool operator ==(Peso a, Peso b)
    {
        return a.cantidad == b.cantidad;
    }

    public static bool operator !=(Peso a, Peso b)
    {
        return !(a == b);
    }

    public static bool operator ==(Peso a, Dolar b)
    {
        return (Dolar)a == b;
    }

    public static bool operator !=(Peso a, Dolar b)
    {
        return !(a == b);
    }

    public static bool operator ==(Peso a, Euro b)
    {
        return (Euro)a == b;
    }

    public static bool operator !=(Peso a, Euro b)
    {
        return !(a == b);
    }

    public static Peso operator -(Peso p, Euro e)
    {
        return new Peso(p.cantidad - ((Peso)e).cantidad);
    }
    public static Peso operator -(Peso p, Dolar d)
    {
        return new Peso(p.cantidad - ((Peso)d).cantidad);
    }
    public static Peso operator +(Peso p, Euro e)
    {
        return new Peso(p.cantidad + ((Peso)e).cantidad);
    }
    public static Peso operator +(Peso p, Dolar d)
    {
        return new Peso(p.cantidad + ((Peso)d).cantidad);
    }




}


