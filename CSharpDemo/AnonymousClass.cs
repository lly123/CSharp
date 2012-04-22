using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class AnonymousClass
    {
        public void DoIt()
        {
            var point = new { X = 100, Y = 200 };

            Console.Out.WriteLine("X:" + point.X + " Y:" + point.Y);

            IList<String> strarr = new List<string> { "aaa", "abc" };

            var result = from word in strarr where word.Contains("a") select new { Name = word };

            foreach (var item in result)
            {
                Console.Out.WriteLine("Name: " + item.Name);
            }
        }
    }
}
