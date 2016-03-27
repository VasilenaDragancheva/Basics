namespace DrawFigure
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string asterix = "*";
            string dot = ".";

            for (int i = 1; i <= n; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();
            for (int i = 1; i <= n / 2; i++)
            {
                for (int m = 1; m <= i; m++)
                {
                    Console.Write(dot);
                }

                for (int m = n - 2 * i; m >= 1; m--)
                {
                    Console.Write(asterix);
                }

                for (int m = 1; m <= i; m++)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n / 2 - 1; i++)
            {
                for (int m = n / 2 - i; m >= 1; m--)
                {
                    Console.Write(dot);
                }

                for (int m = 0; m <= 2 * i; m++)
                {
                    Console.Write(asterix);
                }

                for (int m = n / 2 - i; m >= 1; m--)
                {
                    Console.Write(dot);
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();
        }
    }
}