using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как твоем имя?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Console.ReadKey();

        }
    }
}
