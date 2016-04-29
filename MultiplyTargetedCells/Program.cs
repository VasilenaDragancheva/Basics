namespace MultiplyTargetedCells
{
    using System;
    using System.Linq;

    public class Program
    {
        public static int[,] matrix;

        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new int[dimensions[0], dimensions[1]];

            for (int r = 0; r < dimensions[0]; r++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int c = 0; c < dimensions[1]; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }

            int[] target = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = target[0];
            int col = target[1];

            int startRow = Math.Max(row - 1, 0);
            int startCol = Math.Max(col - 1, 0);
            int endRow = Math.Min(row + 1, dimensions[0] - 1);
            int endCol = Math.Max(col + 1, dimensions[1] - 1);

            int sum = 0;

            for (int r = startRow; r <= endRow; r++)
            {
                for (int c = startCol; c <= endCol; c++)
                {
                    if (r == row && c == col)
                    {
                        continue;
                    }

                    sum += matrix[r, c];
                }
            }

            for (int r = startRow; r <= endRow; r++)
            {
                for (int c = startCol; c <= endCol; c++)
                {
                    matrix[row, col] *= sum;
                }
            }

            Render();
        }

        private static void Render()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j != matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}