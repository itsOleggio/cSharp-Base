namespace Practice2;

class Program
{
    static void Main(string[] args)
    {
        List<Computer> computers = new List<Computer>()
        {
            new Computer()
            {
                ID = 1, Name = "Desktop 1", TypeCPU = "Intel Core i7", Frequency = 3.6, RAM = 16, HDD = 512, GPU = 6,
                price = 1200.00, Available = 10
            },
            new Computer()
            {
                ID = 2, Name = "Laptop 1", TypeCPU = "AMD Ryzen 5", Frequency = 3.2, RAM = 8, HDD = 256, GPU = 4,
                price = 900.50, Available = 5
            },
            new Computer()
            {
                ID = 3, Name = "Desktop 2", TypeCPU = "Intel Core i5", Frequency = 3.0, RAM = 8, HDD = 1000, GPU = 3,
                price = 800.25, Available = 7
            },
            new Computer()
            {
                ID = 4, Name = "Laptop 2", TypeCPU = "Intel Core i3", Frequency = 2.4, RAM = 4, HDD = 128, GPU = 2,
                price = 500.75, Available = 3
            },
            new Computer()
            {
                ID = 5, Name = "Desktop 3", TypeCPU = "AMD Ryzen 7", Frequency = 3.8, RAM = 32, HDD = 2000, GPU = 8,
                price = 1800.00, Available = 15
            },
            new Computer()
            {
                ID = 6, Name = "Laptop 3", TypeCPU = "Intel Core i9", Frequency = 4.0, RAM = 16, HDD = 512, GPU = 6,
                price = 1500.00, Available = 8
            },
            new Computer()
            {
                ID = 7, Name = "Desktop 4", TypeCPU = "AMD Ryzen 5", Frequency = 3.2, RAM = 16, HDD = 1000, GPU = 4,
                price = 1100.50, Available = 12
            },
            new Computer()
            {
                ID = 8, Name = "Laptop 4", TypeCPU = "Intel Core i7", Frequency = 3.6, RAM = 32, HDD = 1000, GPU = 8,
                price = 2000.25, Available = 6
            },
            new Computer()
            {
                ID = 9, Name = "Desktop 5", TypeCPU = "Intel Core i5", Frequency = 3.0, RAM = 8, HDD = 256, GPU = 3,
                price = 700.75, Available = 9
            },
            new Computer()
            {
                ID = 10, Name = "Laptop 5", TypeCPU = "AMD Ryzen 3", Frequency = 2.6, RAM = 4, HDD = 512, GPU = 2,
                price = 400.00, Available = 64
            }
        };

        Console.Write("Введите название процессора:");
        string imput_CPU = Console.ReadLine();
        List<Computer> pc1 = computers.Where(quary => quary.TypeCPU == imput_CPU).ToList();
        Print(pc1);
        skip();

        Console.Write("Введите минимальный объем оперативной памяти:");
        int min_ram = Convert.ToInt32(Console.ReadLine());
        List<Computer> pc2 = computers.Where(quary => quary.RAM >= min_ram).ToList();
        Print(pc2);
        skip();

        Console.WriteLine("Список процессоров по возрастанию стоимости");
        Print(computers.OrderBy(quary => quary.price).ToList());
        skip();

        Console.WriteLine("Список сгруппированный по процессору:");
        IEnumerable<IGrouping<string, Computer>> pc3 = computers.GroupBy(quary => quary.TypeCPU).ToList();
        foreach (IGrouping<string, Computer> computer in pc3)
        {
            Console.WriteLine();
            Console.WriteLine(computer.Key);
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-10} {4,-5} {5,-5} {6,-5} {7,-10} {8,-10}", "ID", "Name",
                "TypeCPU", "Frequency", "RAM", "HDD", "GPU", "Price", "Available");
            foreach (Computer pc in computer)
            {
                Console.WriteLine(
                    $"{pc.ID,-5} {pc.Name,-15} {pc.TypeCPU,-15} {pc.Frequency,-10} {pc.RAM,-5} {pc.HDD,-5} {pc.GPU,-5} {pc.price,-10} {pc.Available,-10}");
            }
        }

        skip();

        Console.WriteLine("Самай дорогой компьюетр");
        Computer pc_expensive = computers.OrderByDescending(quary => quary.price).First();
        Print(pc_expensive);
        Console.WriteLine("Самый дешевый компьютер");
        Computer pc_low = computers.OrderBy(quary => quary.price).First();
        Print(pc_low);
        skip();

        bool is_available = computers.Any(quary => quary.Available >= 30);
        if (is_available)
            Console.WriteLine("Есть компьюеры в большом количестве");
        else
            Console.WriteLine("На складе мало компьюьеров");
        skip();
    }


    static void Print(List<Computer> computers)
    {
        if (computers.Count == 0)
        {
            Console.WriteLine("Товар не найден");
        }
        else
        {
            Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-10} {4,-5} {5,-5} {6,-5} {7,-10} {8,-10}", "ID", "Name",
                "TypeCPU", "Frequency", "RAM", "HDD", "GPU", "Price", "Available");
            foreach (Computer computer in computers)
            {
                Console.WriteLine(
                    $"{computer.ID,-5} {computer.Name,-15} {computer.TypeCPU,-15} {computer.Frequency,-10} {computer.RAM,-5} {computer.HDD,-5} {computer.GPU,-5} {computer.price,-10} {computer.Available,-10}");
            }
        }
    }

    static void Print(Computer pc)
    {
        Console.WriteLine("{0,-5} {1,-15} {2,-15} {3,-10} {4,-5} {5,-5} {6,-5} {7,-10} {8,-10}", "ID", "Name",
            "TypeCPU", "Frequency", "RAM", "HDD", "GPU", "Price", "Available");
        Console.WriteLine(
            $"{pc.ID,-5} {pc.Name,-15} {pc.TypeCPU,-15} {pc.Frequency,-10} {pc.RAM,-5} {pc.HDD,-5} {pc.GPU,-5} {pc.price,-10} {pc.Available,-10}");
    }

    static void skip()
    {
        Console.WriteLine("");
        Console.ReadKey();
    }
}