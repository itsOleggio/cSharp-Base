namespace task1;

class Program
{

    static double SquareTriangle(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        double Sruare = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

        return Sruare;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Введите сторону а для первого треугольника:");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b для первого треугольника:");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c для первого треугольника:");
        double c1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите сторону а для второго треугольника:");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону b для второго треугольника:");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону c для второго треугольника:");
        double c2 = Convert.ToDouble(Console.ReadLine());

        double sqrt1 = SquareTriangle(a1, b1, c1);
        double sqrt2 = SquareTriangle(a2, b2, c2);
        
        if (sqrt1 == sqrt2)
            Console.WriteLine("Площади равны");
        else
            if(sqrt1 > sqrt2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
            Console.WriteLine("Площадь второго треугольника больше");

        Console.WriteLine("S1: {0:.00}, S2: {1:.00}", sqrt1, sqrt2);
        Console.ReadKey();
    }
}