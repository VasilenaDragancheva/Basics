namespace Disc
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            string asterix = "*";
            string dot = ".";

            int y0 = n / 2;
            int x0 = n / 2;
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    int deltaX = x - x0;
                    int deltaY = y - y0;
                    double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
                    if (distance <= r)
                    {
                        Console.Write(asterix);
                    }
                    else if (distance > r)
                    {
                        Console.Write(dot);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}