namespace prac_task2._1;

class Program
{
    static void Main(string[] args)
    {
        Building building = new Building("Ул. Мира 1", 5, 3, 2);
        Console.WriteLine(building.PrintInfo());

        MultiBuilding multiBuilding = new MultiBuilding("", 5, 3, 2, 2);
        Console.WriteLine(multiBuilding.PrintInfo());

        Building building1 = new Building("Ул. Мира 3", 5, 3, 0);
        Console.WriteLine(building1.PrintInfo());

        MultiBuilding multiBuilding1 = new MultiBuilding("Ул. Мира 2", 5, 3, 2, 0);
        Console.WriteLine(multiBuilding1.PrintInfo());

        string Addres = Console.ReadLine();
        double length = Convert.ToDouble(Console.ReadLine());
        double width = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        Building building2 = new Building(Addres, length, width, height);
        Console.WriteLine(building2.PrintInfo());
    }
}