namespace BitsAtCrossroad
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong[] board = new ulong[n];

            int countCrossroads = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                int row = int.Parse(command.Split(' ')[0]);
                int p = int.Parse(command.Split(' ')[1]);
                countCrossroads++;
                if ((board[row] >> p & 1) == 1)
                {
                    countCrossroads++;
                }

                board[row] |= 1ul << p;

                // up left;
                int nextRow = row - 1;
                int nextP = p + 1;
                while (nextRow >= 0 && nextP < n)
                {
                    if (((board[nextRow] >> nextP) & 1) == 1)
                    {
                        countCrossroads++;
                    }

                    board[nextRow] |= 1ul << nextP;

                    nextRow--;
                    nextP++;
                }

                // up right
                nextRow = row - 1;
                nextP = p - 1;
                while (nextP >= 0 && nextRow >= 0)
                {
                    if (((board[nextRow] >> nextP) & 1) == 1)
                    {
                        countCrossroads++;
                    }

                    board[nextRow] |= 1ul << nextP;

                    nextRow--;
                    nextP--;
                }

                // downleft
                nextRow = row + 1;
                nextP = p + 1;
                while (nextP < n && nextRow < n)
                {
                    if (((board[nextRow] >> nextP) & 1) == 1)
                    {
                        countCrossroads++;
                    }

                    board[nextRow] |= 1ul << nextP;

                    nextRow++;
                    nextP++;
                }

                // downright
                nextRow = row + 1;
                nextP = p - 1;
                while (nextP >= 0 && nextRow < n)
                {
                    if (((board[nextRow] >> nextP) & 1) == 1)
                    {
                        countCrossroads++;
                    }

                    board[nextRow] |= 1ul << nextP;

                    nextRow++;
                    nextP--;
                }
            }

            foreach (ulong num in board)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(countCrossroads);
        }

        private static void DrawDiagonal(int[] board, int nextRow, int nextP, int countCrossroads)
        {
            if (board[nextRow] >> nextP == 1)
            {
                countCrossroads++;
            }
            else
            {
                board[nextRow] |= 1 << nextP;
            }
        }
    }
}