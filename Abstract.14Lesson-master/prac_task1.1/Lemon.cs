namespace prac_task1._1;

public class Lemon : Fruit
{
    private int variety; // Так отображается сорт 
    private string name;

    public override string Name
    {
        get => name;
        set => name = value;
    }

    //Если родительсмкий класс имеет конструктор с параметром и иы создаем констуктор без параметра, то при создании дочернего надо вызвать родительский онстуктор 
    public Lemon(string name, int variety) : base(name)
    {
        this.variety = variety;
    }

    public override void GetTaste()
    {
        Console.WriteLine("Кислый");
    }
}