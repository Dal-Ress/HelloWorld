using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static int min(int a, int b, int c)
        {
         
            if (a<b && a<c)
            {
                return a;
            }
            else if (b<a && b<c)
            {
                return b;
            }
            else
            {
                return c;
            }
            
        }

        static int numbers_count(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            #region Задание 1 "Определение наименьшего число из трех"
            Console.WriteLine("Введите три числа, и программа определит наименьшее из них!");
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальное число:" + min(a, b, c));
            #endregion

            #region Задание 2 "Определение количества цифр числа"

            Console.WriteLine("Введите число, и программа определит в нем количесто цифр:");
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int y = number;
            Console.WriteLine("Количество цифр: " + numbers_count(number));

            #endregion

            #region Задание 3 "Определение суммы нечетных чисел, пока не будет введен "0"
            Console.WriteLine("Вводите числа:");
            Console.WriteLine("Для завершения программы, введите 0");
            int sum = Convert.ToInt32(Console.ReadLine());
            int x;
            while (true)
            {
                x = int.Parse(Console.ReadLine());
                sum += (x > 0 && x % 2 == 1) ? x : 0;

                if (x == 0) break;
            }
            Console.WriteLine("Сумма нечетных чисел: " + sum);
            Console.ReadLine();
            #endregion


        }
    }
}
