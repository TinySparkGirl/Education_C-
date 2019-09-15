using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую, мой незнакомый друг.");
            Console.WriteLine("Как тебя зовут?");
            String name = Console.ReadLine();

            Console.WriteLine("Рада знакомству, " + name);

            Console.WriteLine("Давай посмотрим фильм. Какой жанр ты предпочитаешь: комедия, триллеры, боевики или драма?");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, выбирай что-то из этого:");

            if (genre == "комедия")
            {
                Console.WriteLine(" * Ёлки");
                Console.WriteLine(" * Бабушка легкого поведения");
                Console.WriteLine(" * Я худею");
                Console.WriteLine(" * Самый лучший день");
            }

            else if(genre == "триллеры")
            {
                Console.WriteLine(" * Пассажир");
                Console.WriteLine(" * Игра в имитацию");
                Console.WriteLine(" * Игра на выживание");
                Console.WriteLine(" * Джунгли");
            }

            else if (genre == "боевики")
            {
                Console.WriteLine(" * Небоскрёб");
                Console.WriteLine(" * Балканский рубеж");
                Console.WriteLine(" * Три дня на побег");
                Console.WriteLine(" * Механик: воскрешение");
            }

            else
            {
                Console.WriteLine(" * Батальон");
                Console.WriteLine(" * Тренер");
                Console.WriteLine(" * Территория");
                Console.WriteLine(" * Титаник");
            }

            Console.WriteLine("Приятного просмотра!");

            Console.ReadLine();
        }
    }
}
