﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.ModernGraphicsLib
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
