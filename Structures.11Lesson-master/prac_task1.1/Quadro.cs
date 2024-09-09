namespace prac_task1._1;

struct Quadro
{
    // Поля структуры
    private double a;
    private double b;
    private double c;

    public Quadro(double a, double b, double c) //Конструктор
    {
        this.a = a; //  Поле - Элементк констуктора
        this.b = b;
        this.c = c;
    }

    public string Root()
    {
        double d2 = b * b - 4 * a * c;
        if (d2 < 0)
            return "Нет корней";
        double r1 = (-b + Math.Sqrt(d2)) / (2 * a);
        double r2 = (-b - Math.Sqrt(d2)) / (2 * a);
        return "x1: " + r1 + " x2: " + r2;
    }
}