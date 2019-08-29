using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool isPrime(int number)
        {
            if (number < 2) return false;
            else
            {
                int i = 2;
                while (i <= number / 2)
                {
                    if (number % i == 0) return false;
                    i++;
                }
                return true;
            }

        }
            
        static void Main(string[] args)
        {
            int number = 11;
            Console.WriteLine(isPrime(number));
            Console.ReadKey();
        }
    }
}
