using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOflife
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] board = new int[n];
            int[] nextStage = new int[n];
            int cells = int.Parse(Console.ReadLine());
            for (int i = 0; i < cells; i++)
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                
                board[row] |= 1 << col;
                nextStage[row] |= 1 << col;
            }
           

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int currentBit = (board[row] >> col) & 1;
                    int countLiveCells = 0;
                    int startRow = row - 1 >= 0 ? row - 1 : row;
                    int endRow = row + 1 < n ? row + 1 : row;
                    int startCol=col-1>=0?col-1:col;
                    int endCol=col+1<n? col+1:col;

                    for (int r = startRow;r <= endRow; r++)
                    {
                        for (int c = startCol; c <= endCol; c++)
                        {
                            if(r==row&&c==col)
                            {
                                continue;
                            }
                            if(((board[r]>>c)&1)==1)
                            {
                                countLiveCells++;
                            }
                        }
                    }

                    if (currentBit == 1 && (countLiveCells < 2 || countLiveCells > 3))
                    {
                        nextStage[row] ^= 1 << col;
                    }
                    if (currentBit == 0 && countLiveCells == 3)
                    {
                        nextStage[row] ^= 1 << col;
                    }
                }
            }
            foreach (int number in nextStage)
            {

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(10, '0'));
            }
        }

        //private static int LiveCells(int[] board, int row, int col, int n)
        //{
        //    int countLiveCells = 0;


        //    for (int r = row - 1 >= 0 ? row - 1 : row; r <= (row + 1 < n ? row + 1 : row); r++)
        //    {
        //        for (int c = (col - 1 >= 0 ? col - 1 : col); c <= (col + 1 < n ? col + 1 : col); c++)
        //        {
        //            int bit = (board[r] >> c) & 1;
        //            if (bit == 1 && c != col && r != row)
        //            {
        //                countLiveCells++;
        //            }
        //        }
        //    }
        //    return countLiveCells;
        //}
    }
}
