using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    class Prime
    {

        public void IsPrime(int number)
        {
            int Dividers = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i ==0)
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
                Console.WriteLine("The number " + number + "is a Prime number");
            }
        }
    }
}
