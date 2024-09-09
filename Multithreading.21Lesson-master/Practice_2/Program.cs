using System;
using System.Threading;

namespace Prac2
{
    class Program
    {
        private const int n = 5;
        private const int m = 5;

        private static int[,] matrix1 = new int[n, m];

        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardene1);

            Thread thread1 = new Thread(Gardene1);
            Thread thread2 = new Thread(Gardene2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < m; j++)
            //     {
            //         Console.Write(matrix1[i, j] + " ");
            //     }
            //
            //     Console.WriteLine();
            // }

            Console.ReadLine();
        }

        static void Gardene1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix1[i, j] == 0)
                    {
                        matrix1[i, j] = 1;
                        PrintMatrix(); 
                        Thread.Sleep(100); 
                    }
                }
            }
        }

        static void Gardene2()
        {
            for (int j = n - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0;i--)
                {
                    if (matrix1[i, j] == 0)
                    {
                        matrix1[i, j] = 2;
                        PrintMatrix(); 
                        Thread.Sleep(100); 
                    }
                }
            }
        }

        static void PrintMatrix()
        {
            //Console.ReadKey(); // Чтобы поэтапно видеть, что происходит 
            Console.Clear(); 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
