using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class VerbatimString
    {
        private readonly string ReadOnlyString = "Read only string must be out of method and default is not static";

        public void DoIt()
        {
            const string constantString = @"This string contains \ and "" and \n and \t.";
            Console.Out.WriteLine("const string: " + constantString);

            Console.Out.WriteLine("readonly string: " + ReadOnlyString);
        }
    }
}
