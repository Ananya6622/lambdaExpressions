using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    class WithoutLambda1
    {
        static List<int> CalculateSquares(List<int> numbers)
        {
            List<int> squares = new List<int>();
            foreach (var value in numbers)
            {
                squares.Add(value * value);
            }
            return squares;
        }

        static List<int> FindDivisibleBy3(List<int> numbers)
        {
            List<int> divBy3 = new List<int>();
            foreach (var value in numbers)
            {
                if (value % 3 == 0)
                {
                    divBy3.Add(value);
                }
            }
            return divBy3;
        }

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            List<int> squares = CalculateSquares(numbers);

            Console.Write("Squares : ");
            foreach (var value in squares)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            List<int> divBy3 = FindDivisibleBy3(numbers);

            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }
    }
}
