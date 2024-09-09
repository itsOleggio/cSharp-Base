namespace prac_task1._1;

public class Man
{
    string Name;
    int birthDay;
    string city;

    //Свойства
    int BirthDay
    {
        get { return birthDay; }
        set
        {
            if (value > 2024)
            {
                birthDay = 2024;
            }
            else if (value < 1900)
            {
                birthDay = 1900;
            }
            else
            {
                birthDay = value;
            }
        }
    }

    //Конструктор
    public Man(string name, int birthDay, string city)
    {
        this.Name = name;
        this.BirthDay = birthDay; // BirthDay проверка по свойства 
        this.city = city;
    }

    //Метод для вывода информации о человеке
    public string PrintInfo()
    {
        return $"Имя: {Name}, День рождения: {birthDay}, Город: {city}";
    }
}