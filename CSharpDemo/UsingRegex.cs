using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpDemo
{
    class UsingRegex
    {
        public void DoIt()
        {
            var regex = new Regex("l[ao]g", RegexOptions.IgnoreCase);
            const string LogIsLag = "log is lag";

            if(regex.IsMatch(LogIsLag))
            {
                var matchCollection = regex.Matches(LogIsLag);
                Console.Out.WriteLine("Match string 1: " + matchCollection[0]);
                Console.Out.WriteLine("Match string 2: " + matchCollection[1]);
            }

            var replaceStr = regex.Replace("log is lag", "Word");
            Console.Out.WriteLine("Replaced 'log is lag': " + replaceStr);

            replaceStr = regex.Replace("log is LAG", new MatchEvaluator(MatchOutput));
            Console.Out.WriteLine("Replaced 'log is LAG': " + replaceStr);
        }

        private string MatchOutput(Match m)
        {
            return "[" + m.Value + "]";
        }
    }
}
