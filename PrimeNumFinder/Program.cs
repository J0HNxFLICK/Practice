namespace PrimeNumFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRIME NUMBER FINDER");
            Console.WriteLine("Enter 1 to find a given number is a prime or not.");
            Console.WriteLine("Enter 2 to find all the prime numbers in the range of a given number");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1) 
            {
                Brain.PrimeFinder();
            }

            else if (userChoice== 2) 
            {
                Brain.PrimeFinderRanged();
            }

            else
            {
                Console.WriteLine("Invalid choice run again.");
            }
            
        }
    }
}