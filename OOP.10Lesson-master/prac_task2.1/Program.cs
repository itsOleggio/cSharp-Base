namespace prac_task2._1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите градусы:");
        int gradus_ = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минуты(для градусов):");
        int min_ = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите секунды(для градусов):");
        int sec_ = Convert.ToInt32(Console.ReadLine());
        Angle angle = new Angle(gradus_, min_, sec_);

        double answerRadiam = angle.ToRadians(angle.Gradus, angle.Min, angle.Sec);

        Console.WriteLine("Радианы: " + Math.Round(answerRadiam, 5));
    }
}