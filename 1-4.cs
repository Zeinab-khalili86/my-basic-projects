using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = int.Parse(Console.ReadLine()),sum=0, i2=i;
            while (i > 0)
            {
                int a = i % 10;
                sum +=a;
                i = i / 10;
            }
            if (sum % 3 == 0)
                Console.WriteLine(" majmoo ragham haye adad " + i2 + " bar 3 bakhsh pazir ast");
            else
                Console.WriteLine(" majmoo ragham haye adad " + i2 + " bar 3 bakhsh pazir nist");
            Console.ReadKey();*/
            int i = int.Parse(Console.ReadLine()), sum = 0, i2 = i;
            do
            {
                int a = i % 10;
                sum += a;
                i = i / 10;
            }
            while (i > 0);
            if (sum % 3 == 0)
                Console.WriteLine(" majmoo ragham haye adad " + i2 + " bar 3 bakhsh pazir ast");
            else
                Console.WriteLine(" majmoo ragham haye adad " + i2 + " bar 3 bakhsh pazir nist");
            Console.ReadKey();

        }
    }
}
