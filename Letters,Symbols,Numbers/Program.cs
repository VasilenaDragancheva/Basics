using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Symbols_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLetters = 0;
            int countSymbols = 0;
            int countDigits = 0;
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine().ToLower(); 
                for(int c=0;c<input.Length;c++)
                {
                    char sign = input[c];
                    if(sign>='a'&&sign<='z')
                    {
                        countLetters += ((sign - 'a' + 1) * 10);
                    }
                    if (sign >= '1' && sign <= '9')
                    {

                        countDigits += int.Parse(sign.ToString());
                    }
                    if(char.IsSymbol(sign))
                    {
                        countSymbols += 200;
                    }
                }
            }
        }
    }
}
