using System;

namespace ConsoleAppHashes
{
    class Point
    {
        internal int x;
        internal int y;
    }
    class Rect
    {
        int x;
        int y;
        int width;
        int height;

        public Rect(int X, int Y, int Width, int Height)
        {
            x = X;
            y = Y;
            width = Width;
            height = Height;
        }

        public bool TestPointWithinRectangle(Point p)
        {
            if (p == null )
                throw new ArgumentNullException("The Point argument cannot be null!");

            if (x <= p.x && p.x <= x + width &&
                y <= p.y && p.y <= y + height)
                return true;

            return false;
        }
    }

    //class TestRectangles
    //{
    //    public bool TestPointWithinRectangle(Point p, Rect rect)
    //    {
    //        if (p == null || rect == null)
    //            throw new ArgumentNullException("Neither the Point nor the Rectangle arguments cannot be null!");

    //        if(rect.x <= p.x)
    //    }

    //}
}
