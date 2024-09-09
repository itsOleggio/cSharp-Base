namespace TAP.async.await._23Lesson;

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

    static void Main(string[] args)
    {
        // // Основной способ через создание Action 
        // Action action = new Action(Method1);
        // Task task1 = new Task(action);
        // task1.Start();
        //
        // // Техника предположения делегатов. Сразу указать в качестве аргумента конструктора task 
        // Task task2 = new Task(Method1);
        //
        // // Запись анонимного метдл 
        // Task task3 = new Task(delegate {Method1();});//Вызываем метод на исполнение 
        //
        // // Лямбда выражение 
        // Task task4 = new Task(() => Method1());
        //
        // // Создание горячих задач 
        // // Через статический метод Task.Factory.StartNew(В качестве аргумента передается, делегат, анонимный метод или лямбда выражение) 
        //
        // Task task5 = Task.Factory.StartNew(action);
        //
        // Вызов метода статического метода Run 
        Task task6 = Task.Run(() => Method1());
        task6.Wait();
        Task task7 = Task.Run(() => Method2(100));
        task7.Wait();
        
        Console.WriteLine("Метод Main завершил работу");
        Console.ReadKey();
    }


}