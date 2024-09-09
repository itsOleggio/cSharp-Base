namespace task1;

class Program
{
    static void Main(string[] args)
    {
        const int N = 7;
        int[] array = new int[N];
        double avg = 0;

        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите array[" + i + "]: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Итоговый массив:");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", array[i]);
            avg += array[i];
        }
        Console.WriteLine();
        Console.WriteLine("AVG: {0}", Math.Round(avg / N, 2));
        Console.ReadKey();
    }
}