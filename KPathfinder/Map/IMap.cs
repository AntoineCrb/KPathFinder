namespace KPathfinder.Map
{
    public interface IMap
    {
        /// <summary>
        ///     Map Width
        /// </summary>
        short Width { get; }

        /// <summary>
        ///     Map Height
        /// </summary>
        short Height { get; }

        /// <summary>
        ///     Get the Map Grid
        /// </summary>
        byte[] Grid { get; }

        /// <summary>
        ///     Get if the map is walkable
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        bool IsWalkable(short x, short y);
    }
}
