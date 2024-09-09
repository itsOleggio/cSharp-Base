namespace prac_task1._1;

class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Apple("Антоновка", "Сладкий", "Мостква");
        apple.ShowInfo();
        Lemon lemon = new Lemon("Лимонка", 2);
        lemon.ShowInfo();
    }
}