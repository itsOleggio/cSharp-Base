namespace Lecture2;

class Program
{
    static void Main(string[] args)
    {
        // Созздание обобщенного метода в класс main, чтобы не запутаться
        // Что обобщенные методы могут работать только внетри обощенных классов
        // Но это не так 

        print<int>(3);
        print<string>("Hello");
        Console.ReadKey();
    }

    static void print<T>(T value)
    {
        Console.WriteLine(value);
    }
}