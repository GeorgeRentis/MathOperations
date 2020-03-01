using System;

namespace MathOperations
{
    class Operations
    {
        public void CalculateDigitSum()
        {
            Console.WriteLine("Please enter a number to check it's digit sum");

            int digitsum = 0;
            int number = int.Parse(Console.ReadLine());

            // NOT accounted numbers lower than 10.
            while (number > 10)
            {
                digitsum += (number % 10);
                number /= 10;

                if (number < 10)
                {
                    digitsum += number;
                }
            }

            Console.WriteLine("The sum of digits is: " + digitsum);
        }
        public void CalculateFactorial()
        {
            Console.WriteLine("Please enter a number to check it's factorial");

            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {

                factorial *= i;
            }

            Console.WriteLine("The Factorial of " + number + " is: " + factorial);
        }
        public void IsPrime()
        {
            Console.WriteLine("Please enter a number to check whether is Prime or not");
            int number = int.Parse(Console.ReadLine());

            int Dividers = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Dividers++;
                }
            }

            if (Dividers > 2)
            {
                Console.WriteLine("The number " + number + " is not a Prime number");
            }
            else
            {
                Console.WriteLine("The number " + number + " is a Prime number");
            }
        }
    }
}
