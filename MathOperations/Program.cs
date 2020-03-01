using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Users choice
            int _choice;
            // Select Mathematical Operation
            Console.WriteLine("Please select a number for your corresponding operation\n");
            Console.WriteLine("1.Fibbonacci Series");
            Console.WriteLine("2.Prime Numbers");
            Console.WriteLine("3.Armstrong Number");
            Console.WriteLine("4.Digit Sum");
            Console.WriteLine("5.Palindrome Number");

            _choice = int.Parse(Console.ReadLine());

            int dividers;

            if (_choice == 2)
            {
                Prime number = new Prime();
                Console.WriteLine("Please enter a number to check whether is Prime or not");
                int _number = int.Parse(Console.ReadLine());
                number.IsPrime(_number);
            }
        }
    }
}
