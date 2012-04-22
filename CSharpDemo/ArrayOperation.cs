using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class ArrayOperation
    {
        class Base
        {
            private readonly int _value;

            public Base(int value)
            {
                _value = value;
            }

            public int Value { get { return _value; } }
        }

        sealed class Derived : Base
        {
             public Derived() : base(10) {}
        }

        public void DoIt()
        {
            var stringArray1 = new string[] {"A", "B", "C"};
            Array.Reverse(stringArray1);

            string[] stringArray2 = {"Hello", "World"};
            Array.Sort(stringArray2);
            
            var r = stringArray2.Concat(stringArray1);
            foreach(var i in r)
            {
                Console.Out.WriteLine(">>> " + i);
            }

            var d = new Derived();
            Console.Out.WriteLine("Value: " + d.Value);
        }
    }
}
