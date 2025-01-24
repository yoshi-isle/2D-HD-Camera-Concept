using System.Collections.Generic;

public static class CameraDirectionHelper
{
    public enum Direction
    {
        NORTH,
        SOUTH,
        WEST,
        EAST
    }

    public static Dictionary<float, Direction> directionIndex = new Dictionary<float, Direction>
    {
        {0, Direction.SOUTH},
        {90, Direction.WEST},
        {180, Direction.NORTH},
        {270, Direction.EAST},
        {360, Direction.SOUTH},
    };
}