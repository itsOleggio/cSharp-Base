namespace prac2;

public class GeomProgression : ISeries
{
    private int currentValue;
    private int commonRatio;

    public void SetStart(int x)
    {
        currentValue = x;
    }

    public int GetNext()
    {
        int nextValue = currentValue;
        currentValue *= commonRatio;
        return nextValue;
    }

    public void Reset()
    {
        currentValue /= commonRatio;
    }

    public void SetCommonRatio(int ratio)
    {
        commonRatio = ratio;
    }
}