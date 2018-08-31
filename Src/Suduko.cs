namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// class contains Suduko Core Logic
    /// </summary>
    public class Suduko
    {
        /// <summary>
        ///  Array of Errors that may be raised during the processing of the suduko grid
        /// </summary>
        private static ErrorList<Error> Errors = new ErrorList<Error>();

        /// <summary>
        ///  each process cycle will be stored in the Cycles List
        /// </summary>
        private static CycleList<Cycle> Cycles = new CycleList<Cycle>();

        private static int[,] OriginalMatrix;

        /// <summary>
        /// populate entries in a 2D matrix into a dictionary of key: element object , Values: list of integers
        /// </summary>
        /// <param name="matrix">the source 2D grid </param>
        /// <returns>Dictionary of key:element object, Value:List of integers</int></returns>
        public static Dictionary<Element, List<int>> PopulateEntries(int[,] matrix)
        {
            var entries = new Dictionary<Element, List<int>>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var element = new Element(row, col, matrix[row, col] == 0 ? (int?)null : matrix[row, col]);

                    var possibleValues = GetPossibleClues(matrix, element);

                    entries.Add(element, possibleValues);
                }
            }
            return entries;
        }

        /// <summary>
        /// Get All Possible Clues
        /// </summary>
        /// <param name="matrix">the source matrix</param>
        /// <param name="element">the targeted element Object.</param>
        /// <returns></returns>
        public static List<int> GetPossibleClues(int[,] matrix, Element element)
        {
            if (element.Value != null)
                return new List<int>();
            int[] elementValue = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var row = matrix.GetRow(element.X);
            var col = matrix.GetColumn(element.Y);
            var square = matrix.GetSquare(element);
            elementValue = elementValue.Subract(row);
            elementValue = elementValue.Subract(col);
            elementValue = elementValue.Subract(square);

            return elementValue.ToList();
        }

        /// <summary>
        /// Solve the matrix recursively
        /// </summary>
        /// <param name="matrix">the source matrix</param>
        /// <param name="retry">how many retries need to be performed</param>
        /// <param name="cycle">keep tracks of how many cycles</param>
        /// <returns>returns a new matrix</returns>
        public static int[,] Solve(int[,] matrix, int cycle = 1, int tries = 100)
        {
            if (IsValidSuduko(matrix))
            {
                var entries = PopulateEntries(matrix);

                var isSolved = !entries.Where(e => e.Value.Count > 0).Any();

                if (!isSolved)
                {
                    PushClues(entries);

                    matrix = PopulateMatrix(entries);

                    Cycles.Add(new Cycle(matrix, cycle));

                    return Solve(matrix, ++cycle);
                }

                if (IsDeadEndSituation(entries))
                {
                    --tries;
                    entries = null;
                    cycle = 0;
                    Errors = new ErrorList<Error>();
                    Cycles = new CycleList<Cycle>();
                    Solve(OriginalMatrix);
                }
            }
            return matrix;
        }

        private static bool IsDeadEndSituation(Dictionary<Element, List<int>> entries)
        {
            return entries.Where(e => e.Key.Value == (int?)null && e.Value.Count == 0).Any();
        }

        /// <summary>
        /// Check if the Suduko Grid is valis
        /// </summary>
        /// <param name="matrix">the source matrix</param>
        /// <returns>true if it's a valid suduko grid</returns>
        public static bool IsValidSuduko(int[,] matrix)
        {
            var isValid = true;

            // matrix has to be square matrix
            if (!matrix.Is9By9Matrix())
            {
                Errors.Add(new Error(BlockIssue.MatrixNotSquare));
                return false;
            }

            // matrix has to be square matrix
            if (!matrix.Is9By9Matrix())
            {
                Errors.Add(new Error(BlockIssue.Invalid9By9));
                return false;
            }

            // element must be between 1 and 9 to be a valid element
            if (!ContainsValidEntries(matrix))
            {
                isValid = false;
            }

            // check if Rows has duplicates
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // remove 0 from entries
                var row = matrix.GetRow(i).RemoveElement(0);
                var column = matrix.GetColumn(i).RemoveElement(0);
                var square = matrix.GetSquare(i).RemoveElement(0);

                if (row.IsContainsDuplicates())
                {
                    isValid = false;
                    Errors.Add(new Error(BlockIssue.Duplicateelement));
                }
                if (column.IsContainsDuplicates())
                {
                    isValid = false;
                    Errors.Add(new Error(BlockIssue.Duplicateelement));
                }
                if (square.IsContainsDuplicates())
                {
                    isValid = false;
                    Errors.Add(new Error(BlockIssue.Duplicateelement));
                }
            }

            return isValid;
        }

        /// <summary>
        /// check if every element in the suduko grid contains valid element
        /// </summary>
        /// <param name="matrix">the source matrix</param>
        /// <returns>true if the source matrix is a valid suduko grid</returns>
        public static bool ContainsValidEntries(int[,] matrix)
        {
            var isValid = true;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var element = matrix[row, col];
                    if (!IsValidelement(element))
                    {
                        Errors.Add(new Error(BlockIssue.Invalidelement, new Element(row, col, element)));
                        isValid = false;
                    }
                }
            }
            return isValid;
        }

        /// <summary>
        /// populate a 2D array out of a Dictionary of Key: element object, values will be not be considered
        /// </summary>
        /// <param name="entries">the source dictionary</param>
        /// <returns>2D array representing the dictionary key element object</returns>
        public static int[,] PopulateMatrix(Dictionary<Element, List<int>> entries)
        {
            int[,] matrix = new int[(int)Math.Sqrt(entries.Count), (int)Math.Sqrt(entries.Count)];
            foreach (var item in entries)
            {
                matrix[item.Key.X, item.Key.Y] = item.Key.Value ?? 0;
            }
            return matrix;
        }

        /// <summary>
        /// Push one of the empty element clues to be element value
        /// </summary>
        /// <param name="entries">the source dictionary</param>
        public static void PushClues(Dictionary<Element, List<int>> entries)
        {
            var ElementWithOneClue = entries.Where(e => e.Value.Count == 1);
            var ElementWithMoreThanOneClue = entries.Where(e => e.Value.Count > 1);
            var random = new Random((int)DateTime.Now.Ticks);
            if (ElementWithOneClue.Any())
            {
                var candidate = ElementWithOneClue.ElementAt(random.Next(0, ElementWithOneClue.Count()));
                candidate.Key.Value = candidate.Value.FirstOrDefault();
                candidate.Value.Clear();
            }
            else
            {
                var notCandidate = ElementWithMoreThanOneClue.ElementAt(random.Next(0, ElementWithMoreThanOneClue.Count()));
                notCandidate.Key.Value = notCandidate.Value.FirstOrDefault();
                notCandidate.Value.Clear();
            }
        }

        /// <summary>
        /// start solving the suduko matrix
        /// </summary>
        /// <param name="matrix">the matrix that need to be resolved</param>
        /// <returns>returns a string output of the result</returns>
        public static string Go(int[,] matrix)
        {
            Stopwatch swatch = new Stopwatch();
            swatch.Start();
            OriginalMatrix = matrix;
            Solve(matrix);
            swatch.Stop();
            var output = Cycles.ToString();
            output += Errors.ToString();
            System.Threading.Thread.Sleep(2000);
            output += $"Elaspsed time: {swatch.Elapsed.ToString("mm\\:ss\\.ff")}";
            return output;
        }

        /// <summary>
        /// get list of a valid suduko grids
        /// </summary>
        /// <param name="times">as time variables increases, the more valid suduko grids retrived.</param>
        /// <param name="fileName">the file path where you want to save the suduko grid</param>
        public static void GetValidSudukoGridExamples(int times, string fileName)
        {
            if (!(File.Exists(fileName)))
            {
                File.CreateText(fileName);
            }
            var input = new int[9, 9];
            for (int i = 0; i < times; ++i)
            {
                Errors.Clear();
                Cycles.Clear();
                Solve(input);

                if (Errors.Any())
                {
                    --i;
                }
                else
                {
                    File.AppendAllText(fileName, $" {Environment.NewLine}Suduko #{i}: {Environment.NewLine}{Cycles.Where(c => !c.Matrix.Contains(0)).FirstOrDefault().ToString()}");
                }
            }
        }

        /// <summary>
        /// determins if a value is a valid suduko element value
        /// </summary>
        /// <param name="value">the element that need to be examined</param>
        /// <returns>true if the value is between 1 and 9</returns>
        public static bool IsValidelement(int value)
        {
            return value == 0 || (value >= 1 && value <= 9);
        }
    }
}