namespace Lecture_1;

class Program
{
    static void Main(string[] args)
    {
        List<Door> listDoor = new List<Door>()
        {
            new Door
            {
                Id = 1, Width = 10, Height = 20, Cost = 10000, Manufacturer = "Заря", Material = "Металл",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Глазок", "Замок" }
            },
            new Door
            {
                Id = 2, Width = 4, Height = 10, Cost = 7000, Manufacturer = "Красный луч", Material = "Дерево",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Глазок", "Замок" }
            },
            new Door
            {
                Id = 3, Width = 7, Height = 19, Cost = 7200, Manufacturer = "Оконный завод", Material = "Пластик",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Замок" }
            },
            new Door
            {
                Id = 4, Width = 10, Height = 20, Cost = 1500, Manufacturer = "Заветы Ильеча", Material = "Дерево",
                Composition = new List<string> { "Полотно", "Петли", "Глазок", "Замок" }
            },
            new Door
            {
                Id = 5, Width = 11, Height = 20, Cost = 1600, Manufacturer = "Заря", Material = "Металл",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Замок" }
            },
            new Door
            {
                Id = 6, Width = 8, Height = 19, Cost = 900, Manufacturer = "Оконный завод", Material = "Прастик",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Глазок", "Замок" }
            },
            new Door
            {
                Id = 7, Width = 15, Height = 25, Cost = 11000, Manufacturer = "Восход", Material = "Металл",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Глазок", "Замок" }
            },
            new Door
            {
                Id = 8, Width = 9, Height = 21, Cost = 6500, Manufacturer = "Красный луч", Material = "Дерево",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Глазок" }
            },
            new Door
            {
                Id = 9, Width = 12, Height = 21, Cost = 1700, Manufacturer = "Заря", Material = "Металл",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Замок" }
            },
            new Door
            {
                Id = 10, Width = 11, Height = 19, Cost = 3000, Manufacturer = "Красный луч", Material = "Дерево",
                Composition = new List<string> { "Полотно", "Коробка", "Петли", "Ручка" }
            },
        };

        // 1. Перебор циклом и поместить в новую коллекцию 
        // List<Door> doors = new List<Door>();
        // foreach (Door d in listDoor)
        // {
        //     if (d.Material == "Дерево")
        //     {
        //         doors.Add(d);
        //     }
        // }

        // Перебор через LINQ 
        //IEnumerable<Door> doors = from d in listDoor where d.Material == "Дерево" select d;

        // Преобразование правой части 
        //List<Door> doors = (from d in listDoor where d.Material == "Дерево" select d).ToList();

        // // Синтаксис на основе методов расширения 
        // List<Door> doors = listDoor
        //     .Where(d => 
        //     d.Material == "Дерево").ToList();
        // //Из исходного значения d получить значение поля 
        //
        // // Вывод нового списка 
        // foreach (Door d in doors)
        // {
        //     Console.WriteLine("{0} {1} {2} {3}", d.Id, d.Width, d.Height, d.Cost);
        // }

        // Первая дверь из дерева

        // Door doors = listDoor
        // .Where(d => 
        // d.Material == "Дерево").First();
        //
        // Console.WriteLine(doors.Id);


        Console.WriteLine("Вывод дверей которые Width больше 10");
        //Вывод дверей которые Width больше 10
        IEnumerable<Door> doors = from d in listDoor where d.Width > 10 select d;
        foreach (Door d in doors)
        {
            Console.WriteLine("{0} {1} {2} {3}", d.Id, d.Width, d.Height, d.Cost);
        }

        Console.ReadKey();

        Console.WriteLine("Вывод методом расширения");
        // Синтаксис на основе методов расширения 
        List<Door> doors2 = listDoor
            .Where(d =>
                d.Width > 10 && d.Material == "Дерево").ToList();
        foreach (Door d in doors2)
        {
            Console.WriteLine("{0} {1} {2} {3}", d.Id, d.Width, d.Height, d.Cost);
        }

        Console.ReadKey();

        Console.WriteLine("Вывод с сложным условием");
        //Вывод c более сложным условием 
        List<Door> doors3 = (from d in listDoor
            from p in d.Composition
            where p == "Глазок"
            where d.Width > 10
            where d.Width > 10
            select d).ToList();
        foreach (Door d in doors3)
        {
            Console.WriteLine("{0} {1} {2} {3}, {4}", d.Id, d.Width, d.Height, d.Cost, d.Manufacturer);
        }

        Console.ReadKey();

        Console.WriteLine("Работа с проекцией");
        // Работа с проекцией 
        List<string> doors5 = (from d in listDoor select d.Manufacturer).Distinct().ToList();
        foreach (string s in doors5)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();

        Console.WriteLine("Проекция для методов расширения");
        // Работа с проекцией для методов с раширения
        List<string> doors6 = listDoor
            .Select(d => d.Manufacturer)
            .Distinct()
            .ToList();
        foreach (string s in doors6)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();

        Console.WriteLine("Пример с анонимными типами");
        // Анонимные типы
        var doors7 = listDoor
            .Select(d => new // Напоминает создание экземпляра класса 
            {
                Mater = d.Material, // Блок инициализатора 
                Manuf = d.Manufacturer, // Не хватает блока констуктора, поэтому он считвется анонимным, компрялятор сам автоматически определяет автосвойство
            })
            .Distinct()
            .ToList();
        foreach (var s in doors7)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();

        Console.WriteLine("Анонимные типы SQL синтаксис ");
        // Анонимные типы SQL синтаксис 
        var doors8 = from d in listDoor
            select new
            {
                Mater1 = d.Material,
                Manuf1 = d.Manufacturer,
            };
        Console.ReadKey();

        Console.WriteLine("Вывод отсоритрованных элементов ");
        // Сортировка элементов 
        var doors9 = (from d in listDoor
            orderby d.Cost
            select d).ToList();

        foreach (var s in doors9)
            Console.WriteLine($"{s.Id} {s.Width} {s.Height} {s.Cost} {s.Manufacturer}");
        Console.ReadKey();

        Console.WriteLine("Сортировка методов расширения");
        // Соритрвока при помощи методов расширения 
        var doors10 = listDoor
            .OrderByDescending(d => d.Cost)
            .ToList();
        foreach (var s in doors10)
            Console.WriteLine($"{s.Id} {s.Width} {s.Height} {s.Cost} {s.Manufacturer}");
        Console.ReadKey();
    }

    class Door
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public List<string> Composition { get; set; }
    }
}