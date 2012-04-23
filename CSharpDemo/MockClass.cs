using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;

namespace CSharpDemo
{
    public class Base
    {
        public virtual int Add()
        {
            return 10;
        }
    }

    class MockClass
    {
        public void DoIt()
        {
            var mockObj = new Mock<Base>();
            mockObj.Setup(o => o.Add()).Returns(100);

            Console.Out.WriteLine("Mock: " + mockObj.Object.Add());
            mockObj.Verify();
        }
    }
}
