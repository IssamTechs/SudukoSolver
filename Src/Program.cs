namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    public class Program
    {
        private static void Main()
        {
            var sudokoMatrix = new int[9, 9]
                {
                  {0,1,7,8,5,3,0,9,0 },
                  {9,3,5,7,6,4,0,0,8 },
                  {8,4,6,1,2,9,0,3,7 },
                  {6,5,2,4,9,8,3,7,1 },
                  {1,7,4,2,3,6,9,8,5 },
                  {3,9,8,5,7,1,6,4,2 },
                  {4,2,1,9,8,5,7,0,3 },
                  {5,6,9,3,1,0,0,0,4 },
                  {0,8,3,6,4,2,1,0,0 },
                };

            Console.WriteLine("start Generating .....");
            //Suduko.GetValidSudukoGridExamples(100, @"C:\Users\Suraya\Desktop\suduko.txt");
            Console.WriteLine(Suduko.Go(sudokoMatrix));
            Console.WriteLine("finish Generating .....");

            Console.ReadKey();
        }
    }
}