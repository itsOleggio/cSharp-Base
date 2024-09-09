namespace ConsoleApp1._2;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string path = @"E:\Temp\numbers.txt";
        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(-10, 11));
            }
        }

        int k = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(sr.ReadLine()) > 0)
                {
                    k++;
                }
            }
        }

        Console.WriteLine(k);
        Console.ReadKey();
    }
}