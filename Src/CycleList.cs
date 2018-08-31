namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// represent Cycle List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CycleList<T> : List<T>
    {
        public override string ToString()
        {
            var output = "";
            foreach (var item in this)
            {
                output += item;
            }
            return output;
        }
    }
}