namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        Clock clock;
        do
        {
            Console.Write("Введите часы: ");
            int hour_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int minute_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int second_ = Convert.ToInt32(Console.ReadLine());

            clock = new Clock(hour_, minute_, second_);
        } while (clock.isCorrect == false);

        
        // #region Clock // Работает только когда нет пользовательского констуктора с аргументами
        //
        // // Clock clock = new Clock()
        // // {
        // //     hour = hour_,
        // //     minute = minute_,
        // //     second = second_
        // // };
        //
        // // clock.hour = Convert.ToInt32(Console.ReadLine());
        // // clock.minute = Convert.ToInt32(Console.ReadLine());
        // // clock.second = Convert.ToInt32(Console.ReadLine());
        // #endregion
        
        int total = clock.ToSecond(clock.Hour, clock.Minute, clock.Second);

        Console.WriteLine("Общее время в секундах: " + total);
        Console.ReadKey();
    }
}