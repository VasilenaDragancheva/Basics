namespace SequenceKelem
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            bool isEqual = false;
            int start = 0;
            int k = 0;
            while (start <= input.Length - n)
            {
                while (k < start + n)
                {
                    if (input[start] == input[k])
                    {
                        isEqual = true;
                        k++;
                    }
                    else if (input[start] != input[k])
                    {
                        isEqual = false;
                        start++;
                        break;
                    }
                }

                if (isEqual)
                {
                    for (int i = start; i < start + n; i++)
                    {
                        input[i] = "NO";
                    }

                    start += n;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "NO")
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}