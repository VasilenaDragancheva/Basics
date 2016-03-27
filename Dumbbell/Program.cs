namespace Dumbbell
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ast = '*';
            char dot = '.';

            // start
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(dot, n / 2), new string('&', n / 2 + 1), new string(dot, n));
            int dotsBefore = n / 2 - 1;
            int asterix = n / 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}&{1}&{2}&{1}&{0}", 
                    new string(dot, dotsBefore), 
                    new string(ast, asterix), 
                    i == n / 2 - 1 ? new string('=', n) : new string(dot, n));
                dotsBefore--;
                asterix++;
            }

            dotsBefore = 1;
            asterix = n - 3;

            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(
                    "{0}&{1}&{2}&{1}&{0}", 
                    new string(dot, dotsBefore), 
                    new string(ast, asterix), 
                    new string(dot, n));
                dotsBefore++;
                asterix--;
            }

            // end
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(dot, n / 2), new string('&', n / 2 + 1), new string(dot, n));
        }
    }
}