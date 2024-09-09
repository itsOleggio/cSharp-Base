namespace UserCollection2;

class Program
{
    static IEnumerator<int> GetInts()
    {
        Console.WriteLine("first");
        yield return 1; // Создается автоматически 
        
        Console.WriteLine("second");
        yield return 2;
    }
    
    
    static void Main(string[] args)
    {
        // переменная, которая является ссылокой на IEnumerator
        IEnumerator<int> intsEnumerator = GetInts();
        Console.WriteLine("...");
        
        intsEnumerator.MoveNext(); // Выполнения, пока не встретят 1 yeal 
        Console.WriteLine(intsEnumerator.Current);
    }
    
    /*
     * 1. GetInts вернет объект реализующий IEnumerator, при этом метод не будет выполнен 
     * 2. Компелятор видя yield создал вложенный класс, который автоматичеки реализовал MoveNext и Current
     * 3. При первом MoveNext выволнения метода будет запущено
     * 4. Интструкции будут выполняться, пока не встетят yield return, выполнение опять преостановится
     * 5. В свойства Current будет записно значение указано возле yield 1
     * 6. При слудующем выполнении MoveNext будет выполнения 2 чилса
     * 7. IEnumerator<int> intsEnumerator = GetInts(); при обявлении это все начнется по новой 
     */
}