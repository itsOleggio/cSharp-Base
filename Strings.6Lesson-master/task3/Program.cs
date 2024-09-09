using System.Text;

namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Удаляется текст в {ТУТ}");
        Console.Write("Введите текст: ");
        string str = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        int bracketDepth = 0;

        /*
            1. Сначала исходное значение bracketDepth равно 0
            2. Первый символ в строке - БУКВА. Так как это не скобка, он добавляется к результату
            3. Следующий символ - {. bracketDepth увеличивается до 1
            4. Следующий символ - ЕЩЕ ОДНА БУКВА. Так как bracketDepth не равно 0, этот символ игнорируется.
            5. И так далее, пока не дойдем до закрывающей скобки }. В этот момент bracketDepth уменьшается до 0, и следующие символы начинают добавляться к результату.
            6. Так продолжается до конца строки.
         */
        
        foreach (char c in str)
        {
            if (c == '{')
            {
                bracketDepth++;
            }
            else if (c == '}')
            {
                bracketDepth--;
            }
            else
            {
                if (bracketDepth == 0)
                {
                    result.Append(c);
                }
            }
        }

        Console.WriteLine("Результат");
        Console.Write(result.ToString());
    }
}