namespace Practice_1;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee() { Number = 1, Name = "Иванов", Salary = 100, City = "Москва" },
            new Employee() { Number = 2, Name = "Петров", Salary = 110, City = "Санкт-Петербург" },
            new Employee() { Number = 3, Name = "Сидоров", Salary = 60, City = "Сочи" },
            new Employee() { Number = 4, Name = "Кузнецов", Salary = 150, City = "Тула" },
            new Employee() { Number = 5, Name = "Васильев", Salary = 200, City = "Москва" },
            new Employee() { Number = 6, Name = "Бендер", Salary = 500, City = "Санкт-Петербург" },
            new Employee() { Number = 7, Name = "Воробьев", Salary = 90, City = "Сочи" },
            new Employee() { Number = 8, Name = "Балаганов", Salary = 120, City = "Омск" },
        };

        /*
        - Всех сотрудников из указанного города
        - Всех сотрудников с зарплатой не ниже, чем указано
        - вывести весь список, отсортированных по имени в алфавитном порядке
        - вывести весь список, сгруппированный по городу
        - найти самого высокооплачиваемого и самого низкооплачиваемого сотрудника
        - есть ли хотя бы один сотрудник с зарплатой не менее 200 т.р
        */

        //Всех сотрудников из указанного города
        Console.Write("Введите город:");
        string city = Console.ReadLine();
        
        List<Employee> employees1 = employees.Where(find => find.City == city).ToList();
        Print(employees1);
        Console.WriteLine();
        Console.ReadKey();


        // Всех сотрудников с зарплатой не ниже, чем указано
        Console.Write("Введите зарплату:");
        int LowSalary = Convert.ToInt32(Console.ReadLine());
        List<Employee> employees2 = employees.Where(find => find.Salary >= LowSalary).ToList();
        Print(employees2);
        Console.WriteLine();
        Console.ReadKey();

        // вывести весь список, отсортированных по имени в алфавитном порядке
        Console.WriteLine("Отсортированный список сотрудников");
        List<Employee> employees3 = employees.OrderBy(find => find.Name).ToList();
        Print(employees3);
        Console.WriteLine();
        Console.ReadKey();

        // вывести весь список, сгруппированный по городу
        Console.WriteLine("Группировка по городу");
        IEnumerable<IGrouping<string, Employee>> employees4 = employees.GroupBy(find => find.City).ToList();
        foreach (IGrouping<string, Employee> gr in employees4)
        {
            Console.WriteLine(gr.Key);
            foreach (Employee e in gr)
            {
                Console.WriteLine($"{e.Number} {e.Name} {e.Salary} {e.City}");
            }
        }
        Console.WriteLine();
        Console.ReadKey();
        
        // найти самого высокооплачиваемого и самого низкооплачиваемого сотрудника
        Console.Write("Самая большая зарплата:");
        Employee employee5 = employees.OrderByDescending(find => find.Salary).FirstOrDefault();
        Console.WriteLine($"{employee5.Number} {employee5.Name} {employee5.Salary} {employee5.City}");
        Console.Write("Самая низкая зарплата: ");
        Employee employee6 = employees.OrderBy(find => find.Salary).FirstOrDefault();
        Console.WriteLine($"{employee6.Number} {employee6.Name} {employee5.Salary} {employee6.City}");
        Console.WriteLine();
        Console.ReadKey();
        
        // есть ли хотя бы один сотрудник с зарплатой не менее 200 т.р 
        bool employees7 = employees.Any(find => find.Salary >= 200);
        if (employees7)
            Console.WriteLine("Есть сотрудник с зарплатой не менее 200 т.р");
        else
            Console.WriteLine("Нет сотрудников с зарплатой не менее 200 т.р");
    }

    static void Print(List<Employee> employees)
    {
        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.Number} {e.Name} {e.Salary} {e.City}");
        }
    }
}