namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int totalSquares = 0;

        Console.Write("Введите сторону прямоугольника А:");
        int A = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите сторону прямоугольника B:");
        int B = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите сторону квадрата С:");
        int C = Convert.ToInt16(Console.ReadLine());

        // Используемые переменные для отслеживания оставшейся длины сторон прямоугольника
        int balanceA = A; // Верикаль 
        int balanceB = B; // Горизонталь

        /*
            Считаем сначала горизонталь, потом по вертикали пока не упремся
        */
        while (balanceA >= C)
        {
            while (balanceB >= C)
            {
                totalSquares++;
                balanceB -= C;
            }

            balanceB = B;
            balanceA -= C;
        }

        Console.WriteLine($"Количество квадратов: {totalSquares}");
        Console.ReadKey();
    }
}