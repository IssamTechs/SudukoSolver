namespace SudokuSolution
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    public enum BlockIssue
    {
        [Display(Name = "Matrix Not Square")]
        MatrixNotSquare,

        [Display(Name = "Invalid 9 X 9 matrix")]
        Invalid9By9,

        [Display(Name = "Duplicate element")]
        Duplicateelement,

        [Display(Name = "Invalid element")]
        Invalidelement,

        [Display(Name = "Dead End")]
        DeadEnd,
    }

    public static class EnumExtension
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()?
                            .GetMember(enumValue.ToString())?
                            .First()?
                            .GetCustomAttribute<DisplayAttribute>()?
                            .Name;
        }
    }
}