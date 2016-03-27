namespace Numeroology
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] birtday = input[0].Split('.');
            long produktBirthday = long.Parse(birtday[0]) * long.Parse(birtday[1]) * long.Parse(birtday[2]);
            if (long.Parse(birtday[1]) % 2 != 0)
            {
                produktBirthday *= produktBirthday;
            }

            string username = input[1];

            for (int i = 0; i < username.Length; i++)
            {
                if (char.IsUpper(username[i]))
                {
                    produktBirthday += 2 * (-'A' + 1 + username[i]);
                }

                if (char.IsLower(username[i]))
                {
                    produktBirthday += -'a' + 1 + username[i];
                }

                if (char.IsDigit(username[i]))
                {
                    produktBirthday += long.Parse(username[i].ToString());
                }
            }

            while (produktBirthday > 13)
            {
                long sum = 0;
                while (produktBirthday > 0)
                {
                    sum += produktBirthday % 10;
                    produktBirthday /= 10;
                }

                produktBirthday = sum;
            }

            Console.WriteLine(produktBirthday);
        }
    }
}