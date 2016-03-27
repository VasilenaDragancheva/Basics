namespace bitFriends
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            string friends = string.Empty;
            string alone = string.Empty;
            int i = 0;

            while (i < binary.Length)
            {
                int equalBits = 1;
                char bit = binary[i];
                int next = i + 1;
                while (next < binary.Length && bit == binary[next])
                {
                    equalBits++;
                    next++;
                }

                if (equalBits == 1)
                {
                    alone += bit;
                    i++;
                }
                else
                {
                    for (int p = i; p < next; p++)
                    {
                        friends += binary[p];
                    }
                }

                i = next;
            }

            uint friendNumber = 0;
            uint aloneNumber = 0;
            if (friends != string.Empty)
            {
                friendNumber = Convert.ToUInt32(friends, 2);
            }

            if (alone != string.Empty)
            {
                aloneNumber = Convert.ToUInt32(alone, 2);
            }

            Console.WriteLine(friendNumber);
            Console.WriteLine(aloneNumber);
        }
    }
}