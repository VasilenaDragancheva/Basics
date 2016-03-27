namespace EncryptedMatrix
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            char direction = char.Parse(Console.ReadLine());
            int[] firstNumber = new int[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                firstNumber[i] = message[i] % 10;
            }

            int[] secondNumber = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                bool isEven = firstNumber[i] % 2 == 0;
                if (isEven)
                {
                    secondNumber[i] = firstNumber[i] * firstNumber[i];
                }
                else
                {
                    bool existPrevios = i - 1 >= 0;
                    bool existNext = i + 1 < secondNumber.Length;
                    secondNumber[i] = firstNumber[i] + (existPrevios ? firstNumber[i - 1] : 0)
                                      + (existNext ? firstNumber[i + 1] : 0);
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (int number in secondNumber)
            {
                result.Append(number.ToString());
            }

            int n = result.ToString().Length;
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            if (direction == '/')
            {
                row = n - 1;

                for (int i = 0; i < n; i++)
                {
                    matrix[row, col] = int.Parse(result.ToString()[i].ToString());
                    row--;
                    col++;
                }
            }

            if (direction == '\\')
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[row, col] = int.Parse(result.ToString()[i].ToString());
                    row++;
                    col++;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0} ", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}