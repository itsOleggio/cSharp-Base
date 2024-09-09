namespace Lecture;

class Program
{
    static void Main(string[] args)
    {
        Apartment<int> apartment = new Apartment<int>(); // Параметризованный тип int
        apartment.Number = 1;
        int next = (int)apartment.Number + 1;
        
        Apartment<string> apartment2 = new Apartment<string>(); // Параметризованный тип string
        apartment2.Number = "Квартира 2"; // еперь сюда нельзя присвоить тип int 
        
        Car<int, string> car = new Car<int, string>(); 
        car.Number = 1;
        car.Color = "Red";
        Car<string, string> car2 = new Car<string, string>(); 
        car2.Number = "1";
        car2.Color = "Yellow";
    }

    class Apartment<T>
    {
        public T Number { get; set; }
    }

    class Car<T, U>
    {
        public T Number { get; set; }
        public U Color { get; set; }
    }
}