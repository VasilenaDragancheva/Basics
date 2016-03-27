namespace DecryptMessage
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int msgCounter = 0;
            List<string> decryptedMsg = new List<string>();
            Dictionary<char, char> Symbols = new Dictionary<char, char>
                                                 {
                                                     { '!', '$' }, 
                                                     { ' ', '+' }, 
                                                     { '?', '#' }, 
                                                     { ',', '%' }, 
                                                     { '.', '&' }
                                                 };
            string command = Console.ReadLine();
            while (command != "start" && command != "START")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "end" && command != "END")
            {
                if (string.IsNullOrWhiteSpace(command))
                {
                    command = Console.ReadLine();
                    continue;
                }

                char[] result = new char[command.Length];
                for (int c = 0; c < command.Length; c++)
                {
                    char currentChar = command[c];
                    if ((currentChar >= 'A' && currentChar <= 'M') || (currentChar >= 'a' && currentChar <= 'm'))
                    {
                        currentChar = (char)(currentChar + 13);
                    }
                    else if ((currentChar >= 'N' && currentChar <= 'Z') || (currentChar >= 'n' && currentChar <= 'z'))
                    {
                        currentChar = (char)(currentChar - 13);
                    }
                    else if (Symbols.ContainsKey(currentChar))
                    {
                        currentChar = Symbols[currentChar];
                    }

                    result[c] = currentChar;
                }

                Array.Reverse(result);
                decryptedMsg.Add(new string(result));

                msgCounter++;

                command = Console.ReadLine();
            }

            if (command == "END" || command == "end")
            {
                if (msgCounter == 0)
                {
                    Console.WriteLine("No messages sent.");
                }
                else
                {
                    Console.WriteLine("Total number of messages: {0}", msgCounter);
                    foreach (string msg in decryptedMsg)
                    {
                        Console.WriteLine(msg);
                    }
                }
            }
        }
    }
}