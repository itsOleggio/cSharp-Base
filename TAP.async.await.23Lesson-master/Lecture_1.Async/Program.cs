namespace Lecture_1.Async;

class Program
{
    static void Method1()
    {
        Console.WriteLine("Method1 начал работу");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Method1 выводит счетчик i =  + {i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Method1 завершил работу");
    }
    static void Method2(int a)
    {
        int n = (int)a;
        Console.WriteLine("Method2 начал работу");

        for (int i = 0; i < n + 10; i++)
        {
            Console.WriteLine($"Method2 выводит счетчик i =  + {i}");
            Thread.Sleep(100);
        }

        Console.WriteLine("Method2 завершил работу");
    }
    
    static int Method3()
    {
        Console.WriteLine("Method3 начал работу");
        int S = 0;
        for (int i = 0; i < 10; i++)
        {
            S += i;
            Thread.Sleep(1000);
        }

        Console.WriteLine("Method3 завершил работу");
        return S;
    }
    
    static void Main(string[] args)
    {
        Method4Async();
        int r = Method2Async().Result;
        Method2(100);
        Console.WriteLine("Main завершил работу");
    }

    static async Task  Method4Async()
    {
        Console.WriteLine("Method4Async начал работу");
        await Task.Run(() => Method1());
        Console.WriteLine("Method4Async завершил работу");
    }
    
    static async Task<int> Method2Async()
    {
        Console.WriteLine("Method4Async начал работу");
        int result = await Task.Run(() => Method3());
        Console.WriteLine("Method4Async завершил работу");
        return result;
    }
}