namespace prac_task2._2;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string path = @"nums.txt";

        using (StreamWriter sw = new StreamWriter(path, false))
        {
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine(random.Next(-10, 11));
            }
        }

        int sum = 0;
        using (StreamReader sr = new StreamReader(path))
        {
            for (int i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(sr.ReadLine());
            }
        }

        Console.WriteLine($"Сумма равна: {sum}");
        Console.ReadKey();
    }
}