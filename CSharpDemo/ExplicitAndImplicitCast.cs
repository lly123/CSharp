using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static explicit operator Line(Point p)
        {
            return new Line
            {
                P1 = new Point { X = 0, Y = 0 },
                P2 = p
            };
        }

        public override string ToString()
        {
            return "X: " + X + " Y: " + Y;
        }
    }

    class Line
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
    }

    class ExplicitAndImplicitCast
    {
        public void DoIt()
        {
            var point = new Point { X = 30, Y = 80 };
            var line = (Line)point;

            Console.Out.WriteLine(String.Format("P1: [{0}], P2: [{1}]", line.P1, line.P2));
        }
    }
}
