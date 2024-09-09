namespace Practice_2;

class Program
{
    delegate double MyDelegate(double R);

    static void Main(string[] args)
    {
        Console.Write("Введтие: ");
        double R = Convert.ToDouble(Console.ReadLine());
        MyDelegate myDelegate;
        myDelegate = Length;
        double result = myDelegate(R);
        ShowResult(result);
        myDelegate += Area;
        result = myDelegate(R);
        ShowResult(result);
        myDelegate += Volume;
        result = myDelegate(R);
        ShowResult(result);
    }

    static double Length(double R) => Math.Round(2 * Math.PI * R, 3);
    static double Area(double R) => Math.Round(Math.PI * Math.Pow(R, 2), 3);
    static double Volume(double R) => Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(R, 3), 3);
    static void ShowResult(double R) => Console.WriteLine(R);
}