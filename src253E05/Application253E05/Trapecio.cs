namespace Application253E05;
public static class Trapecio
{
    public static double Perimetro(double ladoa, double ladob, double ladoc)
    {
        double perimetro = (2 * ladoa + ladob + ladoc);
        return perimetro;
    }
    public static double Area(double angulod, double ladob, double ladoc)
    {
        double area = angulod * (ladob + ladoc) / 2;
        return area;
    }

    public static double Volumen(double area, double altura)
    {
        double volumen = area * altura;
        return volumen;
    }

}