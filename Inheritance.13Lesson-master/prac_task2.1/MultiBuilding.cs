namespace prac_task2._1;

public class MultiBuilding : Building
{
    private int floor;

    int Floor
    {
        get { return floor; }
        set
        {
            if (value >= 0)
            {
                floor = value;
            }
            else
            {
                Console.WriteLine("Invalid Floor");
                floor = 0;
            }
        }
    }

    public MultiBuilding(string address, double length, double width, double height, int floor) : base(address, length,
        width, height)
    {
        Floor = floor;
    }

    public string PrintInfo()
    {
        string result = base.PrintInfo();
        result += " Floor: " + Floor;
        return result;
    }
}