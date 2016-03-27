namespace BitwiseOperators
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(numbers[i], 2);
                int numChanged = 0;
                int numReversed = 0;
                for (int p = binary.Length - 1; p >= 0; p--)
                {
                    int currentBit = (numbers[i] >> p) & 1;
                    numChanged |= (currentBit ^ 1) << p;
                    numReversed |= currentBit << (binary.Length - 1 - p);
                }

                numbers[i] = (numbers[i] ^ numChanged) & numReversed;
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}