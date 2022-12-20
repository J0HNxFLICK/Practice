using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTest
{
    class placeInArray
    {
        public static void placer()
        {
            Console.WriteLine("Enter number of numbers you want to add : ");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int[] arrayStorage = new int[userValue];
            Console.WriteLine("An array storage has been created");
            for (int index = 0; index < userValue; index++)
            {
                arrayStorage[index] = Convert.ToInt32(Console.ReadLine());
            }
            //Console.WriteLine("These are all the elements that are being summed up : ");
            //for (int index=0; index < arrayStorage.Length; index++)
            //{
            //    Console.WriteLine(arrayStorage[index] + " ");
            //}
            int sum = 0;
            for (int index = 0; index < arrayStorage.Length; index++)
            {
                sum = sum + arrayStorage[index];
            }
            Console.WriteLine("This is the sum of all the elements in an array : " + sum);
        }
    }
}
