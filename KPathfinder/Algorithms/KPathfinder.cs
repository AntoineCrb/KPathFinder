using System;
using KPathfinder.Utils;
using KPathfinder.Map;
using KPathfinder.Objects;

namespace KPathfinder.Algorithms
{
    public static class KPathfinder
    {
        /// <summary>
        ///     Search if the path can be reached without collision, if not launches the search for the Astar
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static Position[] FindPath(Position start, Position end, IMap map)
        {
            Position[] path = new Position[Math.Max(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y))];
            Position node = start;

            short i = 0;
            while (!node.Equals(end))
            {
                short x = (short)PathfinderHelper.NextCoord(node.X, end.X),
                    y = (short)PathfinderHelper.NextCoord(node.Y, end.Y);
                if (!map.IsWalkable(x, y))
                {
                    return AStar.FindPath(start, end, map);
                }

                node = new Position(x, y);
                path[i++] = node;
            }

            return path;
        }
    }
}