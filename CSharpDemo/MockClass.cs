using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;

namespace CSharpDemo
{
    public class MockBase
    {
        public int Add()
        {
            return 10;
        }
    }

    public class MockDerived : MockBase
    {
        public new int Add()
        {
            return 20;
        }
    }

    class MockClass
    {
        public void DoIt()
        {
//            var mockObj = new Mock<MockBase>();
//            mockObj.Setup(o => o.Add()).Returns(100);
//
//            Console.Out.WriteLine("Mock: " + mockObj.Object.Add());
//
//            mockObj.Verify();

            MockDerived mb = new MockDerived();
            Console.Out.WriteLine("Add: " + mb.Add());
        }
    }
}
