using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public static class TerrainEnumExtensions   //EXTENSION CLASSES AND METHODS HAVE TO BE STATIC
    {
        public static ConsoleColor GetColor(this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS:
                    return ConsoleColor.Green;
                case TerrainEnum.SAND:
                    return ConsoleColor.Yellow;
                case TerrainEnum.WALL:
                    return ConsoleColor.Blue;
                default:
                    return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar(this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS:
                    return '\u201c';
                case TerrainEnum.SAND:
                    return '\u25cb';
                case TerrainEnum.WALL:
                    return '\u2248';
                default:
                    return '\u25cf';
            }
        }
    }
}
