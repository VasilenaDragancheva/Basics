namespace MagicSwan
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}", new string('.', n + n / 2 + 1));
            int dotsBefore = n + n / 2;
            
            int dotsMiddle = 1;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore--;
                dotsMiddle += 2;
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
            dotsBefore = 1;
            dotsMiddle = 3 * n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore++;
                dotsMiddle -= 2;
            }

            dotsBefore = n / 2 - 1;
            dotsMiddle = n / 2;
            int dotsIn = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{2}*{3}*{2}*{1}*{0}", 
                    new string('.', dotsBefore), 
                    new string('.', dotsMiddle), 
                    new string('.', dotsIn), 
                    new string('.', n));
                dotsBefore--;
                dotsIn++;
            }

            Console.WriteLine(
                "{0}{1}*{2}*{1}{0}", 
                new string('*', n / 2 + 1), 
                new string('.', dotsIn), 
                new string('.', n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }

            Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('*', n));
        }
    }
}