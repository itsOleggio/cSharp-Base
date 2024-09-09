namespace prac1._1._1;

class Program
{
    static void Main(string[] args)
    {
        // // Номер, как число
        // Employee<int> employee = new Employee<int>() { Num = 1, Name = "Иванов", Summa = 100 };
        // // Номер, как строка 
        //
        // // Через блок инициализатора(Конструктор не нужен)
        // Employee<string> employee1 = new Employee<string>() { Num = "A001", Name = "Иванов", Summa = 100 };
        //
        // Console.Write("Введите ID: ");
        // int num = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Введите Имя: ");
        // string name = Console.ReadLine();
        // Console.Write("Введите зарплату: ");
        // int summa = Convert.ToInt32(Console.ReadLine());


        // Через конструктор
        //Employee<int> employee2 = new Employee<int>() { Num = num, Name = name, Summa = summa };

        Console.Write("Введите ID: ");
        string numString = Console.ReadLine();
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите зарплату: ");
        int summa= Convert.ToInt32(Console.ReadLine());

        Employee<string> employee3 = new Employee<string>(numString, name, summa);

        Console.WriteLine(employee3.GetInfo());
    }
}