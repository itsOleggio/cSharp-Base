namespace Arrays._5Lesson;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        int count = 0;
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

            if (array[i] % 2 == 0)
            {
                sum += array[i];
                count++;
            }
        }

        Console.WriteLine("Результат: {0}", ((double)sum) / count);
        Console.ReadKey();
    }
}