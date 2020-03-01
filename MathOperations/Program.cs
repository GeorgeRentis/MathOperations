using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Users choice
            
            Operations operation = new Operations();
            Initializer();
            int _choice;
            _choice = int.Parse(Console.ReadLine());

            switch (_choice)
            {
                case 2:
                    operation.IsPrime();
                    break;
                case 4:
                    operation.CalculateDigitSum();
                    break;
                case 6:
                    operation.CalculateFactorial();
                    break;
            }

        }


        private static void Initializer()
        {
            // Select Mathematical Operation
            Console.WriteLine("Please select a number for your corresponding operation\n");
            Console.WriteLine("1.Fibbonacci Series");
            Console.WriteLine("2.Prime Numbers");//Done
            Console.WriteLine("3.Armstrong Number");
            Console.WriteLine("4.Digit Sum"); //Done
            Console.WriteLine("5.Palindrome Number");
            Console.WriteLine("6.Factorial"); //Done
            Console.WriteLine("7.Decimal to Binary");
        }
    }
}
