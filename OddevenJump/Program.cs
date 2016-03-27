namespace OddevenJump
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine().ToLower();
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            string input = string.Empty;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (char.IsLetter(inputs[i]))
                {
                    input += inputs[i];
                }
            }

            string odd = string.Empty;
            string even = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    even += input[i];
                }

                if (i % 2 == 0)
                {
                    odd += input[i];
                }
            }

            ulong sumOdd = 0;
            ulong sumEven = 0;
            for (int i = 0; i < odd.Length; i++)
            {
                if ((i + 1) % oddJump != 0)
                {
                    sumOdd += odd[i];
                }
                else
                {
                    sumOdd *= odd[i];
                }
            }

            for (int i = 0; i < even.Length; i++)
            {
                if ((i + 1) % evenJump != 0)
                {
                    sumEven += even[i];
                }
                else
                {
                    sumEven *= even[i];
                }
            }

            Console.WriteLine("Odd: {0:X}", sumOdd);
            Console.WriteLine("Even: {0:X}", sumEven);
        }
    }
}