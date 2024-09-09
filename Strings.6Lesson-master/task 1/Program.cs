namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string str = Console.ReadLine();
        string[] srtArray = str.Split();

        int maxLength = 0;

        string max = "";

        foreach (string s in srtArray)
        {
            if (s.Length > max.Length)
            {
                max = s;
            }
        }

        Console.WriteLine("Слово максимальной длины:");
        Console.WriteLine(max);
        Console.WriteLine("Нажми ENTER чтобы посмотреть еще слова такой же длины");
        Console.ReadKey();
        // Реализовация, если слов несколько 

        int count = 0;
        
        foreach (string s in srtArray)
        {
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
                count++;
            }
        }

        Console.Write("Слова максимальной длины: ");

        if (count == 1)
        {
            Console.Write("Это было единственное слово");
        }
        else
        {
            foreach (string s in srtArray)
            {
                if (s.Length == maxLength)
                {
                    Console.Write("{0}, ", s);
                }
            }
        }


        Console.ReadKey();
    }
}