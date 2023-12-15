using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Blinda Anatoly";
            double x = -0.9, n = 0, a = 0,sum = 0 ;
            Console.WriteLine("*****************************************************");
            Console.Write("y= ");
            for (n = 0; n<=20; n++)
            {
                a = 3.14/2 + Math.Pow((-1),n+1) * Math.Pow(x,2*n+1)/(2*n+1);
                sum =sum + a;
                if(n != 20)
                {   
                    Console.Write($"{a:0.00000}");
                }
                else
                {
                    Console.Write($"{a:0.00000} = {sum:0.00000}");    
                }
                Console.WriteLine();
                Console.WriteLine("*****************************************************");

                double y1 = 1/(Math.Atan(x));

                Console.WriteLine($"x = {x:0.00}, y = {sum:0.00}, y1 = {y1:0.00}");
            }
        }
    }
}
