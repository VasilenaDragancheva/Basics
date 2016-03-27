namespace PaintBall
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] canvas = new int[10];
            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i] = 1023;
            }

            string command = Console.ReadLine();
            bool White = false;
            while (command != "End")
            {
                int row = int.Parse(command.Split(' ')[0]);
                int col = int.Parse(command.Split(' ')[1]);
                int rad = int.Parse(command.Split(' ')[2]);
                Shoot(canvas, row, col, rad, White);
                White = !White;
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                int sum = 0;
                for (int i = 0; i < canvas.Length; i++)
                {
                    sum += canvas[i];
                }

                Console.WriteLine(sum.ToString());
            }
        }

        static void Shoot(int[] canvas, int row, int col, int rad, bool White)
        {
            int maxRow = Math.Min(row + rad, 9);
            int minRow = Math.Max(row - rad, 0);
            int maxCol = Math.Min(col + rad, 9);
            int minCol = Math.Max(col - rad, 0);
            int mask = (1 << (maxCol - minCol + 1)) - 1;

            for (int r = minRow; r <= maxRow; r++)
            {
                if (!White)
                {
                    canvas[r] &= ~(mask << minCol);
                }

                if (White)
                {
                    canvas[r] |= mask << minCol;
                }
            }
        }
    }
}