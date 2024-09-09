namespace prac2;

interface ISeries
{
    void SetStart(int x); // устанавливает начальное значение
    int GetNext(); //возвращает следующее число ряда
    void Reset(); // выполняет сброс к начальному значению
}