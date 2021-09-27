using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum_user = 0;

            for (int i = 0; i < 10; i++)
            {
                int number = rnd.Next(1, 14);
                Console.WriteLine("Выпало карта " + number);
                Console.WriteLine("Берешь карту? (y/n)");
                string ans_user = Console.ReadLine();
                if (ans_user == "y")
                {
                    sum_user = sum_user + number;
                }
                Console.WriteLine("Вы набрали " + sum_user);
                if (sum_user == 21)
                {
                    Console.WriteLine("Вы победили!");
                    break;
                }
                if (sum_user > 21)
                {
                    Console.WriteLine("Вы перебрали и проиграли!");
                    break;
                }
            }
                

        }
    }
}
