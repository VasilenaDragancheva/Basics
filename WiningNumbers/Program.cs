namespace WiningNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int sumOfLetters = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sumOfLetters += input[i] - 'a' + 1;
            }

            bool isResult = false;

            for (int numbers = 0; numbers < 999999; numbers++)
            {
                int first3 = numbers / 1000;
                int second3 = numbers % 1000;
                int productFirst3 = 1;
                int productSecond3 = 1;
                int times = 0;

                while (times < 3)
                {
                    productFirst3 *= first3 % 10;
                    first3 /= 10;
                    productSecond3 *= second3 % 10;
                    second3 /= 10;
                    times++;
                }

                if (sumOfLetters == productFirst3 && sumOfLetters == productSecond3)
                {
                    isResult = true;
                    Console.WriteLine("{0}-{1}", numbers / 1000, numbers % 1000);
                }
            }

            if (!isResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}