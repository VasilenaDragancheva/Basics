namespace KingOF
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());

            for (int i = 1; i <= (n / 2) + 1; i++)
            {
                for (int j = 1; j <= (n / 2) + 1 - i; j++)
                {
                    Console.Write('-');
                }

                for (int j = 0; j <= 2 * i - 2; j++)
                {
                    Console.Write(type);
                }

                for (int j = 1; j <= (n / 2) + 1 - i; j++)
                {
                    Console.Write('-');
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= (n / 2); i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('-');
                }

                for (int j = n - 2 * i; j >= 1; j--)
                {
                    Console.Write(type);
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write('-');
                }

                Console.WriteLine();
            }
        }
    }
}