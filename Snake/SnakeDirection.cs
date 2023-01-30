
using System;
using System.Collections.Generic;

namespace Snake
{
    public class SnakeDirection
    {
        public readonly static SnakeDirection left = new SnakeDirection(0, -1);
        public readonly static SnakeDirection right = new SnakeDirection(0, 1);
        public readonly static SnakeDirection down = new SnakeDirection(1, 0);
        public readonly static SnakeDirection up = new SnakeDirection(-1, 0);
        public int RowOffset { get; }
        public int ColOffset { get; }
        private SnakeDirection(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }
        public SnakeDirection Opposite()
        {
            return new SnakeDirection(-RowOffset, -ColOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is SnakeDirection direction &&
                   RowOffset == direction.RowOffset &&
                   ColOffset == direction.ColOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffset);
        }

        public static bool operator ==(SnakeDirection left, SnakeDirection right)
        {
            return EqualityComparer<SnakeDirection>.Default.Equals(left, right);
        }

        public static bool operator !=(SnakeDirection left, SnakeDirection right)
        {
            return !(left == right);
        }
    }
}
