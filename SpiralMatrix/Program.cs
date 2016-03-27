namespace SpiralMatrix
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] keyword = Console.ReadLine().ToLower().ToCharArray();
            char[,] matrix = new char[n, n]; // matrix[row,col]

            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 0; i < n * n; i++)
            {
                if (direction == "right" && (col >= n || matrix[row, col] != '\0'))
                {
                    direction = "down";
                    row++;
                    col--;
                }

                if (direction == "down" && (row >= n || matrix[row, col] != '\0'))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != '\0'))
                {
                    direction = "up";
                    row--;
                    col++;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != '\0'))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = keyword[i % keyword.Length];

                switch (direction)
                {
                    case "right":
                        col++;
                        break;
                    case "down":
                        row++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "up":
                        row--;
                        break;
                }
            }

            int maxWeight = int.MinValue;
            int index = 0;
            for (int r = 0; r < n; r++)
            {
                int curWeght = 0;
                for (int c = 0; c < n; c++)
                {
                    curWeght += (-'a' + matrix[r, c] + 1) * 10;
                }

                if (curWeght > maxWeight)
                {
                    maxWeight = curWeght;
                    index = r;
                }
            }

            Console.WriteLine("{0} - {1}", index, maxWeight);
        }
    }
}