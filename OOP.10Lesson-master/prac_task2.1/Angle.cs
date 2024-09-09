namespace prac_task2._1;

public class Angle
{
    private int gradus; //градусов
    private int min; //угловых минут
    private int sec; //угловых секунд

    public int Gradus
    {
        get { return gradus; }
        set
        {
            if (value >= 0 && value <= 360)
            {
                gradus = value;
            }
            else
            {
                Console.WriteLine("Недопустимый градус");
            }
        }
    }

    public int Min
    {
        get
        {
            return min;
        }
        set
        {
            if (value >= 0 && value <= 60)
            {
                min = value;
            }
            else
            {
                Console.WriteLine("Недопустимый минут");
            }
        }
    }

    public int Sec
    {
        get
        {
            return sec;
        }
        set
        {
            if (value >= 0 && value <= 60)
            {
                sec = value;
            }
            else
            {
                Console.WriteLine("Недопустимый секунда");
            }
        }
    }

    // Конструктор класса 
    public Angle(int gradus, int min, int sec)
    {
        Gradus = gradus;
        Min = min;
        Sec = sec;
    }
    
    // Методы преобразования градусов в радианы 
    public double ToRadians(int gradus, int min, int sec)
    {
        double finalGradus = gradus + min / 60.0 + sec / 3600.0;
        return (finalGradus * Math.PI) / 180;
    }
}