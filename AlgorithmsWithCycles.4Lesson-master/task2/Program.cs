namespace task2;

class Program
{
    static void Main(string[] args)
    {
        int moreZero = 0;
        int lessZero = 0;
        int num = -1;

        do
        {
            Console.Write("Введите число: ");
            num = Convert.ToInt16(Console.ReadLine());

            if (num > 0) moreZero++;
            else if (num < 0) lessZero++;
            Console.WriteLine("Счетчик увеличился. Для выхода введите 0!");
            
        } while (num != 0);

        if (moreZero == lessZero)
        {
            Console.WriteLine("Положительных и отрицательных одинакове количество");
        }
        else
        {
            if (moreZero > lessZero)
            {
                Console.WriteLine("Положительных чисел больше отрицательных");
            }
            else
            {
                Console.WriteLine("Отрицательных чисел больше положительных");
            }
        }

        Console.WriteLine("moreZero:{0} lessZero:{1} count: {2}", moreZero, lessZero, moreZero + lessZero);
        Console.ReadKey();
    }
}