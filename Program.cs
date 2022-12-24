using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_prime_numbers_from_n1_and_n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool notprime = false;
            int j,num1 ,num2,i ;
            Console.WriteLine("Enter your first number");
             num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("*______*");
            for (i = num1; i <=num2; i++)
            {
                for (j = num1; j < i; j++)
                {
                    if (i % j == 0)
                    { notprime = true; break; }
                }
                if (!notprime)
                    Console.WriteLine("{0}",j);
                else
                    notprime = false;
            }
               
        }
    }
}
