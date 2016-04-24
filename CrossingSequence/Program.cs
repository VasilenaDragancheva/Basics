namespace CrossingSequence
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> Tribonacci = new List<ulong>();
            List<ulong> SpiralMatrix = new List<ulong>();

            for (int i = 0; i < 3; i++)
            {
                Tribonacci.Add(ulong.Parse(Console.ReadLine()));
            }

            int pos = 3;
            ulong nextTrib = 0;
            
            while (nextTrib <= 1000000)
            {
                nextTrib = Tribonacci[pos - 1] + Tribonacci[pos - 2] + Tribonacci[pos - 3];
                Tribonacci.Add(nextTrib);
                pos++;
            }

            ulong start = ulong.Parse(Console.ReadLine());
            SpiralMatrix.Add(start);
            ulong step = ulong.Parse(Console.ReadLine());
            ulong nextSpiral = start + step;
            ulong factor = 1;
            while (nextSpiral <= 1000000)
            {
                start += factor * step;
                SpiralMatrix.Add(start);
                nextSpiral = start + factor * step;
                SpiralMatrix.Add(nextSpiral);
                factor++;
                start = nextSpiral;
            }

            bool isAnswer = false;
            Tribonacci.Sort();

            foreach (ulong number in Tribonacci)
            {
                if (SpiralMatrix.Contains(number))
                {
                    isAnswer = true;
                    Console.WriteLine(number);
                    break;
                }
            }

            if (!isAnswer)
            {
                Console.WriteLine("No");
            }
        }

        private static ulong CalculatingTrib(int pos, List<ulong> Tribonacci)
        {
            if (pos == 0)
            {
                return Tribonacci[0];
            }

            if (pos == 1)
            {
                return Tribonacci[1];
            }

            if (pos == 2)
            {
                return Tribonacci[2];
            }

            return
                Tribonacci[pos] =
                CalculatingTrib(pos - 1, Tribonacci) + CalculatingTrib(pos - 2, Tribonacci)
                + CalculatingTrib(pos - 3, Tribonacci);
        }
    }
}