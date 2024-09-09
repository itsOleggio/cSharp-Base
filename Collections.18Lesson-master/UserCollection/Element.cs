namespace UserCollection;

public class Element
{
    private string name;
    private int field1;
    private int field2;

    // В нем описаны 3 закрытых поля. Имеется констуктор 
    public Element(string s, int a, int b)
    {
        name = s;
        field1 = a;
        field2 = b;
    }

    // Свойства для доступа 
    public int Field1
    {
        get => field1;
        set => field1 = value;
    }

    public int Field2
    {
        get => field2;
        set => field2 = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
}