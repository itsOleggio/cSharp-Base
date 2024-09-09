namespace Practice_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Func<object, int[]> func1 = new Func<object, int[]>(setArray);
        Task<int[]> task1 = new Task<int[]>(func1, n);
        
        task1.ContinueWith(previousTask =>
        {
            int[] array = previousTask.Result;
            printInfo(array);
        });
        
        task1.Start();
        Console.ReadKey();

        // int[] array = setArray(n);
        // printInfo(array);
    }

    static int[] setArray(object a)
    {
        int n = (int)a;
        int[] array = new int[n];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(1, 100);
        }

        return array;
    }

    static int sumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    static int findMax(int[] array)
    {
        int tempMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > tempMax)
            {
                tempMax = array[i];
            }
        }

        return tempMax;
    }

    static void printInfo(int[] array)
    {
        Console.Write("Массив: ");
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
        Console.WriteLine("Сумма элементов массива: " + sumArray(array));
        Console.WriteLine("Максимальный элемент массива: " + findMax(array));
    }
}