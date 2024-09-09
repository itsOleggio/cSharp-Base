namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Площаль: {0}, Периметр: {1}", Rectangle.GetSquare(a, b),  Rectangle.GetPerimeter(a, b));
    }
}