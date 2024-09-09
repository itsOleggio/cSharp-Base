namespace prac1._1._1;

public class Employee <T>
{
    // Авотсвойства 
    public T Num {get; set;}
    public string Name { get; set; }
    public int Summa { get; set; }

    // Конструктор
    public Employee(T num, string name, int summa)
    {
        Num = num;
        Name = name;
        Summa = summa;
    }

    public string GetInfo()
    {
        return $"Num: {Num}, Name: {Name}, Summa: {Summa}";
    }
    
}