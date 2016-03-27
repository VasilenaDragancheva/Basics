namespace KnigthPath
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] board = new int[8];

            int row = 0;
            int position = 0;
            board[0] = 1;

            int nextPos = 0;
            int nextRow = 0;
            string command;

            while (true)
            {
                command = Console.ReadLine().ToLower();
                if (command == "stop")
                {
                    break;
                }

                string first = command.Split(' ')[0];
                string second = command.Split(' ')[1];
                switch (first)
                {
                    case "left":
                        nextPos = position + 2;
                        break;
                    case "right":
                        nextPos = position - 2;
                        break;
                    case "up":
                        nextRow = row - 2;
                        break;
                    case "down":
                        nextRow = row + 2;
                        break;
                }

                switch (second)
                {
                    case "left":
                        nextPos = position + 1;
                        break;
                    case "right":
                        nextPos = position - 1;
                        break;
                    case "up":
                        nextRow = row - 1;
                        break;
                    case "down":
                        nextRow = row + 1;
                        break;
                }

                bool outBoard = nextRow >= 8 || nextRow < 0 || nextPos >= 8 || nextPos < 0;
                if (!outBoard)
                {
                    row = nextRow;
                    position = nextPos;
                    board[row] = board[row] ^ (1 << position);
                }
            }

            bool onlyZeros = true;
            foreach (int number in board)
            {
                if (number != 0)
                {
                    onlyZeros = false;
                    Console.WriteLine(number);
                }
            }

            if (onlyZeros)
            {
                Console.WriteLine("[Board is empty]");
            }
        }
    }
}