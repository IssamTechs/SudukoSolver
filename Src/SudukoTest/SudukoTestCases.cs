using SudokuSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SudukoTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetSquare_Valid_Matrix_By_Index_0_ShouldReturn_4_And_3()
        {
            var expected = new[] { 0, 0, 0, 0, 4, 0, 3, 0, 0 };

            var result = Setup.validMatrix.GetSquare(0);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Get_Possible_Values_When_Matrix_Valid()
        {
            var element = new Element { Value = null, X = 0, Y = 1 };
            int[] expected = { 5, 6, 7, 9 };
            var result = Suduko.GetPossibleClues(Setup.validMatrix, element).ToArray();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Get_Possible_Values_When_Matrix_Empty()
        {
            var element = new Element { Value = null, X = 0, Y = 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = Suduko.GetPossibleClues(Setup.sudukoEmpty, element).ToArray();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Get_Possible_Values_When_Matrix_Has_One_Complete_Row()
        {
            var element = new Element { Value = null, X = 1, Y = 0 };
            int[] expected = { 4, 5, 6, 7, 8, 9 };
            var result = Suduko.GetPossibleClues(Setup.sudukoWithOneCompleteRow, element).ToArray();
            Assert.Equal(expected, result);
        }

        private bool Is_RowComplete(int[,] matrix)
        {
            var solution = Suduko.Solve(matrix);

            for (int i = 0; i < 9; i++)
            {
                var row = solution.GetRow(i);
                var intesection = row.Intersect(Setup.perfect);
                if (intesection.Count() != Setup.perfect.Count())
                {
                    return false;
                }
            }
            return true;
        }

        private bool Is_Column_Complete(int[,] matrix)
        {
            var solution = Suduko.Solve(matrix);

            for (int i = 0; i < 9; i++)
            {
                var column = solution.GetColumn(i);
                var intesection = column.Intersect(Setup.perfect);
                if (intesection.Count() != Setup.perfect.Count())
                {
                    return false;
                }
            }
            return true;
        }

        private bool Is_Square_Complete(int[,] matrix)
        {
            var solution = Suduko.Solve(matrix);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var square = solution.GetSquare(i, j);
                    var intesection = square.Intersect(Setup.perfect);
                    if (intesection.Count() != Setup.perfect.Count())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [Fact]
        public void Test_Is_Suduko_Solved()
        {
            var result = Is_RowComplete(Setup.validMatrix) && Is_Column_Complete(Setup.validMatrix) && Is_Square_Complete(Setup.validMatrix);
            Assert.True(result);
        }

        [Fact]
        public void Test_Is_Suduko_Solved_For_100_Case()
        {
            var iterate = 0;
            foreach (var item in Setup.solutions.ToArray())
            {
                System.Diagnostics.Debug.WriteLine(++iterate);
                var array = item.Select(i => i.ToArray()).ToArray().To2D();
                var result = Is_RowComplete(array) && Is_Column_Complete(array) && Is_Square_Complete(array);
                Assert.True(result);
            }
        }

        [Fact]
        public void Is_Valid_Suduko_Matrix()
        {
            var result = Suduko.IsValidSuduko(Setup.validMatrix);

            Assert.True(result);
        }

        [Theory]
        [InlineData(new[] { 4, 3, 4, 6, 7, 7, 7 })]
        public void Test_IsContainsDuplicates(object value)
        {
            var expected = ((int[])value).IsContainsDuplicates();
            Assert.True(expected);
        }

        [Theory]
        [InlineData(new[] { 4, 3, 6, 7, 1, 2, 5, })]
        public void Test_IsNotContainsDuplicates(object value)
        {
            var expected = ((int[])value).IsContainsDuplicates();
            Assert.False(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        public void Test_IsValidelement(int value)
        {
            var result = Suduko.IsValidelement(value);
            Assert.True(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(10)]
        public void Test_IsInvalidelement(int value)
        {
            var result = Suduko.IsValidelement(value);
            Assert.False(result);
        }

        [Fact]
        public void Test_PopulateMatrixFromDictionary()
        {
            var expected = new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            var data = new Dictionary<Element, List<int>>();
            data.Add(new Element(0, 0, 1), new List<int>());
            data.Add(new Element(0, 1, 2), new List<int>());
            data.Add(new Element(0, 2, 3), new List<int>());
            data.Add(new Element(1, 0, 4), new List<int>());
            data.Add(new Element(1, 1, 5), new List<int>());
            data.Add(new Element(1, 2, 6), new List<int>());
            data.Add(new Element(2, 0, 7), new List<int>());
            data.Add(new Element(2, 1, 8), new List<int>());
            data.Add(new Element(2, 2, 9), new List<int>());

            var result = Suduko.PopulateMatrix(data);

            Assert.True(expected.Cast<int>().SequenceEqual(result.Cast<int>()));
        }
    }
}