using System.Threading;

namespace Practice_1;

class Program
{
    private const int n = 10;
    private static int[] path = new int[n] { 1, 2, 0, 50, 4, 0, 1, 2, 6, 7 };

    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(Gardner1); // Создаем скафанлер и помещаем в него челоека 
        Thread thread = new Thread(threadStart); // Помещаем в ракету 
        thread.Start(); // Запускаем ракету 
        Gardner2();

        for (int i = 0; i < n; i++)
        {
            Console.Write(" {0}", path[i]);
        }

        Console.ReadKey();
    }

    static void Gardner1()
    {
        for (int i = 0; i < n; i++)
        {
            if (path[i] >= 0)
            {
                int delay = path[i];
                path[i] = -1;
                Thread.Sleep(delay);
            }
        }
    }
    static void Gardner2()
    {
        for (int i = n-1; i >= 0; i--)
        {
            if (path[i] >= 0)
            {
                int delay = path[i];
                path[i] = -2;
                Thread.Sleep(delay);
            }
        }
    }
}