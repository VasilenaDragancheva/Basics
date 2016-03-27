namespace OddEvenElements
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');
            decimal minEven = decimal.MaxValue;
            decimal maxEven = decimal.MinValue;
            decimal minOdd = decimal.MaxValue;
            decimal maxOdd = decimal.MinValue;
            decimal sumEven = 0;
            decimal sumOdd = 0;
            if (input == string.Empty)
            {
                numbers = new string[0];
            }

            if (numbers.Length == 1)
            {
                decimal number = decimal.Parse(numbers[0]);

                Console.WriteLine(
                    "OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={1}, EvenMin={1}, EvenMax={1}", 
                    (double)number, 
                    "No");
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={1}, EvenMin={1}, EvenMax={1}", 
                    "No", 
                    "No");
            }

            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    decimal number = decimal.Parse(numbers[i]);
                    bool odd = i % 2 == 0;
                    if (odd)
                    {
                        sumOdd += number;
                        minOdd = Math.Min(minOdd, number);
                        maxOdd = Math.Max(maxOdd, number);
                    }

                    if (!odd)
                    {
                        sumEven += number;
                        minEven = Math.Min(minEven, number);
                        maxEven = Math.Max(maxEven, number);
                    }
                }

                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", 
                    (double)sumOdd, 
                    (double)minOdd, 
                    (double)maxOdd, 
                    (double)sumEven, 
                    (double)minEven, 
                    (double)maxEven);
            }
        }
    }
}