using System.Collections;

namespace UserCollection;

public class ElementCollection : IEnumerable, IEnumerator // Указываем, что он реализует интерфейсы 
{
    private Element[] elementsArrayt = null;

    int position = -1;

    // Сразу проинициализировали 
    public ElementCollection()
    {
        elementsArrayt = new Element[4];
        elementsArrayt[0] = new Element("A", 1, 10);
        elementsArrayt[1] = new Element("A", 2, 20);
        elementsArrayt[2] = new Element("A", 3, 30);
        elementsArrayt[3] = new Element("A", 4, 40);
    }

    // Члены IEnumerator, которые реализуем 
    public bool MoveNext()
    {
        if (position < elementsArrayt.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
    
    // MoveNext должен описывать логику перемещения к следующему элементу. 
    
    public void Reset()
    {
        position = -1;
    }

    // Reset возвращает значение на стартовую позицию -1.
    
    public object Current
    {
        get { return elementsArrayt[position]; }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this as IEnumerator;
    }

    /*
     интерфейс IEnumerator требует наличие метода GetEnumerator
     Которуый вернет ссылну на конкретную реализацию интерфейса IEnumerator.
     В теле метода возвращаетм текущий обект преобразовав его в интерфейс IEnumerator.
     */
    // Current возвращает текущий элемент с индексом position.
}