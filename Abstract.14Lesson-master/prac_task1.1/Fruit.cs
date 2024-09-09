namespace prac_task1._1;

public abstract class Fruit
{
    // То что, общее между яблоком и лимоном 
    // Тут можно задавать частичеую реализацию
    public abstract string Name { get; set; } // Свойство без реалищзации 

    // Конструктор Fruit
    public Fruit(String name)
    {
        Name = name;
    }

    // Абстраный метод, который выводит вкус фругта 
    public abstract void GetTaste(); // Тело метода, будет в дочерних классах

    public void ShowInfo()
    {
        Console.WriteLine("Name: {0}", Name);
        GetTaste(); 
    }
}

