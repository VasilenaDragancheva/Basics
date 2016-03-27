namespace CalculationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int totalSum = 0;
            foreach (var s in input)
            {
                int powIndex = s.Length - 1;
                for (int i = 0; i < s.Length; i++)
                {
                    totalSum += (int)Math.Pow(23, powIndex) * (s[i] - 'a');
                    powIndex--;
                }
            }

            int number = totalSum;
            List<int> remainders = new List<int>();

            while (number > 0)
            {
                int currentRemainder = number % 23;
                remainders.Add(currentRemainder);
                number /= 23;
            }

            var chars = remainders.Select(x => (char)(x + 'a')).ToArray();
            Array.Reverse(chars);
            Console.WriteLine("{0} = {1}", new string(chars), totalSum);
        }
    }
}