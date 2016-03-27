namespace TextBordament
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int c = int.Parse(Console.ReadLine()); // number of columns
            string[] bombs = Console.ReadLine().Split(' ');

            // drawing matrix;
            int r = (int)Math.Ceiling(text.Length / (decimal)c); // number of rows
            char[,] matrix = new char[r, c];
            char[,] result = new char[r, c];
            int index = 0;
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    char curChar = ' ';
                    if (index < text.Length)
                    {
                        curChar = text[index];
                    }

                    matrix[row, col] = curChar;
                    result[row, col] = curChar;
                    index++;
                }
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                int col = int.Parse(bombs[i]);
                int row = 0;

                while (row < r)
                {
                    char currentChar = matrix[row, col];
                    bool currentEmpty = matrix[row, col] == ' ';
                    bool previousNotEmpty = row - 1 >= 0 && matrix[row - 1, col] != ' ';
                    result[row, col] = ' ';

                    if (currentEmpty && previousNotEmpty)
                    {
                        break;
                    }

                    row++;
                }
            }

            index = 0;
            StringBuilder final = new StringBuilder();
            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    final.Append(result[row, col]);
                    index++;
                    if (index == text.Length)
                    {
                        Console.WriteLine(final.ToString());
                    }
                }
            }
        }
    }
}