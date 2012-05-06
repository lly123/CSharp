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

            var finalization = new Finalization();
            finalization.DoIt();

            var clonableObject = new ClonableObject();
            clonableObject.DoIt();

            var mockClass = new MockClass();
            mockClass.DoIt();

            var useThread = new UseThread();
            useThread.DoIt();

            var usingRegex = new UsingRegex();
            usingRegex.DoIt();

            Console.In.ReadLine();
        }
    }
}
