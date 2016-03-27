namespace RockLq
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string asterix = "*";
            string dot = ".";

            // qka
            for (int i = 0; i < n; i++)
            {
                Console.Write(dot);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(asterix);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(dot);
            }

            Console.WriteLine();

            // dekolte
            int dotsBefore = n - 2;
            int dotsMiddle = n + 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore -= 2;
                dotsMiddle += 4;
            }

            // sleeves
            int dotsSleeves = n - 2;
            int dotsChest = n;
            int freeDOts = 1;
            Console.WriteLine("*{0}*{1}*{0}*", new string('.', dotsSleeves), new string('.', dotsChest));
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                dotsSleeves -= 2;
                Console.WriteLine(
                    "*{0}*{1}*{2}*{1}*{0}*", 
                    new string('.', dotsSleeves), 
                    new string('.', freeDOts), 
                    new string('.', dotsChest));
                freeDOts += 2;
            }

            // skirt
            dotsBefore = n - 1;
            dotsMiddle = n;
            for (int i = 0; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
                dotsBefore--;
                dotsMiddle += 2;
            }

            for (int i = 0; i < 3 * n; i++)
            {
                Console.Write(asterix);
            }

            Console.WriteLine();
        }
    }
}