using System;

public class Pizza
{
    private int _Id;
    private string _Nombre;
    private double _Precio;
    private string _Ingredientes;

    public Pizza(int _Id, string _Nombre, double _Precio, string _Ingredientes)
    {
        int Id = _Id;
        string Nombre = _Nombre;
        double Precio = _Precio;
        string Ingredientes = _Ingredientes;
    }
    public Pizza()
    { }

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
    public double Precio
    {
        get { return _Precio; }
        set { _Precio = value; }
    }
    public string Ingredientes
    {
        get { return _Ingredientes; }
        set { _Ingredientes = value; }
    }
}