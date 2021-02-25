using System;

class Cuadrado
{
    public double Perimetro(double l)
    {
        return 4 * l;
    }
    public double Area(double l)
    {
        double A = 0;
        A = Math.Pow(l, 2);
        return A;
    }
}
