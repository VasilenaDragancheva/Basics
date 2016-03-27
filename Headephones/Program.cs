namespace Headephones
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), new string('*', n + 2));
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', n / 2), new string('-', n));
            }

            int slashBefore = n / 2;
            int astrerix = 1;
            int slashMiddle = n;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{1}{0}", 
                    new string('-', slashBefore), 
                    new string('*', astrerix), 
                    new string('-', slashMiddle));
                slashBefore--;
                slashMiddle -= 2;
                astrerix += 2;
            }

            slashBefore = 1;
            astrerix = n - 2;
            slashMiddle = 3;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{1}{0}", 
                    new string('-', slashBefore), 
                    new string('*', astrerix), 
                    new string('-', slashMiddle));
                slashBefore++;
                slashMiddle += 2;
                astrerix -= 2;
            }
        }
    }
}