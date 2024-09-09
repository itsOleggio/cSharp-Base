namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
        
        //Создаем экземпляр стуктуры 
        Quadro quad = new Quadro(a,b,c);
        Console.WriteLine(quad.Root());
    }
}