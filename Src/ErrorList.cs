namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// represent error list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ErrorList<T> : List<T>
    {
        public override string ToString()
        {
            var output = "";
            foreach (var item in this)
            {
                output += $"{Environment.NewLine} » { item } ";
            }
            return output;
        }
    }
}