using System.Text.Json;

namespace prac2._2;

class Program
{
    static void Main(string[] args)
    {
        string json = String.Empty;
        const int count = 5;
        Product[] products = new Product[count];
        
        using StreamReader sr = new StreamReader("../../../../Products.json");
        json = sr.ReadToEnd();


        Product[] product = JsonSerializer.Deserialize<Product[]>(json);
        
        Product MaxOriceProduct = product[0];

        foreach (Product p in product)
        {
            if (p.Product_price > MaxOriceProduct.Product_price)
            {
                MaxOriceProduct = p;
            }
        }

        Console.WriteLine("ID Product: {0}", MaxOriceProduct.Product_id);
        Console.WriteLine("Name: {0}", MaxOriceProduct.Product_name);
        Console.WriteLine("Max price: {0} руб.", MaxOriceProduct.Product_price);
        Console.ReadKey();
    }
}