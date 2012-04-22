using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class RethrowException
    {
        public void ThrowException()
        {
            try
            {
                throw new Exception("An Exception.");
            } catch(Exception expt)
            {
                Console.Out.WriteLine("Message: " + expt.Message);
                throw;
            }
        }

        public void DoIt()
        {
            try
            {
                ThrowException();
            } catch(Exception expt) 
            {
                Console.Out.WriteLine("Same Message: " + expt.Message);
            } finally
            {
                Console.Out.WriteLine("In Finally Block.");
            }
        }
    }
}
