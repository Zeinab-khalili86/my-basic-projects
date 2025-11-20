using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nam = new string[7], famil = new string[7];
            double[] nomre = new double[7];
            double key;
            int i;
            for (i = 0; i < nomre.Length; i++)
            {
                Console.Write(" nam[{0}] :", i);
                nam[i] = Console.ReadLine();
                Console.Write(" famil[{0}]:", i);
                famil[i] = Console.ReadLine();
                Console.Write(" nomre[{0}]:", i);
                nomre[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("__________________");
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            for (i = 0; i < nomre.Length; i++)
                Console.WriteLine(" nam[{0}] = {1}     famil[{2}] = {3}    nomre[{4}]= {5}", i, nam[i], i, famil[i], i, nomre[i]);
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Array.Sort(nomre);
            Console.Write(" moratab sazi");

            for (i = 0; i < nomre.Length; i++)
                Console.WriteLine(" nam[{0}] = {1}     famil[{2}] = {3}    nomre[{4}]= {5}", i, nam[i], i, famil[i], i, nomre[i]);
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            int first, last, middle, pos = -1;
            bool found = false;
            for (i = 0; i < 3; i++)
            {
                Console.Write(" key[{0}]:", i);
                key = double.Parse(Console.ReadLine());
                for (int a = 0; a < nomre.Length; a++)
                {
                    first = 0; last = nomre.Length - 1; middle = (first + last) / 2; pos = -1; found = false;
                    while (first <= last)
                    {
                        if (key == nomre[middle])
                        {
                            found = true;
                            pos = middle;
                            continue;
                        }
                        else if (key < nomre[middle])
                            last = middle - 1;
                        else if (key > nomre[middle])
                            first = middle + 1;
                    }
                }
                if (found)
                    Console.WriteLine(" found key{0}   in nomre[{1}]", key, pos);
                else
                    Console.WriteLine("not found key{0}", key);
            }
            Console.ReadKey();









        }
    }
}
