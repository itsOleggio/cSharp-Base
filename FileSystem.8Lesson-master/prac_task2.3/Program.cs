namespace prac_task2._3;

class Program
{
    static void Main(string[] args)
    {
        string path = @"text.txt"; // path to the text file
        
        int count_of_symbols = 0;
        int count_of_words = 0;
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            count_of_symbols += line.Length;
            count_of_words += line.Split(' ').Length;
        }
        
        Console.WriteLine("Количество символов: {0}", count_of_symbols);
        Console.WriteLine("Количество слов: {0}", count_of_words);
    }
}