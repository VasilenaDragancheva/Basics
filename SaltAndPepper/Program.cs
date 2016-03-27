namespace SaltAndPepper
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ulong dishes = ulong.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] commandParams = command.Split(' ');
                string type = commandParams[0];
                int step = int.Parse(commandParams[1]);
                for (int i = 0; i <= 63; i += step)
                {
                    ulong mask = 1uL << i;
                    if (type == "salt")
                    {
                        mask = ~(1uL << i);
                        dishes &= mask;
                    }
                    else
                    {
                        dishes |= mask;
                    }
                }
            }

            Console.WriteLine(dishes);
        }
    }
}