using System.Threading;

namespace Lecture_1._2;

class Program
{
    static void Print1(object name)
    {
        while (true)
        {
            Console.WriteLine((string)name);
        }
    }

    static void Print2(object name)
    {
        while (true)
        {
            Console.WriteLine(new string(' ', 20) + (string)name);
        }
    }

    static void Main(string[] args)
    {
        ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Print2);
        Thread thread = new Thread(threadStart);
        thread.Start("String");
        Print1("String 1");
    }
}