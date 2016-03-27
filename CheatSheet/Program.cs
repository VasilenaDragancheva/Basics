namespace CheatSheet
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            long V = int.Parse(Console.ReadLine());
            long H = int.Parse(Console.ReadLine());
            for (int m = 0; m < R; m++)
            {
                for (int i = 1; i <= C; i++)
                {
                    if (i < C)
                    {
                        Console.Write((V + m) * (H + i - 1) + " ");
                    }

                    if (i == C)
                    {
                        Console.Write((V + m) * (H + i - 1));
                    }
                }

                Console.WriteLine();
            }
        }
    }
}