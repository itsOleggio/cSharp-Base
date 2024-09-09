namespace prac_task2._2;

public class Dog : Animal
{
    const string type = "Dog";
    string color;
    string name;
    string sound = "Гаф";

    public override string Name
    {
        get => name;
        set => name = value;
    }


    public Dog(string color, string name) : base(name)
    {
        this.color = color;
        this.name = name;
    }

    public void ShowColor()
    {
        Console.WriteLine("Цвет: {0}", color);
    }

    public override void Say()
    {
        Console.WriteLine(sound);
    }

    public override void GetType()
    {
        Console.WriteLine("Type: {0}", type);
    }
}