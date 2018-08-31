namespace SudokuSolution
{
    /// <summary>
    /// represent error found while solving suduko grid
    /// </summary>
    public class Error
    {
        public BlockIssue BlockIssue { get; set; }
        public Element Element { get; set; }

        public Error(BlockIssue blockIssue, Element element = null)
        {
            this.BlockIssue = blockIssue;
            this.Element = element;
        }

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
            return Equal((Error)obj);
        }

        private bool Equal(Error other)
        {
            if (this.BlockIssue != other.BlockIssue)
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
            hash = (hash * 7) + BlockIssue.GetHashCode();
            hash = (hash * 7) + Element.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"{this.Element.DisplayAsCell()} {BlockIssue.GetDisplayName()}";
        }
    }
}