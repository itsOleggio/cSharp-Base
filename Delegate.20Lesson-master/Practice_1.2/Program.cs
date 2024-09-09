namespace Practice_1._2;

class Program
{
    delegate int MyDelegate(int a, int b);

    static void Main(string[] args)
    {
        MyDelegate myDelegate = PowerAB;
        myDelegate += PowerBA;
        int result = myDelegate(2, 3);
        Console.WriteLine(result);

        Console.ReadKey();
    }

    static int PowerAB(int a, int b)
    {
        int r = (int)Math.Round(Math.Pow(a, b));
        Console.WriteLine(r);
        return r;
    }


    static int PowerBA(int a, int b)
    {
        int r = (int)Math.Round(Math.Pow(b, b));
        Console.WriteLine(r);
        return r;
    }
}