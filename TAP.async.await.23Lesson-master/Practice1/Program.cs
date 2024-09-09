namespace Practice1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("До скольки считать сумму:");
        int n = Convert.ToInt32(Console.ReadLine());
        SumAsync(n);
        Console.ReadKey();
    }

    // Сделаем метод длительным, чтобы был смысл использовать асинхронные операции
    static void Sum(int n)
    {
        int s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += i;
            Thread.Sleep(10);
        }

        Console.WriteLine(s);
    }

    // Создадим метод, который будет вызывать метод асинхронно
    static async void SumAsync(int n)
    {
        await Task.Run(() => Sum(n)); // Создание горячий задачи
    }
}