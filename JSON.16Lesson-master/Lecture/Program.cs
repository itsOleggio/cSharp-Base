using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace jsonProject;

using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string jsonString =
            "{\"firstName\":\"Tom\", \"lastName\":\"Jackson\", \"gender\":\"male\",\"age\":29, \"online\":true, \"hobby\":[\"Football\", \"reading\", \"swimming\"] }";
        // / - C# поймет, что "" часть строоки(процесс экроанирования)

        Person person = JsonSerializer.Deserialize<Person>(jsonString);

        Console.WriteLine(person.FirstName);
        Console.ReadKey();
        /*
         * <Person> - универсальный тип параметр
         * Тот тип, который будет указан в угловых скобках и вернутся
         * как результат, метода Deserialize
         */

        // Обратное преобразование
        Person person1 = new Person()
        {
            FirstName = "Вася",
            LastName = "Витос",
            Gender = "Муж",
            Age = 29,
            Online = true,
            Hobby = new string[] { "Рыбалка", "Кости" }
        };

        // Задаем опции, чтобы строка выводить нормально на русском языке 
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        };

        string jsonString1 = JsonSerializer.Serialize(person1, options);
        Console.WriteLine(jsonString1);
        Console.ReadKey();
    }

    class Person
    {
        [JsonPropertyName("firstName")]
        // Автосвойсва 
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")] public string LastName { get; set; }
        [JsonPropertyName("gender")] public string Gender { get; set; }
        [JsonPropertyName("age")] public int Age { get; set; }
        [JsonPropertyName("online")] public bool Online { get; set; }

        [JsonPropertyName("hobby")] // Сохранение оригинального названия свойств
        [JsonIgnore] // Отключаем автосвойсва hobby
        public string[] Hobby { get; set; }
    }
}