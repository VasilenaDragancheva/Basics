namespace LargerProductOfDigits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxProduct = int.MinValue;
            int numOfDigits = 6;

            int i = 0;
            while (i + numOfDigits <= input.Length)
            {
                int currentProduct = 1;
                for (int index = i; index < numOfDigits + i; index++)
                {
                    currentProduct *= int.Parse(input[index].ToString());
                }

                if (currentProduct > maxProduct)
                {
                    maxProduct = currentProduct;
                }

                i++;
            }

            Console.WriteLine(maxProduct);
        }
    }
}