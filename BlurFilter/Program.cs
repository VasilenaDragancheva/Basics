namespace BlurFilter
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int[] dimenisons =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = dimenisons[0];
            int cols = dimenisons[1];
            BigInteger[,] matrix = new BigInteger[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                BigInteger[] line =
                    Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(BigInteger.Parse)
                        .ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            int[] blurCoord =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int row = blurCoord[0];
            int col = blurCoord[1];
            int startRow = Math.Max(row - 1, 0);
            int endRow = Math.Min(row + 1, rows - 1);
            int startCol = Math.Max(col - 1, 0);
            int endCol = Math.Min(col + 1, cols - 1);

            for (int r = startRow; r <= endRow; r++)
            {
                for (int c = startCol; c <= endCol; c++)
                {
                    matrix[r, c] += amount;
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}