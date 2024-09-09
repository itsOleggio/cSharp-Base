namespace Interface._15Lesson;

public class AChiper : IChiper
{
    public string Encoder(string text)
    {
        string result = string.Empty;
        foreach (char c in text)
        {
            if (c >= 'A' && c <= 'Y') // Из Y идет Z
            {
                result += (char)((int)c + 1); // Преобразовывваем в код, сдвигаем на 1 и возвращаем назад в Char
            }

            else if (c == 'Z') // Z обрабатывается отдельно 
            {
                result += 'A';
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
        string result = string.Empty;
        foreach (char c in text)
        {
            if (c >= 'B' && c <= 'Z') // Из Y идет Z
            {
                result += (char)((int)c - 1);
            }

            else if (c == 'A') // Z обрабатывается отдельно 
            {
                result += 'Z';
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}