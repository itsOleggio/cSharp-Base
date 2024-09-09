namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double L = Convert.ToDouble(Console.ReadLine());
            double R = L / (2 * Math.PI);
            Console.WriteLine(R);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}