namespace task4;

class Program
{
    static void Main(string[] args)
    {
        const int N = 20;
        const int M = 20;
        int[] array = new int[N];
        int[] result_array = new int[M];
        int count = 0;

        Random random = new Random();

        Console.Write("Исходный массив:");
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(-50, 51);
            Console.Write("{0} ", array[i]);

            if ((i % 2 == 1) && array[i] > 0 && array[i] % 2 == 1)
            {
                count++;
                result_array[i] = array[i];
            }
        }

        Console.WriteLine();
        Console.Write("Ответ: {0}", count);
        Console.WriteLine();

        // Для проверки 
        
        Console.Write("Сами числа: ");
        for (int i = 0; i < result_array.Length; i++)
        {
            Console.Write("{0} ", result_array[i]);
        }
        
        Console.ReadKey();
        
        
    }
}