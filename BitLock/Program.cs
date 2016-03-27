namespace BitLock
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[8];
            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            // reading commands
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Split(' ')[0] == "check")
                {
                    int column = int.Parse(command.Split(' ')[1]);
                    int countBits = 0;
                    for (int row = 0; row < 8; row++)
                    {
                        if ((numbers[row] >> column & 1) == 1)
                        {
                            countBits++;
                        }
                    }

                    Console.WriteLine(countBits);
                }
                else if (command.Split(' ')[1] == "right" || (command.Split(' ')[1] == "left"))
                {
                    int number = numbers[int.Parse(command.Split(' ')[0])];
                    int times = int.Parse(command.Split(' ')[2]) % 12;
                    for (int i = 0; i < times; i++)
                    {
                        switch (command.Split(' ')[1])
                        {
                            case "right":
                                int mostRightBit = number & 1;
                                number = number >> 1;
                                number = number | (mostRightBit << 11);
                                break;
                            case "left":
                                int mostLeftBit = number & (1 << 11);
                                number = number << 1;
                                number = number | (mostLeftBit >> 11);
                                break;
                        }
                    }

                    numbers[int.Parse(command.Split(' ')[0])] = number;
                }

                command = Console.ReadLine();
            }

            if (command == "end")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 4095)
                    {
                        numbers[i] = 4095;
                    }

                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}