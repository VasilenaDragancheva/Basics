namespace Sunglasses
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            char ast = '*';
            char slash = '/';
            char ws = ' ';
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" {0}{1}  {0} ", new string(ast, 2 * n - 2), new string(ws, n - 1));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(
                    "*{0}*{1}*{0}*", 
                    new string(slash, 2 * n - 2), 
                    new string(i + 1 == n / 2 ? '-' : ws, n - 1));

                // if(i+1==n/2)
                // {
                // Console.WriteLine("*{0}*{1}*{0}*", new string(slash, 2 * n - 2), new string('|', n));
                // }
            }

            Console.WriteLine(" {0}{1}  {0} ", new string(ast, 2 * n - 2), new string(ws, n - 1));
        }
    }
}