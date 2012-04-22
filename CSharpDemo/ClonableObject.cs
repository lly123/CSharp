using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class ClonableObject
    {
        class PointDesc : ICloneable
        {
            public string Name { get; set; }
            public string UId { get; set; }

            public override string ToString()
            {
                return Name + " " + UId;
            }

            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }

        class Point : ICloneable
        {
            private PointDesc _desc = new PointDesc();
            public PointDesc Desc { get { return _desc; } private set { _desc = value; } }
            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return Desc + " X:" + X + " Y:" + Y;
            }

            public object Clone()
            {
                var p = (Point) this.MemberwiseClone();
                p.Desc = (PointDesc) this.Desc.Clone();
                return p;
            }
        }

        public void DoIt()
        {
            var point = new Point();
            point.Desc.Name = "point one";
            point.Desc.UId = "1-2-3";
            point.X = 10;
            point.Y = 20;

            var point2 = (Point)point.Clone();
            point2.Desc.Name = "point two";
            point2.X = 200;

            Console.Out.WriteLine(point);
            Console.Out.WriteLine(point2);
        }
    }
}
