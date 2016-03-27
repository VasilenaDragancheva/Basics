namespace Arrow
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n / 2), new string('.', n - 2));
            }

            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', n - 2));
            int dotsBefore = 1;
            int dotsMiddle = 2 * n - 5;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore++;
                dotsMiddle -= 2;
            }

            Console.WriteLine("{0}#{0}", new string('.', n - 1));
        }
    }
}