namespace Lecture_1._3;

class Program
{
    delegate int MyDelegate(int v1, int v2);

    delegate int MyDelegate2(int v1, int v2);
    delegate int MyDelegate3(int v1, int v2);
    delegate void MyDelegate4();
    
    static void Main(string[] args)
    {
        Action action = Method1;
        action();

        // Для метода с аргументом 
        Action<string> action1 = Method3;
        action1("Hello");

        // Совмещение определение переменной делегата с методом (анонимными)
        MyDelegate myDelegate = delegate(int v1, int v2)
        {
            Console.WriteLine("Method 5");
            return v1 + v2;
        };
        myDelegate(5, 10);

        // Сокращенная анонимная запись 
        MyDelegate myDelegate2 = (v1, v2) =>
        {
            Console.WriteLine("Method 5");
            return v1 + v2;
        };
        myDelegate2(5, 10);
        
        // Более сильное сокращение 
        MyDelegate myDelegate3 = (v1, v2) => v1 + v2;
        myDelegate3(5, 10);
        
        // Переменная типа void 
        MyDelegate4 myDelegate4 = () => Console.WriteLine("Method 6");
        myDelegate4();
        
    }

    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method3(string name)
    {
        Console.WriteLine("Method 3");
        Console.WriteLine(name);
    }

    static int Method5(int v1, int v2)
    {
        Console.WriteLine("Method 5");
        return v1 + v2;
    }
}