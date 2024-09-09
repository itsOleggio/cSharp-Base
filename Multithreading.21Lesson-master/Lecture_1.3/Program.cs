using System.Threading;
using Microsoft.VisualBasic;

namespace Lecture_1._3;

class Program
{
    static int x = 0; // Располагаются в области типа, общие лоя всего класса
    static object locker = new object(); // Объект заглушка 

    public static void Print()
    {
        lock (locker) // Захватываем заглушку
        {
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}: {1} ", Thread.CurrentThread.Name, x);
                x++;
                Thread.Sleep(100); // Квант времени
            }
        }
    }

    /*
     Thread - название классса
     CurrentThread - статическое поле, которое возвращаем выполняющийся поток
     Name - имя потока
     */

    static void Main(string[] args)
    {
        // Создание 5 потоков 
        for (int i = 0; i < 5; i++)
        {
            ThreadStart threadStart = new ThreadStart(Print);
            Thread thread = new Thread(threadStart);
            thread.Name = "Поток " + i.ToString();
            thread.Start();
        }
    }
}