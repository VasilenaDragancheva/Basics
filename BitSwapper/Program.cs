namespace BitSwapper
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            uint[] numbers = new uint[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] command2 = Console.ReadLine().Split(' ');
                int index1 = int.Parse(command.Split(' ')[0]);
                int index2 = int.Parse(command2[0]);

                int position1 = int.Parse(command.Split(' ')[1]);
                position1 *= 4;
                int position2 = int.Parse(command2[1]);
                position2 *= 4;
                uint mask = 15;

                // getting value of bits
                uint bits1 = (numbers[index1] >> position1) & mask;
                uint bits2 = (numbers[index2] >> position2) & mask;

                // setting value to zero
                numbers[index1] &= ~(mask << position1);
                numbers[index2] &= ~(mask << position2);

                // swapping bits
                numbers[index1] |= bits2 << position1;
                numbers[index2] |= bits1 << position2;

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                foreach (var element in numbers)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}