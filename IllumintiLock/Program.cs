namespace IllumintiLock
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char dz = '#';
            string final = string.Format("{0}{1}{0}", new string(dot, n), new string(dz, n));
            Console.WriteLine(final);
            int dotsEnd = n - 2;
            int dotsBefore = 0;
            int dotsMiddle = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}##{1}#{2}#{1}##{0}", 
                    new string(dot, dotsEnd), 
                    new string(dot, dotsBefore), 
                    new string(dot, dotsMiddle));
                dotsEnd -= 2;
                dotsBefore += 2;
            }

            dotsEnd = 1;
            dotsBefore = n - 3;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(
                    "{0}##{1}#{2}#{1}##{0}", 
                    new string(dot, dotsEnd), 
                    new string(dot, dotsBefore), 
                    new string(dot, dotsMiddle));
                dotsEnd += 2;
                dotsBefore -= 2;
            }

            Console.WriteLine(final);
        }
    }
}