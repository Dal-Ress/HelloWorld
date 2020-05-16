using System;

namespace CinemaAdviser
{
    using static Console;
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Здравствуй, дорогой друг. Эта программа поможет тебе подобрать фильм на вечер!");
            WriteLine("Напиши свое имя, пожалуйста!");
            String name = ReadLine();
            String text = "Здравствуйте, " + name;
            WriteLine(text);

            WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма или ужас?");

            String genre = ReadLine();

            WriteLine("В таком случае рекомендую посмотреть");

            if (genre == "комедия")
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Миллеры");
                WriteLine("Убойные каникулы");
            }
            else if (genre == "драма")
            {
                WriteLine("Титаник");
                WriteLine("Аватар");
            }

            else
            {
                WriteLine("Чужой");
                WriteLine("Экзорцист");
            }

            ReadLine();
        }
    }
}
