namespace Practice2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число для факториала: ");
        int n = Convert.ToInt32(Console.ReadLine());
        FactorialAsync(n);
        Console.ReadKey();
    }

    static void Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
            Thread.Sleep(100);
        }
        Console.WriteLine("Факториада числа " + n + " равен " + fact);
    }

    static async void FactorialAsync(int n)
    {
        await Task.Run(() => Factorial(n));
    }
}