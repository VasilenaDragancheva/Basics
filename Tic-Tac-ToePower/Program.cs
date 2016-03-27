namespace Tic_Tac_ToePower
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int xInput = int.Parse(Console.ReadLine());
            int yInput = int.Parse(Console.ReadLine());
            int valueFirst = int.Parse(Console.ReadLine());
            int index = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    int cellValue = index + valueFirst;
                    index++;
                    if (y == yInput && x == xInput)
                    {
                        ulong product = (ulong)Math.Pow(cellValue, index);
                        Console.WriteLine(product.ToString());
                    }
                }
            }
        }
    }
}