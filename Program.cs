using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string massage;
            int howMuch;

            Console.Write("Введите ваш текст: ");
            massage = Console.ReadLine();

            Console.Write("Какое колличество раз его повторить?: ");
            howMuch = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < howMuch; i++) 
            {
                Console.WriteLine(massage);
            }

        }
    }
}
