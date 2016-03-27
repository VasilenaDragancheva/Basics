using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitKiller
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 1;
            int[] numbers = new int[n];
            int[] numbersAfter = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int p = 0;
                while (p <= 7&&p!=toKill)
                {
                    numbersAfter[i] |= (((numbers[i] >> p) & 1) << p);
                    p++;
                }
            }
        }
        static bool Killed(int index, int n,int step)
        {
            index=1;
            bool toKill = false;
            for (int i = 0; i < n * 8;i++ )
            {
                while (index < n * 8)
                {
                    index += step;
                }
                if(i==index)
                {
                    toKill = true;
                }

            }
                return toKill;

        }
    }
}
