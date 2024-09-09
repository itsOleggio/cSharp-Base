namespace prac1._2;

class Program
{
    static void Main(string[] args)
    {
        // В этом примере все методы сбора, вывода и обработки указаны в классе 

        // Для чисел
        Employee<int> employee1 = new Employee<int>();
        employee1.Input();

        // Для строк
        Employee<string> employee2 = new Employee<string>();
        employee2.Input();

        Console.WriteLine(employee1.GetInfo());
        Console.WriteLine(employee2.GetInfo());
    }
}