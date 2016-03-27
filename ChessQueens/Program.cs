namespace ChessQueens
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            distance += 1;
            bool noPosition = false;
            char limitLetter = (char)('a' + n);
            char startLetter = 'a';

            for (int x1 = 1; x1 <= n; x1++)
            {
                for (int y1 = startLetter; y1 < limitLetter; y1++)
                {
                    for (int x2 = 1; x2 <= n; x2++)
                    {
                        for (int y2 = startLetter; y2 < limitLetter; y2++)
                        {
                            bool horizontal = x1 == x2 && Math.Abs(y1 - y2) == distance;
                            bool vertical = y1 == y2 && Math.Abs(x1 - x2) == distance;
                            bool diagnal = Math.Abs(y1 - y2) == distance && Math.Abs(x1 - x2) == distance;

                            if (horizontal || vertical || diagnal)
                            {
                                noPosition = true;
                                Console.WriteLine("{0}{1} - {2}{3}", (char)y1, x1, (char)y2, x2);
                            }
                        }
                    }
                }
            }

            if (!noPosition)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}