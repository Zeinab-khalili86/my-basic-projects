using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nome = 0, number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0;
            for (int i = 1; i <= 10; i += 1)
            {
                Console.Write(" nomre nafare " + i + ":");
                nome = double.Parse(Console.ReadLine());
                if (nome >= 0 && nome < 11)
                {
                    number1 += 1;
                }
                else if (nome > 10 && nome < 15)
                {
                    number2 += 1;
                }
                else if (nome > 14 && nome < 18)
                {
                    number3 += 1;
                }
                else if (nome > 17 && nome < 20)
                {
                    number4 += 1;
                }
                else if (nome == 20)
                {
                    number5 += 1;
                }
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor. DarkRed;
            Console.WriteLine("nomarat bein 0-10 = " + number1);
            Console.WriteLine("nomarat bein 11-14 = " + number2);
            Console.WriteLine("nomarat bein 15-17 = " + number3);
            Console.WriteLine("nomarat bein 18-19 = " + number4);
            Console.WriteLine("nomarat  20 = " + number5);
            Console.ReadKey();
                  
        }
    }
}
