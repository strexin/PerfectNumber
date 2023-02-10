using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[q];

            //Input Number
            for(int i = 0; q > i; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            //Output Result
            for (int i = 0; q > i; i++)
            {
                PerfectNumber(num[i]);
            }
                   
            Console.ReadLine();
        }

        static void PerfectNumber(int q)
        {                      
            int num = q;
            int k = 0;

            for (int a = 1; a < num; a++)
            {
                if (num % a == 0)
                {
                    k = k + a;
                }
            }

            if (k == num)
            {
                Console.WriteLine("perfect");
            }
                else if (k - 1 == num || k + 1 == num)
            {
                Console.WriteLine("hampir");
            }
            else
            {
                Console.WriteLine("bukan");
            }           
        }
    }
}
