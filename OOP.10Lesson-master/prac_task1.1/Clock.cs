namespace prac_task1._1;

public class Clock
{
    //Поля
    int hour;
    int minute;
    int second;
    public bool isCorrect = true;

    // Тренировочная версия 
    // #region test1
    // public int Hour
    // {
    //     get { return hour; }
    //     set
    //     {
    //         if (value < 0 ) //value - это значение поля, которые пытаются установить 
    //         {
    //             //Console.WriteLine("Неверное значение"); // На практике так не делают.
    //             // Свойства должно проверять корректность значения и проще сделать значение по умолчанию
    //             hour = 0;
    //         }
    //         else if (value > 23)
    //         {
    //             hour = 23;
    //         }
    //         else
    //         {
    //             hour = value;
    //         }
    //     }
    // }
    // #endregion

    //Свойства класса

    public int Hour
    {
        get { return hour; }
        set
        {
            if (value < 0)
            {
                isCorrect = false;
            }
            else
                hour = value % 24;
        } // % 24 означает, что значение будет от 0 до 23
    }

    public int Minute
    {
        get { return minute; }
        set
        {
            if (value < 0)
            {
                isCorrect = false;
            }
            else
            {
                Hour += value / 60;
                minute = value % 60;
            }
        }
    }

    public int Second
    {
        get { return second; }
        set
        {
            if (value < 0)
            {
                isCorrect = false;
            }
            else
            {
                Minute += value / 60;
                second = value % 60;
            }
        }
    }


    //конструктор класса
    public Clock(int hour, int minute, int second)
    {
        this.Hour = hour; // this указывает, что используются поля класса
        this.Minute = minute;
        this.Second = second;
    }

    //Поля класса Clock(Поля можно использовать, так как они находятся внутри класса)
    public int ToSecond(int h, int m, int s)
    {
        return h * 3600 + m * 60 + s;
    }
}