using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double []nomre=new double [10];
            double sum = 0;int i;
            for ( i = 0; i < nomre.LongLength; i++)
            {
                Console.Write(" nomre"+i+" :");
                nomre[i] = double.Parse(Console.ReadLine());
                if(nomre[i]>0 && nomre[i]<21)
                sum += nomre[i];
            }
            double avg=sum/nomre.LongLength;
            Console.WriteLine(" avg ={0}",avg);
            for(i=0;i<nomre.LongLength;i++)
            {
                if (nomre[i] > avg)
                    Console.WriteLine(" nomre {0} ={1} > avg ", i,nomre[i]);
            }
            Console.ReadKey();
                 
            
        }
    }
}
