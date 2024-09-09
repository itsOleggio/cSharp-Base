using System;

namespace prac_task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите целое число, X=");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число, Y=");
                int Y = Convert.ToInt32(Console.ReadLine());

                int result = 0;

                Console.WriteLine("Введите код операции: ");
                Console.WriteLine("   1 - сложение");
                Console.WriteLine("   2 - вычитание");
                Console.WriteLine("   3 - умножение");
                Console.WriteLine("   4 - деление");

                Console.Write("Ваш выбор: ");
                int sw = Convert.ToInt32(Console.ReadLine());

                if (sw == 1)
                {
                    result = X + Y;
                }
                else if (sw == 2)
                {
                    result = X - Y;
                }
                else if (sw == 3)
                {
                    result = X * Y;
                }
                else if (sw == 4)
                {
                    if (Y != 0)
                    {
                        result = X / Y;
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером");
                    return;
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат ввода числа");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введено слишком большое или слишком маленькое число");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}