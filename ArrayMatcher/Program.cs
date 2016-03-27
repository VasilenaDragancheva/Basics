namespace ArrayMatcher
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            char[] firstArray = input[0].ToCharArray();
            char[] secondArray = input[1].ToCharArray();
            string command = input[2];
            Array.Sort(firstArray);
            Array.Sort(secondArray);
            StringBuilder newarr = new StringBuilder();
            switch (command)
            {
                case "join":
                    foreach (char symbol in firstArray)
                    {
                        if (secondArray.Contains(symbol))
                        {
                            newarr.Append(symbol);
                        }
                    }

                    break;
                case "right exclude":
                case "exclude right":
                    foreach (char symbol in firstArray)
                    {
                        if (!secondArray.Contains(symbol))
                        {
                            newarr.Append(symbol);
                        }
                    }

                    break;
                case "exclude left":
                case "left exclude":
                    foreach (char symbol in secondArray)
                    {
                        if (!firstArray.Contains(symbol))
                        {
                            newarr.Append(symbol);
                        }
                    }

                    break;
            }

            Console.WriteLine(newarr.ToString());
        }
    }
}