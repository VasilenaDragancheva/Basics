namespace MorseCode
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int nSum = 0;
            bool isResult = false;
            string result;
            for (int i = 0; i < number.Length; i++)
            {
                nSum += int.Parse(number[i].ToString());
            }

            for (int i = 0; i <= 5; i++)
            {
                for (int m = 0; m <= 5; m++)
                {
                    for (int h = 0; h <= 5; h++)
                    {
                        for (int j = 0; j <= 5; j++)
                        {
                            for (int k = 0; k <= 5; k++)
                            {
                                for (int l = 0; l <= 5; l++)
                                {
                                    if (ProductCheck(i, m, h, j, k, l, nSum))
                                    {
                                        isResult = true;
                                        result = ConverToMorse(i, m, h, j, k, l);
                                        Console.WriteLine(result);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (isResult == false)
            {
                Console.WriteLine("No");
            }
        }

        static bool ProductCheck(int i, int m, int h, int j, int k, int l, int nSum)
        {
            bool equal = false;
            if (i * m * h * j * k * l == nSum)
            {
                equal = true;
            }

            return equal;
        }

        static string ConverToMorse(int i, int m, int h, int j, int k, int l)
        {
            string I = null;
            string M = null;
            string H = null;
            string J = null;
            string K = null;
            string L = null;
            switch (i)
            {
                case 0:
                    I = "-----|";
                    break;
                case 1:
                    I = ".----|";
                    break;
                case 2:
                    I = "..---|";
                    break;
                case 3:
                    I = "...--|";
                    break;
                case 4:
                    I = "....-|";
                    break;
                case 5:
                    I = ".....|";
                    break;
            }

            switch (m)
            {
                case 0:
                    M = "-----|";
                    break;
                case 1:
                    M = ".----|";
                    break;
                case 2:
                    M = "..---|";
                    break;
                case 3:
                    M = "...--|";
                    break;
                case 4:
                    M = "....-|";
                    break;
                case 5:
                    M = ".....|";
                    break;
            }

            switch (j)
            {
                case 0:
                    J = "-----|";
                    break;
                case 1:
                    J = ".----|";
                    break;
                case 2:
                    J = "..---|";
                    break;
                case 3:
                    J = "...--|";
                    break;
                case 4:
                    J = "....-|";
                    break;
                case 5:
                    J = ".....|";
                    break;
            }

            switch (h)
            {
                case 0:
                    H = "-----|";
                    break;
                case 1:
                    H = ".----|";
                    break;
                case 2:
                    H = "..---|";
                    break;
                case 3:
                    H = "...--|";
                    break;
                case 4:
                    H = "....-|";
                    break;
                case 5:
                    H = ".....|";
                    break;
            }

            switch (k)
            {
                case 0:
                    K = "-----|";
                    break;
                case 1:
                    K = ".----|";
                    break;
                case 2:
                    K = "..---|";
                    break;
                case 3:
                    K = "...--|";
                    break;
                case 4:
                    K = "....-|";
                    break;
                case 5:
                    K = ".....|";
                    break;
            }

            switch (l)
            {
                case 0:
                    L = "-----|";
                    break;
                case 1:
                    L = ".----|";
                    break;
                case 2:
                    L = "..---|";
                    break;
                case 3:
                    L = "...--|";
                    break;
                case 4:
                    L = "....-|";
                    break;
                case 5:
                    L = ".....|";
                    break;
            }

            string morseResult = I + M + H + J + K + L;
            return morseResult;
        }
    }
}