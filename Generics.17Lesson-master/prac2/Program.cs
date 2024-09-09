namespace prac2;

class Program
{
    static void Main(string[] args)
    {
        Bill<int> bill1 = new Bill<int>();
        Bill<string> bill2 = new Bill<string>();

        bill1.SetInfo();
        bill2.SetInfo();
        Console.WriteLine(bill1.GetInfo());
        Console.WriteLine(bill2.GetInfo());
    }
}