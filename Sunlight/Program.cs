namespace Sunlight
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('.', n + n / 2));

            int dotsBefore = 1;
            int dotMiddle = n + n / 2 - 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsBefore), new string('.', dotMiddle));
                dotsBefore++;
                dotMiddle--;
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            Console.WriteLine(new string('*', 3 * n));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }

            dotsBefore = n - 1;
            dotMiddle = n / 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsBefore), new string('.', dotMiddle));
                dotsBefore--;
                dotMiddle++;
            }

            Console.WriteLine("{0}*{0}", new string('.', n + n / 2));
        }
    }
}