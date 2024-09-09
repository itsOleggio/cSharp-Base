namespace Circle;

class Program
{
    static void GetParamsSphere(double r, out double S, out double V)
    {
        S = 4 * Math.PI * r * r;
        V = 4.0 / 3 * Math.PI * r * r;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите радиус: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        double s;
        double v;
        GetParamsSphere(r, out s, out v);
        Console.WriteLine("S: {0:.00}, V: {1:.00}", s, v);
        Console.ReadKey();
    }
}