namespace task2;

class Program
{
    static void getS(double a, out double S)
    {
        S = 6 * Math.Pow(a, 2);
    }
    
    static void getV(double a, out double V)
    {
        V = Math.Pow(a, 3);
    }
    
    static void Main(string[] args)
    {
        Console.Write("Введите ребро куба A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        double V;
        double S;
        getS(A, out S);
        getV(A, out V);

        Console.WriteLine("Sкуба: {0}, Vкуба: {1}", S, V);
        Console.ReadKey();
    }
}