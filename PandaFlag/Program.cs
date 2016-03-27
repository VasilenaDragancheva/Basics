namespace PandaFlag
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char start = 'A';
            char vulna = '~';
            char dies = '#';

            int countVylna = 0;
            int countDies = n - 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{0}", 
                    new string(vulna, countVylna), 
                    start, 
                    new string(dies, countDies), 
                    start == 'Z' ? start = 'A' : start = ++start);
                countVylna++;
                countDies -= 2;
                if (start == 'Z')
                {
                    start = 'A';
                }
                else
                {
                    start++;
                }
            }

            // middle part
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2), start);
            if (start == 'Z')
            {
                start = 'A';
            }
            else
            {
                start++;
            }

            // second down
            countDies = 1;
            countVylna = (n - 3) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}{1}{2}{3}{0}", 
                    new string(vulna, countVylna), 
                    start, 
                    new string(dies, countDies), 
                    start == 'Z' ? start = 'A' : start = ++start);
                countVylna--;
                countDies += 2;
                if (start == 'Z')
                {
                    start = 'A';
                }
                else
                {
                    start++;
                }
            }
        }
    }
}