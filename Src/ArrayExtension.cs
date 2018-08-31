namespace SudokuSolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// this class has the extension method needed for suduko algorithm
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Get a Column from 2D array
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="matrix">the source 2D array</param>
        /// <param name="columnIndex">the column index that need to be retrieved.</param>
        /// <returns>1D array of column values</returns>
        public static T[] GetColumn<T>(this T[,] matrix, int columnIndex)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnIndex])
                    .ToArray();
        }

        /// <summary>
        /// Get a Row from 2D array
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="matrix"></param>
        /// <param name="rowIndex">the row index that need to be retrieved.</param>
        /// <returns>1D array of row values</retthe source 2D arrayurns>
        public static T[] GetRow<T>(this T[,] matrix, int rowIndex)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowIndex, x])
                    .ToArray();
        }

        /// <summary>
        /// Get 3X3 boxes from 2D int array
        /// </summary>
        /// <param name="matrix">the source 2D array</param>
        /// <returns>2D array of all boxes (3X3) </returns>
        public static Dictionary<int, int[]> GetSquares(this int[,] matrix)
        {
            Dictionary<int, int[]> squares = new Dictionary<int, int[]>();
            if (Is9By9Matrix(matrix))
            {
                squares.Add(0, new int[] { matrix[0, 0], matrix[0, 1], matrix[0, 2], matrix[1, 0], matrix[1, 1], matrix[1, 2], matrix[2, 0], matrix[2, 1], matrix[2, 2] });
                squares.Add(1, new int[] { matrix[0, 3], matrix[0, 4], matrix[0, 5], matrix[1, 3], matrix[1, 4], matrix[1, 5], matrix[2, 3], matrix[2, 4], matrix[2, 5] });
                squares.Add(2, new int[] { matrix[0, 6], matrix[0, 7], matrix[0, 8], matrix[1, 6], matrix[1, 7], matrix[1, 8], matrix[2, 6], matrix[2, 7], matrix[2, 8] });
                squares.Add(3, new int[] { matrix[3, 0], matrix[3, 1], matrix[3, 2], matrix[4, 0], matrix[4, 1], matrix[4, 2], matrix[5, 0], matrix[5, 1], matrix[5, 2] });
                squares.Add(4, new int[] { matrix[3, 3], matrix[3, 4], matrix[3, 5], matrix[4, 3], matrix[4, 4], matrix[4, 5], matrix[5, 3], matrix[5, 4], matrix[5, 5] });
                squares.Add(5, new int[] { matrix[3, 6], matrix[3, 7], matrix[3, 8], matrix[4, 6], matrix[4, 7], matrix[4, 8], matrix[5, 6], matrix[5, 7], matrix[5, 8] });
                squares.Add(6, new int[] { matrix[6, 0], matrix[6, 1], matrix[6, 2], matrix[7, 0], matrix[7, 1], matrix[7, 2], matrix[8, 0], matrix[8, 1], matrix[8, 2] });
                squares.Add(7, new int[] { matrix[6, 3], matrix[6, 4], matrix[6, 5], matrix[7, 3], matrix[7, 4], matrix[7, 5], matrix[8, 3], matrix[8, 4], matrix[8, 5] });
                squares.Add(8, new int[] { matrix[6, 6], matrix[6, 7], matrix[6, 8], matrix[7, 6], matrix[7, 7], matrix[7, 8], matrix[8, 6], matrix[8, 7], matrix[8, 8] });
            }
            return squares;
        }

        /// <summary>
        /// Check if a Matrix is a 9X9 int matrix
        /// </summary>
        /// <param name="matrix">the source 2D array</param>
        /// <returns>true if the source matrix int 9X9 int matrix, otherwise false will be returned</returns>
        public static bool Is9By9Matrix(this int[,] matrix)
        {
            return (matrix.GetLength(0) == 9 && matrix.GetLength(1) == 9);
        }

        /// <summary>
        /// Get the Box array for any element in the suduko grid
        /// </summary>
        /// <param name="matrix">the source 2D int array</param>
        /// <param name="element">the target element</param>
        /// <returns>1D array representing the box of the element passed</returns>
        public static int[] GetSquare(this int[,] matrix, Element element)
        {
            if (element.X <= 2)
            {
                if (element.Y <= 2)
                {
                    //square 1.
                    return matrix.GetSquares()[0];
                }
                else if (element.Y <= 5)
                {
                    //square 2
                    return matrix.GetSquares()[1];
                }
                else
                {
                    //square 3,
                    return matrix.GetSquares()[2];
                }
            }
            else if (element.X <= 5)
            {
                if (element.Y <= 2)
                {
                    //square 4
                    return matrix.GetSquares()[3];
                }
                else if (element.Y <= 5)
                {
                    //square 5
                    return matrix.GetSquares()[4];
                }
                else
                {
                    //square 6
                    return matrix.GetSquares()[5];
                }
            }
            else
            {
                if (element.Y <= 2)
                {
                    //square 7
                    return matrix.GetSquares()[6];
                }
                else if (element.Y <= 5)
                {
                    //square 8
                    return matrix.GetSquares()[7];
                }
                else
                {
                    //square 9
                    return matrix.GetSquares()[8];
                }
            }
        }

        /// <summary>
        /// Get the Box array for any element in the suduko grid
        /// </summary>
        /// <param name="matrix">the source 2D int array</
        /// <param name="rowIndex">the row index</param>
        /// <param name="columnIndex">the column index</param>
        /// <returns>1D array representing the box of the row and column provided/returns>
        public static int[] GetSquare(this int[,] matrix, int rowIndex, int columnIndex)
        {
            if (rowIndex <= 2)
            {
                if (columnIndex <= 2)
                {
                    //square 1.
                    return matrix.GetSquares()[0];
                }
                else if (columnIndex <= 5)
                {
                    //square 2
                    return matrix.GetSquares()[1];
                }
                else
                {
                    //square 3,
                    return matrix.GetSquares()[2];
                }
            }
            else if (rowIndex <= 5)
            {
                if (columnIndex <= 2)
                {
                    //square 4
                    return matrix.GetSquares()[3];
                }
                else if (columnIndex <= 5)
                {
                    //square 5
                    return matrix.GetSquares()[4];
                }
                else
                {
                    //square 6
                    return matrix.GetSquares()[5];
                }
            }
            else
            {
                if (columnIndex <= 2)
                {
                    //square 7
                    return matrix.GetSquares()[6];
                }
                else if (columnIndex <= 5)
                {
                    //square 8
                    return matrix.GetSquares()[7];
                }
                else
                {
                    //square 9
                    return matrix.GetSquares()[8];
                }
            }
        }

        /// <summary>
        /// Get the Box array for any element in the suduko grid
        /// </summary>
        /// <param name="matrix">the source 2D int array</
        /// <param name="squareIndex">the index of the square</param>
        public static int[] GetSquare(this int[,] matrix, int squareIndex)
        {
            return matrix.GetSquares()[squareIndex];
        }

        /// <summary>
        /// check if an array has duplicates
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="entries">the source  array </param>
        /// <returns>True if array contains duplicates</returns>
        public static bool IsContainsDuplicates<T>(this T[] entries)
        {
            return entries.GetDuplicates().Length > 0;
        }

        /// <summary>
        /// get array duplicates
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="entries">the source  array </param>
        /// <returns>array of duplicates</returns>
        public static T[] GetDuplicates<T>(this T[] entries)
        {
            var list = new List<T>();
            for (var i = 0; i < entries.Length; i++)
                for (var j = i + 1; j < entries.Length; j++)
                    if (j != i && entries[j].Equals(entries[i]))
                        if (!list.Contains(entries[j]))
                        {
                            list.Add(entries[j]);
                        }
            return list.ToArray();
        }

        /// <summary>
        /// Retrive Duplicates as List of Duplicates from a 2D array
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="entries">2D source  array </param>
        /// <returns>List Type Duplicate objects</returns>
        public static IEnumerable<Duplicate> GetDuplicateObjects<T>(this int[,] source)
        {
            var duplicates = new List<Duplicate>();

            for (int i = 0; i < source.GetLength(0); i++)
            {
                // Get Duplicates of all Rows
                var rows = source.GetRow(i);
                if (rows.Any())
                {
                    var dups = rows.RemoveElement(0).GetDuplicates();

                    dups.ToList().ForEach(d =>
                    {
                        var Indeces = rows.GetIndeces(d);

                        if (Indeces.Any())
                        {
                            Indeces.ToList().ForEach(index =>
                             {
                                 duplicates.Add(new Duplicate(new Element(i, index, d), DuplicateLocation.Row));
                             });
                        }
                    });
                }
                // Get Duplicates of all Columns
                var columns = source.GetColumn(i);
                if (columns.Any())
                {
                    var dups = columns.RemoveElement(0).GetDuplicates();

                    dups.ToList().ForEach(d =>
                    {
                        var Indeces = columns.GetIndeces(d);

                        if (Indeces.Any())
                        {
                            Indeces.ToList().ForEach(index =>
                            {
                                duplicates.Add(new Duplicate(new Element(index, i, d), DuplicateLocation.Column));
                            });
                        }
                    });
                }
                // Get Duplicates of all Squares
                var squares = source.GetSquare(i);
                if (squares.Any())
                {
                    var dups = squares.RemoveElement(0).GetDuplicates();

                    dups.ToList().ForEach(s =>
                    {
                        var Indeces = squares.GetIndeces(s);

                        if (Indeces.Any())
                        {
                            Indeces.ToList().ForEach(index =>
                            {
                                duplicates.Add(new Duplicate(new Element(i, index, s), DuplicateLocation.Square));
                            });
                        }
                    });
                }
            }
            return duplicates;
        }

        /// <summary>
        /// get the difference of a given array from a source array
        /// </summary>
        /// <param name="source">the source array</param>
        /// <param name="other">the given array</param>
        /// <returns>array of T values</returns>
        public static T[] Subract<T>(this T[] source, T[] other)
        {
            return source.Except(other).ToArray();
        }

        /// <summary>
        /// remove all the elements that matches a given element from array of T values
        /// </summary>
        /// <typeparam name="T">The array type</typeparam>
        /// <param name="source">the source array of T values</param>
        /// <param name="item">the item that needs to be removed</param>
        /// <returns>array of T that doesn't contain item</returns>
        public static T[] RemoveElement<T>(this T[] source, T item)
        {
            if (source == null)
            {
                return null;
            }
            if (source.Length == 0)
            {
                return null;
            }
            var list = new List<T>(source);
            list.RemoveAll(i => i.Equals(item));
            return list.ToArray();
        }

        /// <summary>
        /// get array of indeces that belong to a certain element in an array of T
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="source">the source array of T</param>
        /// <param name="element">the elements that need to be checked</param>
        /// <returns>array of int[] that represent the indeces of that element in the array</returns>
        public static int[] GetIndeces<T>(this T[] source, T element)
        {
            var indeces = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i].Equals(element))
                {
                    indeces.Add(i);
                }
            }
            return indeces.ToArray();
        }

        /// <summary>
        /// check if a given array is empty
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="source">the source array of T</param>
        /// <returns>True if the array is empty otherwise 0 will be returned</returns>
        public static bool IsEmpty<T>(this T[] source)
        {
            return source != null || source.Length == 0;
        }

        /// <summary>
        /// check if a 2D array contains an input
        /// </summary>
        /// <typeparam name="T">array type</typeparam>
        /// <param name="source">the source array of T</param>
        /// <param name="input">the T element that need to be checked</param>
        /// <returns>True if the source 2D array contains T element</returns>
        public static bool Contains<T>(this T[,] source, T input)
        {
            for (int i = 0; i < source.GetLength(0); i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    if (source[i, j].Equals(input))
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// convert jagged array T[][] to multidimentional array T[*,*]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T[,] To2D<T>(this T[][] source)
        {
            try
            {
                int FirstDim = source.Length;
                int SecondDim = source.GroupBy(row => row.Length).Single().Key; // throws InvalidOperationException if source is not rectangular

                var result = new T[FirstDim, SecondDim];
                for (int i = 0; i < FirstDim; ++i)
                    for (int j = 0; j < SecondDim; ++j)
                        result[i, j] = source[i][j];

                return result;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("The given jagged array is not rectangular.");
            }
        }
    }
}