namespace prac_task2._2;

public class Cat : Animal
{
    const string type = "Cat";
    string name;
    string sound = "Мур мур";

    public override string Name
    {
        get => name;
        set => name = value;
    }

    public Cat(string name) : base(name)
    {
        this.name = name;
        // this.sound = sound;
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