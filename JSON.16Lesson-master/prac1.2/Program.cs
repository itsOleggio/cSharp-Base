using System.Text.Json;
using System.IO;

namespace prac1._2;

class Program
{
    static void Main(string[] args)
    {
        string jsonStrig  = String.Empty;
        using (StreamReader sr = new StreamReader("../../../../employees.json"))
        {
            jsonStrig = sr.ReadToEnd(); // Если обявить тут, то её будет не видно из другого места программыы 
        }
    
        // Тип который вернется Employee[], а в качестве аргумента передаем jsonStrig
        Employee[] employees = JsonSerializer.Deserialize<Employee[]>(jsonStrig);;
        
        //Созраняем сразу всего сотрудника. Пока самый первый, сабый большой 
        Employee maxEmployee = employees[0];
        
        // Найти самую большую зарплату. Методом сохранения самого лучшего большого значения
        foreach (Employee emp in employees)
        {
            if (emp.Summa > maxEmployee.Summa)
            {
                maxEmployee = emp; // Сохраняем самого лучшего сотрудника
            }
        }

        Console.WriteLine($"Максимальная зарплата: {maxEmployee.Summa} {maxEmployee.Name}, {maxEmployee.Num}");
        Console.ReadKey();
    }
}