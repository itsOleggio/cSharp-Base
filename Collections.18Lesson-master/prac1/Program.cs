namespace prac1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ведите строку:");
        string str = Console.ReadLine();

        Console.WriteLine(Chack(str));
        Console.ReadKey();
    }

    static bool Chack(string str)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
        };

        foreach (char c in str)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(dict[c]);
            }

            if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0 || stack.Pop() != c)
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
            return false;
    }

    /*
        Check метод:
        Принимает строку в качестве аргумента.
        Создает новый стек stack, который будет использоваться для отслеживания открытых скобок.
        Создает словарь dict, который содержит соответствия открывающих и закрывающих скобок.
        Проходит по каждому символу в строке.
        Если символ является открывающей скобкой ((, [, {), соответствующая закрывающая скобка помещается в стек.
        Если символ является закрывающей скобкой (), ], }), проверяется, совпадает ли он с вершиной стека. Если нет или стек пустой, то возвращается false.
        Если все скобки правильно расставлены и стек пустой в конце, то возвращается true. В противном случае, возвращается false.
     */
}