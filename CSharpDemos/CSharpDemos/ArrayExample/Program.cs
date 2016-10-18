using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExample
{
   class Program
   {
      static void Main(string[] args)
      {
         // One dimensional aary
         long[] row1 = new long[4] { 0, 1, 2, 3 };

         // Alternative
         long[] row2 = new long[] { 0, 1, 2, 3 };
         for (int i = 0; i < row2.GetLength(0); i++)
         {
            Console.WriteLine("row[{0}] = {1}", i, row2[i]);
         }

         WorkWithArray(row2);


         // Two dimensional array
         int[,] grid1 = new int[2, 3];

         // Two dimensional array implicit
         int[,] grid2 =  { {0, 1, 2},
	                       {4, 5, 6} };

         for (int i = 0; i < grid2.GetLength(0); i++)
         {
            for (int j = 0; j < grid2.GetLength(1); j++)
            {
               Console.WriteLine("grid2[{0},{1}] = {2}", i, j, grid2[i, j]);
            }
         }

          //int [ ] array;
          //array = new int [] {0, 2, 4, 6};



         // C# 3.0 implicitly
         int[] k = { 1, 2, 3, 4, };

         var t = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

         Array.Sort(t);
         
         Console.WriteLine();
         foreach (var item in t)
         {
             Console.Write("{0} ", item );
         }

        

         Console.ReadKey();
      }

      private static void WorkWithArray(long[] row2)
      {
          row2[0]++;
      }
   }
}
