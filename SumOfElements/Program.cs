namespace SumOfElements
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            decimal sum = 0;
            decimal num = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                sum += number;
                num = Math.Max(number, num);
            }

            if (num == sum - num)
            {
                Console.Write("Yes, sum={0}", num);
            }
            else
            {
                decimal diff = Math.Abs(sum - 2 * num);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}