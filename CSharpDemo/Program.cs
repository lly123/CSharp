using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonymousClass = new AnonymousClass();
            anonymousClass.DoIt();

            var verbatimString = new VerbatimString();
            verbatimString.DoIt();

            var explicitAndImplicitCast = new ExplicitAndImplicitCast();
            explicitAndImplicitCast.DoIt();

            var lazyLoading = new LazyLoading();
            lazyLoading.DoIt();

            var parameterModifiers = new ParameterModifiers();
            parameterModifiers.DoIt();

            var arrayOperation = new ArrayOperation();
            arrayOperation.DoIt();

            var rethrowException = new RethrowException();
            rethrowException.DoIt();

            Console.In.ReadLine();
        }
    }
}
