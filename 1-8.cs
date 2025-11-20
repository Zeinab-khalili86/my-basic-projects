using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_9
{
    class Program
    {
        private static int masahat(int t1, int a1)
        {
            int mas = t1 * a1;
            return mas;
        }
        private static int mohit(int t1, int a1)
        {
            int moh = (t1 + a1)*2;
            return moh;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Console.Write(" tool[{0}] :", i);
                int tool = int.Parse(Console.ReadLine());
                Console.Write(" arz[{0}] :", i);
                int arz = int.Parse(Console.ReadLine());
                Console.WriteLine(" masahat={0}    mohit={1}  ", masahat(tool, arz), mohit(tool, arz));
            }
            Console.ReadKey();
        }
    }
}
