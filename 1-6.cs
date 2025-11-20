using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] moadel = new double[10];
            int i;
            double max, min;
            Console.Write(" moadel[0]=");
            moadel[0] = double.Parse(Console.ReadLine());
            max = moadel[0]; min = moadel[0];
            double sum = moadel[0];
            for (i = 1; i < moadel.Length; i++)
            {
                Console.Write(" moadel[{0}]=", i);
                moadel[i] = double.Parse(Console.ReadLine());
                sum += moadel[i];
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            for (i = 0; i < moadel.Length; i++)
                Console.WriteLine("moade [{0}] ={1} ", i, moadel[i]);
            for (int a = 0 ; a <moadel.Length- 1 ; a++)
                for (int j= 0 ; j <moadel.Length- 1 ; j++)
                {
                    if (moadel[j] > moadel[j + 1])
                    {
                        double temp = moadel[j];
                        moadel[j] = moadel[j + 1];
                        moadel[j + 1] = temp;
                    }
                }

            for (i = 0; i < moadel.Length-1; i++)
                Console.Write("   " + moadel[i]);
            for (i = 0; i < moadel.Length-1; i++) 
            {
                if (moadel[i] > max)
                    max = moadel[i];
                else if (moadel[i] < min)
                    min = moadel[i];
            }
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" max={0}  min={1}", max, min);
            Console.ReadKey();
            double avg = sum / moadel.Length;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" sum={0}   avg={1}", sum, avg);
            Console.ReadKey();

        }
    }
}
