namespace Lecture_2;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Пример того, как работают методы расширения
         */

        int a = 10;
        int b = 20;
        int c = a.Add(b);
        Console.WriteLine(c);
        Console.ReadKey();
    }
}

static class IntExtensions
{
    public static int Add(this int new_a, int new_b)
    {
        return new_a + new_b;
    }
}