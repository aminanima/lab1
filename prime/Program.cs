using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static bool IsPrime(string s)
        {
            //converting string to int
            int x = int.Parse(s);

            //because 1 is not prime
            int cnt = 2;

            //check and count divisors
            for (int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if (x % i == 0)
                {
                    cnt++;
                }
            }

            return (cnt == 2) && (x != 1);
        }
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            //user enters values and the program reads it
            string s = Console.ReadLine();
            //splits the inputs when sees the space
            string[] args = s.Split(' ');
            //checking every element f the massive 
            for (int i = 0; i < args.Length; i++)
            {
                if (!IsPrime(args[i]))
                {
                    Console.WriteLine(args[i] + " is not prime");
                }
                else
                {
                    Console.WriteLine(args[i] + " is prime");
                }
            }
            Console.ReadKey();
        }
    }
}