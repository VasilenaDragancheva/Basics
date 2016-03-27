namespace Plane
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}*{0}", new string('.', n + n / 2));

            // body
            int dotsBefore = n + n / 2 - 1;
            int dotsMiddle = 1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore--;
                dotsMiddle += 2;
            }

            dotsBefore = n;
            dotsMiddle = n + 2;

            for (int i = 0; i < n / 2; i++)
            {
                dotsBefore -= 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));

                dotsMiddle += 4;
            }

            // wings 
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));
            dotsBefore = 1;
            int dotsWings = n - 4;
            dotsMiddle = n;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(
                    "*{0}*{1}*{2}*{1}*{0}*", 
                    new string('.', dotsWings), 
                    new string('.', dotsBefore), 
                    new string('.', dotsMiddle));
                dotsWings -= 2;
                dotsBefore += 2;
            }

            // tail
            dotsBefore = n - 1;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore--;
                dotsMiddle += 2;
            }

            Console.WriteLine(new string('*', 3 * n));
        }
    }
}