using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i -= 5)
                Console.Write(  i+"    ");
            Console.ReadKey();
        }
    }
}
