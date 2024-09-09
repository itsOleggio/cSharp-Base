namespace prec_task1._1;

class Program
{
    static void Main(string[] args)
    {
        string path = @"E:\Temp";
        string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        Console.ReadKey();
    }
}