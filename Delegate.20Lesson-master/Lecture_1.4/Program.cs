using System.Reflection.Metadata;

namespace Lecture_1._4;

class Program
{
    /*
     * Настройка для уведомления суммы
        1. Добавим событие на действие 
        2. Подписчиков уведомим о событии 
        Чтобы определить событие, сначала нужно создать делегат.
     */
    
    static void Main(string[] args)
    {
        Bank bank = new Bank(1000);
        bank.Notify += Log;
        bank.Put(1000);
        bank.Get(500);
        Console.ReadKey();
    }

    static void Log(string message)
    {
        Console.WriteLine(message);
    }
    
    /*
     Событие позволяет уведомлять подписчиков, об произошедших изменениях и 
     механизм событий основан на использовании делегатов. Событие представляют 
     переменную делегата. В момент вызова делегата выполняются все методы, которые 
     связаны с делегатом 
     */
    
}

class Bank
{
    // Создание делегата 
    public delegate void LogEvent(string message);
        
    // Событие
    public event LogEvent Notify; // event - переменная делегата 
        
    private int Summa;

    // Конструктор
    public Bank(int summa)
    {
        this.Summa = summa;
    }

    // Методы 
    public void Put(int S)
    {
        Summa += S;
        Notify?.Invoke("Сумма: " + Summa);
    }

    public void Get(int S) 
    {
        Summa -= S;
        Notify?.Invoke("Сумма: " + Summa);
    }
}