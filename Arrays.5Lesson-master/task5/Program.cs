namespace task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[N, N];

        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                array[i, j] = ((i + j) % 2 == 0) ? 1 : 0;
                Console.Write("{0} ", array[i, j]);
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}