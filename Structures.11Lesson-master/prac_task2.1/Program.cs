namespace prac_task2._1;

class Program
{
    static void Main(string[] args)
    {
        double k = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        
        lineEqual lineEqual = new();

        
        Console.WriteLine("Корень уравнения: {0}", lineEqual.Root(k,b));
    }
}