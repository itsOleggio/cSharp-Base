using System.Threading.Channels;

namespace prac1._2;

public class Employee<T>
{
    public T Num { get; set; }
    public string Name { get; set; }
    public int Summa { get; set; }


    // Конструктор в этом случае не нужный 
    // public Employee(T num, string name, int summa)
    // {
    //     Num = num;
    //     Name = name;
    //     Summa = summa;
    // }

    public string GetInfo()
    {
        return $"Num: {Num}, Name: {Name}, Summa: {Summa}";
    }

    public void Input()
    {
        Console.Write("Введите номер сотрудника:");
        Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        Console.Write("Введите имя сотрудника:");
        Name = Console.ReadLine();
        Console.Write("Введите сумму заработка сотрудника:");
        Summa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
}