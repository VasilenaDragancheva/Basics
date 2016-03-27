namespace HouseWithWindow
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            char dot = '.';
            char ast = '*';
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string(dot, n - 1));
            int dotsBefore = n - 2;
            int dotsMiddle = 1;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string(dot, dotsBefore), new string(dot, dotsMiddle));
                dotsBefore--;
                dotsMiddle += 2;
            }

            Console.WriteLine("{0}", new string(ast, 2 * n - 1));
            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string(dot, 2 * n - 3));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string(dot, n / 2), new string(ast, n - 3));
            }

            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string(dot, 2 * n - 3));
            }

            Console.WriteLine(new string(ast, 2 * n - 1));
        }
    }
}