namespace MagicNumbersRecursive
{
    using System;
    using System.Linq;

    public class Program
    {
        private static readonly int k = 8;

        private static readonly int[] combination = new int[k];

        private static readonly int[] numbers = Enumerable.Range(1, 9).ToArray();

        private static int number;

        public static void Main(string[] args)
        {
            number = int.Parse(Console.ReadLine());
            int startIndex = 0;
            int valueIndex = 0;

            GetVariations(startIndex, valueIndex);
        }

        private static void GetVariations(int startIndex, int valueIndex)
        {
            if (startIndex >= k)
            {
                bool productEqual = CheckProduct();
                if (productEqual)
                {
                    Render();
                }
            }
            else
            {
                for (int i = valueIndex; i < numbers.Length; i++)
                {
                    combination[startIndex] = numbers[i];
                    GetVariations(startIndex + 1, valueIndex);
                }
            }
        }

        private static void Render()
        {
            var result = string.Join("-", combination);
            result = result.Replace("-", string.Empty);
            Console.WriteLine(result);
        }

        private static bool CheckProduct()
        {
            int product = 1;
            foreach (var n in combination)
            {
                product *= n;
            }

            if (product == number)
            {
                return true;
            }

            return false;
        }
    }
}