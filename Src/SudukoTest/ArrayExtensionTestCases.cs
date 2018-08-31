namespace SudukoTest
{
    using SudokuSolution;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class ArrayExtensionTestCases
    {
        [Theory]
        [InlineData(new[] { 1, 3, 5, 6, 7 })]
        public void Test_GetDuplicates_Of_Given_Return_Empty(object value)
        {
            var expected = new int[] { };
            var entries = (int[])value;
            var result = entries.GetDuplicates();
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(new[] { 4, 3, 4, 6, 7, 7, 7 })]
        public void Test_GetDuplicates_Of_Given_Return_4_And_7(object value)
        {
            var expected = new int[] { 4, 7 };
            var entries = (int[])value;
            var result = entries.GetDuplicates();
            Assert.Equal(result, expected);
        }

        [Fact]
        public void Test_GetDuplicateObjects_ShoudReturn_listOf_3_Duplicates()
        {
            var expected = new List<Duplicate>();

            expected.Add(new Duplicate(new Element(0, 3, 2), DuplicateLocation.Row));
            expected.Add(new Duplicate(new Element(0, 6, 2), DuplicateLocation.Row));
            expected.Add(new Duplicate(new Element(1, 5, 8), DuplicateLocation.Row));
            expected.Add(new Duplicate(new Element(1, 6, 8), DuplicateLocation.Row));
            expected.Add(new Duplicate(new Element(0, 5, 4), DuplicateLocation.Column));
            expected.Add(new Duplicate(new Element(3, 5, 4), DuplicateLocation.Column));
            expected.Add(new Duplicate(new Element(7, 0, 7), DuplicateLocation.Square));
            expected.Add(new Duplicate(new Element(7, 5, 7), DuplicateLocation.Square));

            var result = Setup.matrixWithAllTypeOfDuplicates.GetDuplicateObjects<int>();

            Assert.True(result.SequenceEqual(expected));
        }

        [Fact]
        public void GetRow_Of_1_ShouldReturn()
        {
            int[] expected = { 0, 4, 0, 0, 0, 8, 2, 6, 3 };

            var result = Setup.validMatrix.GetRow(1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetColumn_Of_1_ShouldReturn()
        {
            int[] expected = { 0, 4, 0, 0, 3, 0, 1, 0, 0 };

            var result = Setup.validMatrix.GetColumn(1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetSquare_Of_element_ShouldReturn_Square()
        {
            Element element = new Element
            {
                Value = 2,
                X = 5,
                Y = 4
            };
            int[] expected = { 0, 4, 0, 8, 2, 0, 5, 9, 0 };

            var result = Setup.validMatrix.GetSquare(element);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Subtract()
        {
            var array1 = new int[] { 1, 2, 4, 5, 6, 7 };
            var array2 = new int[] { 2, 4, 5 };

            var expected = new int[] { 1, 6, 7 };
            var result = array1.Subract(array2);
            Assert.Equal(expected, result);
        }
    }
}