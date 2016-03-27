namespace ChessBoard
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sumBlack = 0;
            int sumWhite = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i >= n * n)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    if (char.IsDigit(input[i]) || char.IsLower(input[i]))
                    {
                        sumBlack += input[i];
                    }

                    if (char.IsUpper(input[i]))
                    {
                        sumWhite += input[i];
                    }
                }

                if (i % 2 != 0)
                {
                    if (char.IsDigit(input[i]) || char.IsLower(input[i]))
                    {
                        sumWhite += input[i];
                    }

                    if (char.IsUpper(input[i]))
                    {
                        sumBlack += input[i];
                    }
                }
            }

            if (sumBlack == sumWhite)
            {
                Console.WriteLine("Equal result: {0}", sumWhite);
            }
            else if (sumBlack > sumWhite)
            {
                Console.WriteLine("The winner is: black team ");
                Console.WriteLine(sumBlack - sumWhite);
            }
            else
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(sumWhite - sumBlack);
            }
        }
    }
}