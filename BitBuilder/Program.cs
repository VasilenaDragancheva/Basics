namespace BitBuilder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "quit")
            {
                int position = int.Parse(command);
                string action = Console.ReadLine();

                switch (action)
                {
                    case "flip":
                        number ^= 1L << position;
                        break;
                    case "remove":
                        long mask = (1 << position) - 1;
                        long bitsBeforeP = mask & number;
                        number = (number >> (position + 1)) << position;
                        number |= bitsBeforeP;
                        break;
                    case "insert":

                        mask = (1 << position) - 1;
                        bitsBeforeP = mask & number;
                        number = (number >> position) << position + 1;
                        number |= 1L << position;
                        number |= bitsBeforeP;
                        break;
                    case "skip":
                        command = Console.ReadLine();
                        continue;
                }

                command = Console.ReadLine();
            }

            if (command == "quit")
            {
                Console.WriteLine(number);
            }
        }
    }
}