namespace GameOfBits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            do
            {
                string command = Console.ReadLine();
                if (command == "Game Over!")
                {
                    break;
                }

                uint newNumber = new uint();
                for (int i = 31; i >= 0; i--)
                {
                    if ((i + 1) % 2 == 1 && command == "Odd")
                    {
                        uint bit = (number >> i) & 1;
                        newNumber <<= 1;
                        newNumber |= bit;
                    }

                    if ((i + 1) % 2 == 0 && command == "Even")
                    {
                        uint bit = (number >> i) & 1;
                        newNumber <<= 1;
                        newNumber |= bit;
                    }
                }

                number = newNumber;
            }
            while (true);
            int counter = 0;

            for (int i = 0; i <= 31; i++)
            {
                uint bit = (number >> i) & 1;
                if (bit == 1)
                {
                    counter++;
                }
            }

            Console.WriteLine("{0} -> {1}", number, counter);
        }
    }
}