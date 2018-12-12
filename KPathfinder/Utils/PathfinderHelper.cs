using KPathfinder.Map;
using KPathfinder.Objects;

namespace KPathfinder.Utils
{
    public static class PathfinderHelper
    {
        private static readonly sbyte[,] Neighbours =
        {
            { -1, -1 }, { 0, -1 }, { 1, -1 },
            { -1, 0 }, { 1, 0 },
            { -1, 1 }, { 0, 1 }, { 1, 1 }
        };

        /// <summary>
        ///     Returns an Array with the neighbors of the given position
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static Position[] GetNeighbors(Position pos, IMap map)
        {
            Position[] neighbors = new Position[8];
            byte a = 0;
            for (byte i = 0; i < 8; i++)
            {
                short x = (short)(pos.X + Neighbours[i, 0]),
                    y = (short)(pos.Y + Neighbours[i, 1]);
                if (x >= 0 && x < map.Width && y >= 0 && y < map.Height && map.IsWalkable(x, y))
                {
                    neighbors[a++] = new Position(x, y);
                }
            }

            return neighbors;
        }

        /// <summary>
        ///     Returns the next coordinate of a collision-free path
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static int NextCoord(short s, short e) => s - e >= 1 ? s - 1 : e == s ? e : s + 1;
    }
}