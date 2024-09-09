namespace prac_task2._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите радиус окружности: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координаты первой точки(x): ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты первой точки(y): ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Радиус окружности: {0}", r);
        Console.WriteLine("Координаты первой точки: {0}, {1}", x, y);
        Console.WriteLine("Площадь окружности: {0}", Math.Round(Circle.Square(r), 2));
        Console.WriteLine("Длина окружности: {0}", Math.Round(Circle.Length(r), 2));
        
        
        if (Circle.IsInside(x, y, r) == true)
            Console.WriteLine("Точка находится внутри окружности");
        else
            Console.WriteLine("Точка НЕ находится внутри окружности");
        Console.ReadKey();
    }
}