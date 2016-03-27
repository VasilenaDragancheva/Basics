namespace JumpingSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int j = int.Parse(Console.ReadLine());
            int[] numbers = new int[input.Length];
            int[] sums = new int[numbers.Length];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sums[i] = numbers[i];
                int index = i;
                int times = 0;
                while (times < j)
                {
                    index = (index + numbers[index]) % numbers.Length;

                    sums[i] += numbers[index];
                    times++;
                }
            }

            int maxSUm = sums.Max();
            Console.WriteLine("max sum = {0}", maxSUm);
        }
    }
}