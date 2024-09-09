using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace prac2._1;

class Program
{
    static void Main(string[] args)
    {
        const int count = 5;

        Product[] products = new Product[count];

        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            int id = GenerateUniqueId(rand, products);

            Console.WriteLine("Введите название товара:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            int price = Convert.ToInt32(Console.ReadLine());
            products[i] = new Product()
            {
                Product_id = id,
                Product_name = name,
                Product_price = price
            };
        }
        
        // Исправление ошибок для вывода кирилицы в файл
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
        };
        
        string json = JsonSerializer.Serialize(products, options);

        using (StreamWriter sw = new StreamWriter("../../../../Products.json"))
        {
            sw.Write(json);
        }

    }
    
    static int GenerateUniqueId(Random rand, Product[] products)
    {
        int id;
        bool idExists;

        do
        {
            idExists = false;
            id = rand.Next(100001, 999999); // Генерация случайного ID

            // Проверка на наличие ID среди уже созданных товаров
            foreach (Product product in products)
            {
                // Проверка, не является ли текущий элемент массива null
                if (product != null && product.Product_id == id)
                {
                    idExists = true;
                    break;
                }
            }
        } while (idExists); // Повторяем, пока не найдем уникальный ID

        return id;
    }
    
    
}