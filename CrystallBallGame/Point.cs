﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame
{
    public struct Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override int GetHashCode()
        {
            return this.X ^ this.Y;
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
        

        public override string ToString()
        {
            return String.Format("({0}, {1})", this.X, this.Y);
        }

        //public static Point Parse(string pointString)
        //{
        //    string coordinatesPairString = pointString.Substring(1, pointString.Length - 2);
        //    string[] coordinates = coordinatesPairString.Split(',');
        //    return new Point(coordinates[0], coordinates[1]);
        //}
    }
}
