namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string str2 = "";

        foreach (char c in str)
        {
            str2 = c + str2;
        }

        Console.WriteLine(str2);
    }
}