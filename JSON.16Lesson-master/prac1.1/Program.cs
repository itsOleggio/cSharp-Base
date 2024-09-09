using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json;

namespace prac1;



class Program
{
    static void Main(string[] args)
    {
        const int employeeCount = 5;
        // Создание массива данных
        Employee[] employees = new Employee[employeeCount];

        for (int i = 0; i < employeeCount; i++)
        {
            // Счет данных 
            Console.Write("Введите номер: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите зп: ");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Объявление класса 
            employees[i] = new Employee() // На каждом шаге это новый экземпляр класс Employee
            {
                Num = num,
                Name = name,
                Summa = sum
            };

            // Исправление ошибок для вывода кирилицы в файл
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
            };

            // Массив превращаем в строку 
            string jsonString = JsonSerializer.Serialize(employees, options); // Сериализация массива в строку

            // Запись в файл
            using (StreamWriter sw = new StreamWriter("../../../../employees.json"))
            {
                sw.Write(jsonString);
            }
            
        }
    }
}