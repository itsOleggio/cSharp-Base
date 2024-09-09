namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string str = Console.ReadLine();
        str = str.ToLowerInvariant();
        string str2 = "";
        str = str.Replace(" ", "");

        foreach (char simb in str)
        {
            str2 = simb + str2;
        }

        if (str2 == str)
            Console.WriteLine("Предложение палиндром");
        else
            Console.WriteLine("Предложение НЕ палиндром");

        // Console.WriteLine(str);
        // Console.WriteLine(str2);
    }
}