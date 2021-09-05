/* Практическое задание Task3 для Урока2 
 * оно задано тут  https://docs.google.com/document/d/1qg52591RTgqT4SIg0_oFQYYnvdvusaNJA-g2I0JvOKI/edit#heading=h.u9r7mqts77ja
 * Звучит так: Определить, является ли четным число, введённое пользователем. 
 */

using System;

namespace lesson2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;

            for(int ii=0; ii<100; ii++) 
            {
                Console.WriteLine(" ");
                Console.WriteLine(" Я определю является ли четным число, введённое Вами, введите его плз: ");
                v1 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(v1 % 2);
                if ( (v1 % 2) == 0) // если деление дало нулевой остаток, значит число является четным
                {
                    Console.WriteLine($" ура! это число {v1} является четным. ");
                }

                if ((v1 % 2) > 0) // если деление дало остаток больше нуля, значит число является нечетным 
                {
                    Console.WriteLine($" ой! это число {v1} является нечетным. ");
                }

            }

            Console.WriteLine(" У вас было 100 попыток. Запустите приложение заново, чтобы воспользовать имеще раз.");
            Console.ReadKey();


        }
    }
}
