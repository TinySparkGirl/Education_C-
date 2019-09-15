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

            Console.WriteLine("Давай посмотрим фильм. Какой жанр ты предпочитаешь: комедия или драма?");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, выбирай что-то из этого:");

            if (genre == "комедия")
            {
                Console.WriteLine("*Ёлки");
                Console.WriteLine("*Бабушка легкого поведения");
                Console.WriteLine("*Я худею");
                Console.WriteLine("*Самый лучший день");
            }
            else
            {
                Console.WriteLine("*Батальон");
                Console.WriteLine("*Тренер");
                Console.WriteLine("*Территория");
                Console.WriteLine("*Титаник");
            }

            Console.ReadLine();
        }
    }
}
