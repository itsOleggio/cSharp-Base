namespace task2._2;

class Program
{
    static void Main(string[] args)
    {
        const int N = 15;
        int[] array = new int[N];

        Random random = new Random();

        Console.Write("Исходный массив:");
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(0, 51);
            Console.Write("{0} ", array[i]);
        }


        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        Console.WriteLine();
        Console.Write("Сортированный массив:");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Max: {0}, Min: {1}, Sum(Max, Min): {2}", array[N - 1], array[0], array[0] + array[N - 1]);
        Console.ReadKey();
    }
}