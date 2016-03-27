namespace BiggestTriple
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int leftNumbers = numbers.Length % 3;

            int maxSum = int.MinValue;
            int maxIndex = 0;
            int curSum = 0;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                curSum += numbers[i];
                counter++;
                if (counter == 3)
                {
                    if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        maxIndex = i - 3 + 1;
                    }

                    curSum = 0;
                    counter = 0;
                }
            }

            if (counter > 0)
            {
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    maxIndex = numbers.Length - counter;
                }
            }

            for (int i = maxIndex; i < Math.Min(maxIndex + 3, numbers.Length); i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}