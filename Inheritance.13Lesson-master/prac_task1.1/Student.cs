namespace prac_task1._1;

public class Student : Man
{
    string univer;

    // Вызов родительского конструктора
    public Student(string name, int age, string city, string univer) : base(name, age, city)
    {
        // Тут описывется, то что не сделали в Man
        this.univer = univer;
    }

    public string PrintInfo()
    {
        string result = base.PrintInfo();
        result += " University: " + univer + "\n";
        return result;
    }
}