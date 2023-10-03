namespace Lavadero2016;
using System;
using System.Text;

public class Vehiculo
{
    protected string patente;
    protected Byte cantRuedas;
    protected EMarcas marca;

    public string Patente
    {
        get { return patente;}
    }


    public EMarcas Marca
    {
        get { return marca; }
    }


    protected string Mostrar()
    {

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Patente: " + patente);
        sb.AppendLine("Ruedas: " + cantRuedas);
        sb.AppendLine("Marca: " + marca.ToString());

        return sb.ToString();

    }


    public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
    {
        this.patente = patente;
        this.cantRuedas = cantRuedas;
        this.marca = marca;
    }


    public static bool operator ==(Vehiculo v1, Vehiculo v2)
    {
        return v1.Patente == v1.Patente && v1.marca == v2.marca;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
        return !(v1 == v2);
    }









}



