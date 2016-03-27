namespace FunWithMatrices
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int n = 4;
            double[,] matrix = new double[n, n];
            double start = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            int index = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = start + index * step;
                    index++;
                }
            }

            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "Game Over!")
                {
                    break;
                }

                int row = int.Parse(command.Split(' ')[0]);
                int col = int.Parse(command.Split(' ')[1]);
                double num = double.Parse(command.Split(' ')[3]);
                string action = command.Split(' ')[2];
                switch (action)
                {
                    case "multiply":
                        matrix[row, col] *= num;
                        break;
                    case "power":
                        matrix[row, col] = Math.Pow(matrix[row, col], num);
                        break;
                    case "sum":
                        matrix[row, col] += num;
                        break;
                }
            }

            Dictionary<string, double> result = new Dictionary<string, double>();
            for (int r = 0; r < n; r++)
            {
                double sum = 0;
                for (int c = 0; c < n; c++)
                {
                    sum += matrix[r, c];
                }

                string key = "ROW[" + r + "]";
                result[key] = sum;
            }

            for (int c = 0; c < n; c++)
            {
                double sum = 0;
                for (int r = 0; r < n; r++)
                {
                    sum += matrix[r, c];
                }

                string key = "COLUMN[" + c + "]";
                result[key] = sum;
            }

            int ro = 0;
            int co = 0;
            double sumDIagonals = 0;
            while (ro < n && co < n)
            {
                sumDIagonals += matrix[ro, co];
                ro++;
                co++;
            }

            result["LEFT-DIAGONAL"] = sumDIagonals;
            sumDIagonals = 0;
            ro = 0;
            co = 3;
            while (ro < n && co >= 0)
            {
                sumDIagonals += matrix[ro, co];
                ro++;
                co--;
            }

            result["RIGHT-DIAGONAL"] = sumDIagonals;

            double maxSum = double.MinValue;
            foreach (var pair in result)
            {
                if (pair.Value > maxSum)
                {
                    maxSum = pair.Value;
                }
            }

            foreach (KeyValuePair<string, double> pair in result)
            {
                if (pair.Value == maxSum)
                {
                    Console.WriteLine("{0} = {1:F2}", pair.Key, pair.Value);
                    break;
                }
            }
        }
    }
}