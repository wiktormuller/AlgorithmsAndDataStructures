using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transport)
        {
            switch(transport)
            {
                case TransportEnum.BIKE:
                    return 'R';
                case TransportEnum.BUS:
                    return 'A';
                case TransportEnum.CAR:
                    return 'S';
                case TransportEnum.SUBWAY:
                    return 'M';
                case TransportEnum.WALK:
                    return 'P';
                default: throw new Exception("Nieznany środek transportu.");
            }
        }
        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch(transport)
            {
                case TransportEnum.BIKE:
                    return ConsoleColor.Blue;
                case TransportEnum.BUS:
                    return ConsoleColor.DarkGreen;
                case TransportEnum.CAR:
                    return ConsoleColor.Red;
                case TransportEnum.SUBWAY:
                    return ConsoleColor.DarkMagenta;
                case TransportEnum.WALK:
                    return ConsoleColor.DarkYellow;
                default:
                    throw new Exception("Nieznany środek transportu.");
            }
        }
    }
}
