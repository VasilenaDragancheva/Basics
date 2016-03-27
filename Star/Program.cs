namespace Star
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}", new string('.', n));
            int DotsBefore = n - 1;
            int dotsMiddle = 1;
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', DotsBefore), new string('.', dotsMiddle));
                dotsMiddle += 2;
                DotsBefore--;
            }

            Console.WriteLine("{0}{1}{0}", new string('*', (n / 2) + 1), new string('.', n - 1));

            DotsBefore = 1;
            dotsMiddle = 2 * n - 3;
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', DotsBefore), new string('.', dotsMiddle));
                DotsBefore++;
                dotsMiddle -= 2;
            }

            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n / 2), new string('.', n / 2 - 1));
            DotsBefore = n / 2 - 1;
            dotsMiddle = 1;

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{2}*{1}*{0}", 
                    new string('.', DotsBefore), 
                    new string('.', n / 2 - 1), 
                    new string('.', dotsMiddle));
                DotsBefore--;
                dotsMiddle += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', n - 1));
        }
    }
}