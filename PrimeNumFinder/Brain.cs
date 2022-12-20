using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumFinder
{
    internal class Brain
    {
        public static void PrimeFinder()
        {
            Console.WriteLine("Enter the number :");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= userInput; i++)
            {
                if(userInput % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(userInput + " is a prime number.");
            }

            else
            {
                Console.WriteLine(userInput + " is not a prime number.");
            }

        }

        public static void PrimeFinderRanged() 
        {
            Console.WriteLine("Enter thr range :");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers in the range of {0} are : ", userInput);
            int tracker = 0;

            for (int i = 1; i <= userInput; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(i + " ");
                    tracker++;
                }

            }

            Console.WriteLine("\n{0} prime value(s) in the range of {1}!", tracker , userInput);
        }
    }
}
