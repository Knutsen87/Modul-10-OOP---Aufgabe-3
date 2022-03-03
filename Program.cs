Console.WriteLine("Bitte geben Sie ihren ersten Wert ein: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Bitte geben Sie ihren zweiten Wert ein: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Rechteck: \n" + AreaCalculator.Rechteck(a, b));
Console.WriteLine("Quadrat: \n" + AreaCalculator.Quadrat(a, b));
Console.WriteLine("Kreis: \n" + AreaCalculator.Kreis(a, b));
Console.WriteLine("Dreieck: \n" + AreaCalculator.Dreieck(a, b));

Console.WriteLine("Vielen Dank für das Benutzen von meinem Testprogramm.");

Console.ReadKey();
class  AreaCalculator
{
    public static double Rechteck(double höhe, double breite)
    {
       return höhe * breite;
    }
    public static double Quadrat(double Seitenlänge, double b)
    {
        return Seitenlänge * Seitenlänge;
    }
    public static double Kreis(double Radius, double b)
    {
        return Radius * Radius * Math.PI;
    }
    public static double Dreieck(double Grundseitenlänge, double Höhe)
    {
        return ((Grundseitenlänge * Höhe) / 2);
    }
}

