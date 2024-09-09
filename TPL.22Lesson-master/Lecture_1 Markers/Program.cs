using System.Threading.Channels;

namespace Lecture_1_Markers;

class Program
{
    /*
     * CancellationToken token - объект, с помощью которого можно передать сообютение программе 
     */
    static void Method(CancellationToken token) // Метод в контексте задачи, который в цикле выводит значение счеткччика
    {
        Console.WriteLine("Метод начал работу");
        for (int i = 0; i < 100; i++)
        {
            if (((CancellationToken)token).IsCancellationRequested) // Проверякм значение токена 
            {
                Console.WriteLine("Операция прервана");
                return;
            }

            Console.WriteLine($"Метод 1 выводит счетчик {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Метод завершил работу");
    }

    static void Main(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); // Источнике маротвены
        CancellationToken token = cancellationTokenSource.Token; // оздаем сам маркер 

        Task task = new Task(() => Method(token));
        task.Start();

        Console.WriteLine("Введите Y для отмены операции или другой символ для ее продолжения");
        string input = Console.ReadLine();
        if (input == "Y")
            cancellationTokenSource.Cancel();

        Console.ReadKey();
    }
}