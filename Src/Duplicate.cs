namespace SudokuSolution
{
    /// <summary>
    /// represent the duplicates fount either in row, column or box
    /// </summary>
    public class Duplicate
    {
        public Duplicate(Element element, DuplicateLocation duplicateLocation)
        {
            DuplicateType = duplicateLocation;
            Element = element;
        }

        /// <summary>
        /// the duplicate type either in row, column or square
        /// </summary>
        public DuplicateLocation DuplicateType { get; set; }

        /// <summary>
        /// the index where the duplicate occure
        /// </summary>
        public Element Element { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equal((Duplicate)obj);
        }

        private bool Equal(Duplicate other)
        {
            if (this.DuplicateType != other.DuplicateType)
            {
                return false;
            }
            if (!this.Element.Equals(other.Element))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + DuplicateType.GetHashCode();
            hash = (hash * 7) + Element.GetHashCode();
            return hash;
        }
    }
}