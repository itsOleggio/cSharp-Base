namespace Lecture_Dictionart;

class Program
{
    static void Main(string[] args)
    {
        // Объявление словаря 
        Dictionary<string, int> mouth = new Dictionary<string, int>();
        mouth.Add("Jan", 31);
        mouth.Add("Feb", 28);
        mouth.Add("Mar", 30);
        mouth.Add("Apr", 31);
        mouth.Add("May", 30);
        mouth.Add("Jun", 31);
        mouth.Add("Jul", 31);
        mouth.Add("Aug", 30);
        mouth.Add("Sep", 31);
        mouth.Add("Nov", 30);
        mouth.Add("Dec", 31);
        Console.WriteLine(mouth["May"]);
    }
}