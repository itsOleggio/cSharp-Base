namespace prac_task2._1;

struct lineEqual
{
    private double k;
    private double b;

    public lineEqual(double k, double b)
    {
        this.k = k;
        this.b = b;
    }

    public double Root(double k, double b)
    {
        return (-b) / k;
    }
}