namespace prac_task2._2;

public abstract class Animal
{
    // Автосвойство 
    public abstract string Name { get; set; }

    // Конструктор
    public Animal(String name)
    {
        Name = name;
    }


    // Абстрактный метод Say
    public abstract void Say();

    public abstract void GetType();

    public void ShowInfo()
    {
        GetType();
        Console.WriteLine("Кличка: {0}", Name);
        Say();
    }
}