namespace DoubleDowns
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int rightCouples = 0;
            int leftCouples = 0;
            int verticalCouples = 0;

            for (int i = 0; i < n - 1; i++)
            {
                verticalCouples += CountVertical(numbers[i], numbers[i + 1]);
                rightCouples += LeftDiagonal(numbers[i], numbers[i + 1]);
                leftCouples += RightDiagonal(numbers[i], numbers[i + 1]);
            }

            Console.WriteLine(rightCouples);
            Console.WriteLine(leftCouples);
            Console.WriteLine(verticalCouples);
        }

        static int CountVertical(int number, int nextNumber)
        {
            int verticalCouples = 0;
            int numberToCheck = number & nextNumber;
            int p = 0;
            while (p < 32)
            {
                if (((numberToCheck >> p) & 1) == 1)
                {
                    verticalCouples++;
                }

                p++;
            }

            return verticalCouples;
        }

        static int LeftDiagonal(int number, int nextNumber)
        {
            int leftCouples = new int();
            int numberToCheck = number ^ nextNumber;
            int p = 0;
            while (p < 31)
            {
                if ((number >> (p + 1) & 1) == 1 && ((nextNumber >> p) & 1) == 1)
                {
                    leftCouples++;
                }

                p++;
            }

            return leftCouples;
        }

        static int RightDiagonal(int number, int nextNumber)
        {
            int rightCouples = new int();

            int p = 0;
            while (p < 31)
            {
                if (((number >> p) & 1) == 1 && ((nextNumber >> (p + 1) & 1) == 1))
                {
                    rightCouples++;
                }

                p++;
            }

            return rightCouples;
        }
    }
}