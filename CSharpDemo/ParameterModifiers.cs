using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class ParameterModifiers
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return string.Format("[X:{0},Y:{1}]", X, Y);
            }
        }

        private void SwapTwoInts(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        private void AddTwoInts(int x, int y, out int r)
        {
            r = x + y;
        }

        private void GenerateAPoint(out Point p)
        {
            p = new Point() {X = 10, Y = 20};
        }

        public void DoIt()
        {
            int x = 10, y = 20;
            SwapTwoInts(ref x, ref y);

            Console.Out.WriteLine("X: " + x + " Y: " + y);

            int r;
            AddTwoInts(x, y, out r);

            Console.Out.WriteLine("X + Y = " + r);

            Point p;
            GenerateAPoint(out p);

            Console.Out.WriteLine("Point: " + p);
        }
    }
}
