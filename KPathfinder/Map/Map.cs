namespace KPathfinder.Map
{
    public class Map : IMap
    {
        public Map(short width, short height, byte[] grid)
        {
            Width = width;
            Height = height;
            Grid = grid;
        }

        public short Width { get; }

        public short Height { get; }

        public byte[] Grid { get; }

        public bool IsWalkable(short x, short y) => Grid[x + y * Width]==0;
    }
}
