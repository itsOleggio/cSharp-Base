namespace prac2;

public class ArithProgression: ISeries
{
    private int currentValue; // Учасновка начального значения
    private int commonDifference; // Подсчет разницы 
    
    public void SetStart(int x) // Ставим начальное значение
    {
        currentValue = x;
    }

    public int GetNext() // Получаем следующее значение
    {
        int nextValue = currentValue;
        currentValue += commonDifference;
        return nextValue;
    }

    public void Reset() // Сбрасываем значение (сделано через цикл) 
    {
        currentValue -= commonDifference;
    }
    
    public void SetCommonDifference(int difference) // Установка разности
    {
        commonDifference = difference;
    }
}