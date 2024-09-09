namespace prac2;

public class Bill<T>
{
    private T number_bill { get; set; }
    private int account_balance { get; set; }
    private string name { get; set; }

    public string GetInfo()
    {
        return $"Number_bill: {number_bill} Account_balance: {account_balance} Name: {name}";
    }

    Random random = new Random();

    public void SetInfo()
    {
        Console.Write("Введите новый номер счета: ");
        number_bill = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        Console.Write("Введите ваше ФИО: ");
        name = Console.ReadLine();
        Console.WriteLine();
        account_balance = 500 + random.Next(0, 11);
    }
}