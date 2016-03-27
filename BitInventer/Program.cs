namespace BitInventer
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "quit")
            {
                int bitPosition = int.Parse(input);
                string command = Console.ReadLine();
                switch (command)
                {
                    case "flip":
                        int bitValue = (number >> bitPosition) & 1;
                        if (bitValue == 1)
                        {
                            number &= ~(bitValue << bitPosition);
                        }

                        if (bitValue == 0)
                        {
                            number |= 1 << bitPosition;
                        }

                        break;
                    case "remove":
                        int leftBits = number >> bitPosition + 1;
                        for (int i = bitPosition - 1; i >= 0; i--)
                        {
                            bitValue = (number >> i) & 1;
                            leftBits = leftBits << 1;
                            leftBits |= bitValue;
                        }

                        number = leftBits;
                        break;
                    case "insert": // to different methods
                        leftBits = ((number >> bitPosition) << 1) | 1;
                        for (int i = bitPosition - 1; i >= 0; i--)
                        {
                            bitValue = (number >> i) & 1;
                            leftBits = leftBits << 1;
                            leftBits |= bitValue;
                        }

                        number = leftBits;
                        break;
                }

                input = Console.ReadLine();
            }

            if (input == "quit")
            {
                Console.WriteLine(number); // Convert.ToString(number, 2).PadLeft(15, '0'));
            }
        }
    }
}