namespace Practice_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Func<object, int[]> func1 = new Func<object, int[]>(getArray);
        Task<int[]> task1 = new Task<int[]>(func1, n);
        
        
        // Создаем делигат, параметризированным предыдущей задачей. Из которой возьмем результат.
        Func<Task<int[]>, int[]> func2 = new Func<Task<int[]>, int[]>(sortArray);  // 1 арг - пред. задача, 2 арг - тип возращаемого значения
        Task<int[]> task2 = task1.ContinueWith<int[]>(sortArray); //ContinueWith параметризированным результатом 
        int[] arr = getArray(n);
        
        // В печать передаем задачу, которая отсортирует массив 
        Action<Task<int[]>> action = new Action<Task<int[]>>(printArray);
        Task task3 = task2.ContinueWith(action); // Передаем пред. задачу 
        
        task1.Start();
        Console.ReadKey(); 
    }

    static int[] getArray(object a)
    {
        int n = (int)a;
        int[] arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = rnd.Next(0, 100);
        }
        return arr;
    }

    static int[] sortArray(Task<int[]> task) // В аргумент передаем задачу, которая была 
    {
        int[] arr = task.Result;
        for (int i = 0; i < arr.Count() - 1; i++) 
        {
            for (int j = i + 1; j < arr.Count(); j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }

    static void printArray(Task<int[]> task) // Передаем пред задачи 
    {
        int[] arr = task.Result;
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}