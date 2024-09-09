namespace task3;

class Program
{
    static void Main(string[] args)
    {
        const int N = 10;
        int[] array = new int[N];

        Random random = new Random();

        Console.Write("Исходный массив:");
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(-50, 51);
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

        Console.Write("Сортированный массив: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        
        Console.WriteLine();
        
        Console.Write("Итоговый массив: ");
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        for (int j = N - 1; j >= N / 2; j--)
        {
            Console.Write("{0} ", array[j]);
        }
        
        Console.ReadKey();
    }
}