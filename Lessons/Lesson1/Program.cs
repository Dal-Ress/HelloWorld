using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    using static Console;
    class Program
    {

        static void Main(string[] args)
        {

            #region Задача № 1 "Анкета"

            WriteLine("Напиши свое имя: ");
            string firstName = ReadLine();
            WriteLine("Напиши свою фамилию: ");
            string lastName = ReadLine();
            WriteLine("Напиши свой возраст: ");
            string age = ReadLine();
            WriteLine("Напиши свой рост: ");
            string height = ReadLine();
            WriteLine("Напиши свой вес: ");
            string weight = ReadLine();

            WriteLine("Анкета");
            WriteLine("Имя: " + firstName + "\nФамилия: " + lastName + "\nВозраст: " + age + "\nРост: " + height + "\nВес: " + weight);
            WriteLine("-----");
            WriteLine($"Имя: {firstName} \nФамилия: {lastName} \nВозраст: {age} \nРост: {height} \nВес: {weight}");

            #endregion

            #region Задача № 2 "Индекс массы тела"

            double m = Convert.ToDouble(weight);
            double h = Convert.ToDouble(height);
            double l = m / ((h * h) / 10000);

            WriteLine($"Индекс массы тела: {l:0.00}");

            #endregion

            #region Задача № 3 "Расстояние между точками"

            WriteLine("Расстояние между точками");
            WriteLine("Задайте координаты для х1: ");
            double x1 = Convert.ToDouble(ReadLine());
            WriteLine("Задайте координаты для х2: ");
            double x2 = Convert.ToDouble(ReadLine());
            WriteLine("Задайте координаты для y1: ");
            double y1 = Convert.ToDouble(ReadLine());
            WriteLine("Задайте координаты для y2: ");
            double y2 = Convert.ToDouble(ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            WriteLine($"Расстояние между точками: {r:0.00}");

            #endregion

            #region Задача № 4 "Программа обмена значениями двух переменных"

            Console.Write("Введите значение первой переменной a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение второй переменной b: ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Поменяем значения местами");
            double c = a;
            a = b;
            b = c;
            Console.WriteLine($"a={a} \nb={b}");


            #endregion

            #region Задача № 5 "Вывод в центр"
            Console.ReadKey();
            string name = "Журавский Влад";
            string city = "Moscow";

            int width = Console.WindowWidth;

            WriteLine(name.PadLeft(width/2));
            //SetCursorPosition(100, 105);
            //WriteLine(city);

            #endregion
            
        }

    }
}
