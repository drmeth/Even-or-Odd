using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Number: ");
            string myNumValue = Console.ReadLine();
            int myNum = Convert.ToInt32(myNumValue);

            if (myNum % 2 == 0)
            {
                Console.WriteLine("This Number is even!");
            }
            if (myNum % 2 == 1)
            {
                Console.WriteLine("This Number is odd!");
            }

            //keep window open
            Console.ReadLine();
        }
    }
}
