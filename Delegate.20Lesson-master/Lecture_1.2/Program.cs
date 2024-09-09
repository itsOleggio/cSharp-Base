namespace Lecture_1._2;

class Program
{
    /*
     * Пример Делегата с аргументами
     */
    
    delegate int MyDelegate(int a, int b);
    delegate void MyDelegate1<T>(T a);
    
    static void Main(string[] args)
    { 
        
        
        // Вариант 1 обявления делегата 
        // MyDelegate myDelegate = Method5;
        /*if(myDelegate!= null)
        {
            int r;
            r = myDelegate(1, 2);
            Console.WriteLine(r);
        }*/

        // Вариант 2 обявления делегата 
        MyDelegate myDelegate = new MyDelegate(Method5);
        myDelegate?.Invoke(1, 2);
        Console.ReadKey();
        
        // Обобщенный делегат 
        MyDelegate1<string> myDelegate1 = new MyDelegate1<string>(Method3);
        myDelegate1?.Invoke("Test");
        Console.ReadKey();
    }

    static void Method3(string name)
    {
        Console.WriteLine("Method 3");
        Console.WriteLine(name);
    }
    static int Method5(int v1, int v2)
    {
        Console.WriteLine("Method5");
        return v1 + v2;
    }
}