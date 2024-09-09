using System.Globalization;

namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        Man man = new Man("Igor", 2030, "Moscow");
        string info = man.PrintInfo();
        Console.WriteLine(info);

        Student student = new Student("Oleg", 2001, "Saint-Petersburg", "ITMO");
        string info1 = student.PrintInfo();
        Console.WriteLine(info1);
    }
}