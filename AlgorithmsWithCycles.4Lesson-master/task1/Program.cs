namespace task1;

class Program
{
    static void Main(string[] args)
    {
        bool ch = true;
        Console.Write(" Ввести целое число N > 0: ");
        int N = Convert.ToInt16(Console.ReadLine());
        int sum = 0; 
        int square = 0;
        while (ch) // While используем только для проверки введеного значения 
        {
            if (N < 1)
            {
                Console.Write("Число меньше 0. Введите ещё раз: ");
                N = Convert.ToInt16(Console.ReadLine());
            }
            else ch = false;
        }

        for (int i = 1; i <= N; i++)
        {
            sum += 2*i - 1;
            square = sum; // Сумма слагаемых до текущего шага равна квадрату числа
            Console.WriteLine("Итерация: {0} / Сумма {1}", i, square);
        }
        Console.ReadKey();
    }
}