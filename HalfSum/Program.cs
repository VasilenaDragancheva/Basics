namespace HalfSum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long sumFirst = 0;
            long sumSecond = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    sumFirst += num;
                }
                else if (i >= n)
                {
                    sumSecond += num;
                }
            }

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Yes, sum={0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sumFirst - sumSecond));
            }
        }
    }
}