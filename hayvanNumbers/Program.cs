namespace NineDigitMagicNumber
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int num = 555; num <= 999; num++)
            {
                int num2 = num + diff;
                int num3 = num2 + diff;
                bool allowed = AllowedNumber(num2) && AllowedNumber(num3) && AllowedNumber(num);
                bool sums = (SumDigits(num) + SumDigits(num2) + SumDigits(num3)) == sum;
                if (allowed && sums)
                {
                    cnt++;
                    Console.WriteLine("{0}{1}{2}", num, num2, num3);
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine("No");
            }
        }

        static int SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        static bool AllowedNumber(int num)
        {
            bool isallowed = false;
            int m = 0;
            while (num > 0)
            {
                m = num % 10;
                if (m <= 9 && m >= 5)
                {
                    isallowed = true;
                    num /= 10;
                }
                else
                {
                    isallowed = false;
                    break;
                }
            }

            return isallowed;
        }
    }
}