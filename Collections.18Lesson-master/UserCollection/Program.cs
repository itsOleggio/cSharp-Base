namespace UserCollection;

class Program
{
    static void Main(string[] args)
    {
        
        ElementCollection myCollection = new ElementCollection(); // Создаем экземпляр класса колекции 

        foreach (Element element in myCollection)
        {
            Console.WriteLine("Name: {0} Field: {1} Field2: {2}", element.Name, element.Field1, element.Field2);
        }
        Console.ReadKey();
        
/*
 * Это минимальный код, который необходим для создания пользовательской коллекции
 * Теперь можно добавлять разные методы, которые не хватали в стандартной коллекции
 */        
    }
}