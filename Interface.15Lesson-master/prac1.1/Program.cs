namespace Interface._15Lesson;

class Program
{
    static void Main(string[] args)
    {
        AChiper aChiper = new AChiper();
        Console.WriteLine(aChiper.Encoder("ABC123XYZ"));
        Console.WriteLine(aChiper.Decoder("BCD123YZA"));
        
        BChiper bChiper = new BChiper();
        Console.WriteLine(bChiper.Encoder("ABC123XYZ"));
        Console.WriteLine(bChiper.Decoder("AYX123CBA"));
        
        Console.ReadKey();
    }
}