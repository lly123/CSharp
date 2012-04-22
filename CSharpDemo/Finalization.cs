using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class FinalizableObject : IDisposable
    {
        private bool disposed = false;

        ~FinalizableObject()
        {
            CleanUp(false);
        }

        public void Dispose()
        {
            CleanUp(true);
            System.GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.Out.WriteLine("FinalizableObject is disposed.");
                }
                Console.Out.WriteLine("FinalizableObject is finalized.");
            }
            disposed = true;
        }
    }

    class Finalization
    {
        public void DoIt()
        {
            using(var finalizableObject = new FinalizableObject())
            {
                Console.Out.WriteLine("Do Something.");                
            }
            System.GC.Collect();
        }
    }
}
