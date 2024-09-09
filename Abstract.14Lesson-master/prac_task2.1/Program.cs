namespace prac_task2._2;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("Мурка");
        cat.ShowInfo();

        Console.WriteLine();

        Dog dog = new Dog("Янтарный", "Масик");
        dog.ShowInfo();
        dog.ShowColor();
    }
}