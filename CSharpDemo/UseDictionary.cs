using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class UseDictionary
    {
        public void DoIt()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary["num1"] = 10;
            dictionary["num2"] = 30;

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.Out.WriteLine(String.Format("[{0}][{1}]", pair.Key, pair.Value));
            }
        }
    }
}
