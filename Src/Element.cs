namespace SudokuSolution
{
    using System;

    /// <summary>
    /// represent element in the suduko grid
    /// </summary>
    public class Element
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int? Value { get; set; }

        public Element()
        {
        }

        public Element(int x, int y, int? value)
        {
            this.X = x;
            this.Y = y;
            this.Value = value;
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
            return Equal((Element)obj);
        }

        private bool Equal(Element other)
        {
            if (this.X != other.X)
            {
                return false;
            }
            if (this.Y != other.Y)
            {
                return false;
            }
            if (!this.Value.Equals(other.Value))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + X.GetHashCode();
            hash = (hash * 7) + Y.GetHashCode();
            hash = (hash * 7) + Value.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return (this.Value == 0 ? " " : this.Value.ToString());
        }

        public string DisplayAsCell()
        {
            return $"({this.X},{this.Y}) [{this.Value}]";
        }
    }
}