namespace prac_task2._1;

class Program
{
    static void Main(string[] args)
    {
        string path = @"E:\Temp\1";
        string[] files = Directory.GetDirectories(path);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    }
}