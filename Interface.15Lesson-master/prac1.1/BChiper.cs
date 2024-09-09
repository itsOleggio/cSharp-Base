namespace Interface._15Lesson;

public class BChiper : IChiper
{
    public string Encoder(string text)
    {
        string result = string.Empty;
        foreach (char c in text)
        {
            int num = (int)c - (int)'A';
            if (c >= 'B' && c <= 'Z') // Из Y идет Z
            {
                result +=  (char)((int)'Z' - num);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    public string Decoder(string text)
    {
        return Encoder(text); 
    }
}