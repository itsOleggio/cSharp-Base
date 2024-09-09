namespace prac_task2._1;

public class Building
{
    string address;
    private double length;
    private double width;
    private double height;

    string Address
    {
        get { return address; }
        set
        {
            if ((value != null) && (value != ""))

            {
                address = value;
            }
            else
            {
                Console.WriteLine("Address can't be null");
                address = "undefined";
            }
        }
    }

    double Length
    {
        get { return length; }
        set
        {
            if (value > 0)
            {
                length = value;
            }
            else
            {
                Console.WriteLine("Height can't be negative and below 0");
                length = 0;
            }
        }
    }

    double Width
    {
        get { return width; }
        set
        {
            if (value > 0)
            {
                width = value;
            }
            else
            {
                Console.WriteLine("Height can't be negative and below 0");
                width = 0;
            }
        }
    }

    double Height
    {
        get { return height; }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                Console.WriteLine("Height can't be negative and below 0");
                height = 0;
            }
        }
    }

    public Building(string address, double length, double width, double height)
    {
        Address = address;
        Length = length;
        Width = width;
        Height = height;
    }

    public string PrintInfo()
    {
        return $"Address: {Address}, Length: {Length}, Width: {Width}, Height: {Height}";
    }
}