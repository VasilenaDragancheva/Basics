namespace OddEvenSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long odd = 0;
            long even = 0;
            for (int i = 1; i <= 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                bool odds = i % 2 == 1;
                if (odds)
                {
                    odd += num;
                }
                else
                {
                    even += num;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes, sum={0}", even);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(odd - even));
            }
        }
    }
}