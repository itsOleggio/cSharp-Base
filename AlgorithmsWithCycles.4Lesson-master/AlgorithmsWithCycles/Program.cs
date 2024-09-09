namespace AlgorithmsWithCycles;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите N:");
        int N = Convert.ToInt16(Console.ReadLine());
        int Sum = 0;
        
        for (int i = 0; i <= N; i++) // Включая N, счетчик учавствует в вычислении слагаемого  
        {
            Sum += 2 * i; 
        }
        Console.WriteLine("Сумма: {0}", Sum);
        Console.ReadKey();
    }
}