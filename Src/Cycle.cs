namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// represent a cycle of the solution
    /// </summary>
    public class Cycle
    {
        /// <summary>
        /// store the output matrix
        /// </summary>
        public int[,] Matrix { get; set; }

        /// <summary>
        /// store cycle no.
        /// </summary>
        public int CycleNo { get; set; }

        public Cycle(int[,] matrix, int cycleNo)
        {
            this.Matrix = matrix;
            this.CycleNo = cycleNo;
        }

        public override string ToString()
        {
            var result = "";
            result += $"{Environment.NewLine}┌───┬───┬───┬───┬───┬───┬───┬───┬───┐{Environment.NewLine}";
            for (var i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var element = new Element(i, j, Matrix[i, j]);
                    result += $"│ {element} ";
                }
                result += (i != 8) ? $"│{Environment.NewLine}├───┼───┼───┼───┼───┼───┼───┼───┼───┤{Environment.NewLine}" : "│";
            }

            result += $"{Environment.NewLine}└───┴───┴───┴───┴───┴───┴───┴───┴───┘{Environment.NewLine}";

            result += $"Cycle #: {CycleNo}{Environment.NewLine}";

            return result;
        }
    }
}