namespace prac_task2._1;

static class Circle
{
    public static double Length(double r)
    {
        return 2 * Math.PI * r;
    }

    public static double Square(double r)
    {
        return Math.PI * r * r;
    }

    public static bool IsInside(double x, double y, double r)
    {
        // Формула расстояния между двумя точками (x1, y1) и (x2, y2)
        double distance = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));

        // Если расстояние меньше или равно радиусу, то точка находится внутри круга
        if (distance <= r)
            return true;
        else
            return false;
    }
}