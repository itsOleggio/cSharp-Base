using System.Threading;

namespace Lectures;

class Program
{
    static void Print1()
    {
        while (true)
        {
            Console.WriteLine("Primary");
        }
    }

    static void Print2()
    {
        while (true)
        {
            Console.WriteLine(new string(' ', 20) + "Secondary");
        }
    }

    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(Print2);
        Thread thread = new Thread(threadStart);
        thread.Start();
        Print1();
    }
}