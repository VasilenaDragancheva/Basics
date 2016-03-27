namespace FitBoxInBox
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBox = new int[3];
            int[] secondBox = new int[3];
            firstBox[0] = int.Parse(Console.ReadLine());
            firstBox[1] = int.Parse(Console.ReadLine());
            firstBox[2] = int.Parse(Console.ReadLine());
            secondBox[0] = int.Parse(Console.ReadLine());
            secondBox[1] = int.Parse(Console.ReadLine());
            secondBox[2] = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        if (FitIn(i, j, k, firstBox, secondBox))
                        {
                            Console.WriteLine(
                                "({0}, {1}, {2}) < ({3}, {4}, {5})", 
                                firstBox[0], 
                                firstBox[1], 
                                firstBox[2], 
                                secondBox[i], 
                                secondBox[j], 
                                secondBox[k]);
                        }

                        if (FitIn(i, j, k, secondBox, firstBox))
                        {
                            Console.WriteLine(
                                "({0}, {1}, {2}) < ({3}, {4}, {5})", 
                                secondBox[0], 
                                secondBox[1], 
                                secondBox[2], 
                                firstBox[i], 
                                firstBox[j], 
                                firstBox[k]);
                        }
                    }
                }
            }
        }

        static bool FitIn(int i, int j, int k, int[] small, int[] big)
        {
            bool fitIn = false;
            if (i != k && i != j && j != k)
            {
                if (small[0] < big[i] && small[1] < big[j] && small[2] < big[k])
                {
                    fitIn = true;
                }
            }

            return fitIn;
        }
    }
}