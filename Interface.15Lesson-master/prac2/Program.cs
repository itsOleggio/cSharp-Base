namespace prac2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер первого члена a1(Арифметическая прогрессия): ");
        int startAS = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите разность прогрессии d(Арифметическая прогрессия): ");
        int difAS = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер последнего члена n(Арифметическая прогрессия): ");
        int lastNumArithSeries = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        
        Console.Write("Введите номер первого члена a1(Геометрическая прогрессия): ");
        int startGS = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите разность прогрессии d(Геометрическая прогрессия): ");
        int difGS = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер последнего члена n(Геометрическая прогрессия)");
        int lastNumGeomSeries = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        
        ArithProgression arithSeries = new ArithProgression();
        arithSeries.SetStart(startAS); // Метод устанавливает начальное значение
        arithSeries.SetCommonDifference(difAS); // Метод устанавливает разницу 

        GeomProgression geomSeries = new GeomProgression();
        geomSeries.SetStart(startGS);
        geomSeries.SetCommonRatio(difGS);

        // Подсчет арифметической прогрессии
        Console.WriteLine("Арифметическая прогрессия:");
        for (int i = 0; i < lastNumArithSeries; i++)
        {
            //Console.WriteLine(arithSeries.GetNext());
            Console.WriteLine("a{0}: {1}", i + 1, arithSeries.GetNext());
        }

        for (int i = 0; i < lastNumArithSeries; i++)
        {
            arithSeries.Reset(); // Обратный подсчет начального значения
        }

        Console.WriteLine("Начальное значение: " + arithSeries.GetNext());


        Console.WriteLine("Геометрическая прогрессия:");
        for (int i = 0; i < lastNumGeomSeries; i++)
        {
            Console.WriteLine("a{0}: {1}", i + 1, geomSeries.GetNext());
        }

        for (int i = 0; i < lastNumGeomSeries; i++)
        {
            geomSeries.Reset();
        }

        Console.WriteLine("Начальное значение: " + geomSeries.GetNext());
        Console.ReadKey();
    }
}