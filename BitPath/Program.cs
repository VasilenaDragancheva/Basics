namespace BitPath
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[8];

                // either down left (direction = -1), down (direction = 0) or down right (direction = +1)
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(',');
                int direction = 3 - int.Parse(command[0]); // reverse to normal indexing of bits
                table[0] ^= 1 << direction;
                for (int p = 1; p < command.Length; p++)
                {
                    direction -= int.Parse(command[p]);
                    table[p] ^= 1 << direction;
                }
            }

            int sumNumbers = 0;
            for (int num = 0; num < table.Length; num++)
            {
                sumNumbers += table[num];
            }

            Console.WriteLine(Convert.ToString(sumNumbers, 2));
            Console.WriteLine("{0:X}", sumNumbers);
        }
    }
}