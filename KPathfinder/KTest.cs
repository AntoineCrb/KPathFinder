using System;
using System.Linq;
using KPathfinder.Map;
using KPathfinder.Objects;

namespace KTest
{
    internal class KTest
    {
        private static void Main()
        {
            // Test Values
            short rep = 1;
            short width = 5, height = 5;
            Position start = new Position(0, 0), end = new Position(4, 4);
            var grid = new byte[]
            {
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
            };
            //

            DateTime t = DateTime.Now;
            Position[] path = null;
            for (int a = 0; a < rep; a++)
            {
                path = KPathfinder.Algorithms.AStar.FindPath(start, end, new Map(width, height, grid));
            }

            Console.Write($"Time used for {rep} repetitions : {DateTime.Now - t}\n" + (path == null
                              ? "Impossible Path"
                              : "Path:\n" + path.Aggregate("", (a, b) => a + $"x: {b.X}, y: {b.Y}\n")));
        }
    }
}
