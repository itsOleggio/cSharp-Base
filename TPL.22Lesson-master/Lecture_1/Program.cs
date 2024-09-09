using System.Threading;

namespace Lecture_1;

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

    static void Method2(Task task, object a)
    {
        int n = (int)a;
        Console.WriteLine("Method2 начал работу");

        for (int i = 0; i < n + 10; i++)
        {
            Console.WriteLine($"Method2 выводит счетчик i =  + {i}");
            Thread.Sleep(1000);
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

    static int Method4(int n)
    {
        int S = 0;
        Console.WriteLine("Method4 начал работу");
        for (int i = 0; i < 10; i++)
        {
            S += n;
            Thread.Sleep(1000);
        }

        Console.WriteLine("Method4 завершил работу");
        return S;
    }


    static void Main(string[] args)
    {
        //Action action = new Action(Method1); // Метод1 ничиго не принимает, используем необобщенный task
        // Task task1 = new Task(action1); // Создаем экземпляр класса Task
        // task1.Start(); // Запуск на исполнение

        //Task task = new Task(new Action(Method1)); // Техника предположения делегата 


        // // анонимный метод
        // Task task = new Task(delegate() { Console.WriteLine("Анонимный метод"); });
        //
        // // Анонимный метод с лямбда выражением 
        // Task task1 = new Task(()=>  Console.WriteLine("Анонимный метод")); 

        // Создание горячей задачи
        //Task task = Task.Factory.StartNew(Method1);

        // Создание горячей задачи(2 способ)
        //Task task = Task.Run(Method1);

        
        // Action<object> action = new Action<object>(Method2);
        // Task task = new Task(action, 100);
        
        // Task task = new Task(()=> Method2(200));
        //
        // Func<int> func = new Func<int>(Method3); // Без входа, с одним выходным
        // Task<int> task1 = new Task<int>(func);
        // task1.Start();
        //
        // Method1(); // Синхронный метод
        // // Console.WriteLine(task1.Result);
        // task1.Wait();
        // task.Wait();
        
        Action action = new Action(Method1);
        Task task = new Task(action);
        
        Action<Task, object> action1 = new Action<Task, object>(Method2);
        Task task2 = task.ContinueWith(action1, 100);
        
        task.Start();

    }
}