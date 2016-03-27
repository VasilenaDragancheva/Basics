using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAlphab
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] w = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());
            int m = w.Length;
            char[] blockArr = new char[n * n];
            int j = 0;
            for (int i = 0; i <= n * n - 1; i++)
            {

                blockArr[i] = w[j];
                j++;
                if (j == m)
                {
                    j = 0;
                }
            }


            //righ alphabetic
            int countRight = -1;
            int maxRight = int.MinValue;
            for (int i = 0; i <= n * n - 1; i++)
            {
                int k = i;
                while (k <= (i / n + 1) * n && k < (n * n - 1))
                {
                    if (blockArr[k] < blockArr[k + 1])
                    {
                       
                    }
                    k++;
                }
            }
            
        }

    }
}