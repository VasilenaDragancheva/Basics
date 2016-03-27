namespace EmergencyPrepare
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {

            string number = "0000000000000111010100101000010011010001010011011101111110111110";
            ulong wall = ulong.Parse(Console.ReadLine());
            long countRepairKit = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int bitNumber = int.Parse(Console.ReadLine());
                ulong mask = ~(1U << bitNumber);
                wall &= mask;
            }

            char[] wallAsNumber = Convert.ToString((long)wall, 2).PadLeft(64, '0').ToCharArray();

            int bitCounter = 63;

            while (bitCounter >= 0 && countRepairKit > 0)
            {
                int sizeOfHole = FindHoleSize(wallAsNumber, bitCounter);

                if (sizeOfHole >= 2)
                {
                    int limit = Math.Max(0, bitCounter - sizeOfHole + 1);
                    for (int j = bitCounter; j >= limit; j--)
                    {
                        wallAsNumber[j] = '1';
                        countRepairKit--;
                        if (countRepairKit == 0)
                        {
                            break;
                        }
                    }
                }

                bitCounter -= sizeOfHole == 0 ? 1 : sizeOfHole;
            }

            Console.WriteLine(Convert.ToUInt64(new string(wallAsNumber), 2));

        }

        private static int FindHoleSize(char[] wallAsNumber, int i)
        {
            int zeroCounters = 0;
            while (i >= 0 && wallAsNumber[i] == '0')
            {
                zeroCounters++;
                i--;
            }
            return zeroCounters;
        }


    }
}