namespace KPathfinder.Objects
{
    public class Position
    {
        public Position(short x, short y)
        {
            X = x;
            Y = y;
        }

        public short X { get; set; }
        public short Y { get; set; }

        public bool Equals(Position o) => X == o.X && Y == o.Y;
    }
}
