namespace task6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[N, N];
        int finalSum = 0;
        bool magicSquareСheck = true;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("[" + i + "," + j + "]:");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
        }

        // Сумма для проверки (вычисляем строку) 
        for (int j = 0; j < N; j++)
        {
            finalSum += array[0, j];
        }

        // Проверка для строк 
        for (int i = 0; i < N; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < N; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum != finalSum)
                magicSquareСheck = false;
        }

        // Проверка для столбиков 
        for (int j = 0; j < N; j++)
        {
            int colSum = 0;
            for (int i = 0; i < N; i++)
            {
                colSum += array[i, j];
            }

            if (colSum != finalSum)
                magicSquareСheck = false;
        }

        // Проверка для главной диагонали 

        int diagonalSum = 0;
        for (int i = 0; i < N; i++)
        {
            diagonalSum += array[i, i];
        }

        if (diagonalSum != finalSum)
            magicSquareСheck = false;

        // Проверка для побочной диагонали 

        diagonalSum = 0;
        for (int i = 0; i < N; i++)
        {
            diagonalSum += array[i, N - i - 1];
        }

        if (diagonalSum != finalSum)
            magicSquareСheck = false;

        Console.WriteLine("Итоговый массив: ");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Ответ: ");
        if (magicSquareСheck == true)
        {
            Console.Write("Матрица явялется магическим квадратом!");
        }
        else
        {
            Console.Write("Матрица НЕ вялется магическим квадратом!");
        }

        Console.ReadKey();
    }
}

/*
 * Для проверки значений
 * 2 7 6
 * 9 5 1
 * 4 3 8
 */