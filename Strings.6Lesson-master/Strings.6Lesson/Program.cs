namespace Strings._6Lesson;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] srtArray = str.Split();
        string min = srtArray[0];
        
        foreach (string s in srtArray)
        {
            if (s.Length < min.Length) 
            {
                min = s;
            }
        }

        Console.WriteLine(min);
        Console.ReadKey();
    }
}