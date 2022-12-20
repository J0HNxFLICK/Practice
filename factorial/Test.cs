using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Test
    {
        public static void factorialTest()
        {
            Console.WriteLine("Enter the number you want factorial for : ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = userInput; i > 0; i--)
            {
                factorial *= i ;
            }
            Console.WriteLine("The factorial of {0} is : {1}",userInput, factorial);
        }
    }
}
