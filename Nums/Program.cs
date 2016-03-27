namespace Nums
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int fisrtNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result = 0;
            for (int i = fisrtNum; i <= secondNum; i++)
            {
                bool isOdd = i % 2 == 1;
                if (isOdd)
                {
                    result = Math.Pow(i, 2);
                }
                else
                {
                    result = Math.Sqrt(i);
                }

                Console.WriteLine("{0:F3}", result);
            }
        }
    }
}