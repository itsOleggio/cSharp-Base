namespace Delegate._20Lesson;

class Program
{
    delegate void MyDelegate();
    delegate void MyDelegate2();

    static void Main(string[] args)
    {
        // Обычное присваивание 
        MyDelegate myDelegate = Method1;
        myDelegate();
        // Присваивание 2 ссылок
        MyDelegate2 myDelegate2 = Method1;
        myDelegate2 += Method2;
        myDelegate2();
        Console.ReadKey();
        
        // Удаление ссыки 
        myDelegate2 -= Method1;
        myDelegate2();
        Console.ReadKey();
    }

    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    static void Method3(string name)
    {
        Console.WriteLine("Method 3");
        Console.WriteLine(name);
    }
}