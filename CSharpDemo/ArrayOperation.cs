using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class ArrayOperation
    {
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
        }
    }
}
