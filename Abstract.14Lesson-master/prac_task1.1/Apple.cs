namespace prac_task1._1;

public class Apple : Fruit
{
     string country;
     string taste;
     string name;

    public override string Name
    {
        get => name;
        set => name = value;
    }

    
    //Если родительсмкий класс имеет конструктор с параметром и иы создаем констуктор без параметра, то при создании дочернего надо вызвать родительский онстуктор 
    public Apple(string name, string taste, string country) : base(name)
    {
        this.country = country;
        this.taste = taste;
    }
    public override void GetTaste()
    {
        Console.WriteLine(taste);
    }
}