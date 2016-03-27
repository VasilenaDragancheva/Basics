namespace Pairs
{
    using System;

    class Pirs
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int sum = 0;
            bool equalSum = true;
            int maxDif = int.MinValue;

            if (input.Length > 2)
            {
                for (int i = 0; i + 3 < input.Length; i += 2)
                {
                    int sum1 = int.Parse(input[i]) + int.Parse(input[i + 1]);
                    int sum2 = int.Parse(input[i + 2]) + int.Parse(input[i + 3]);
                    if (sum1 == sum2)
                    {
                        equalSum = true;
                        sum = sum1 = sum2;
                    }

                    if (sum1 != sum2)
                    {
                        equalSum = false;
                        maxDif = Math.Max(maxDif, Math.Max(sum1, sum2) - Math.Min(sum1, sum2));
                    }
                }

                if (equalSum)
                {
                    Console.WriteLine("Yes, value={0}", sum);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", maxDif);
                }
            }

            if (input.Length == 2)
            {
                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);
                if (num1 == num2)
                {
                    Console.WriteLine("Yes, value={0}", num1 + num2);
                }
                else
                {
                    Console.WriteLine("No, maxdiff={0}", Math.Max(num1, num2) - Math.Min(num1, num2));
                }
            }
        }
    }
}