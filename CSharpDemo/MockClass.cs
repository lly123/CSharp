using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;

namespace CSharpDemo
{
    public interface IMockBase
    {
        void ShowMsg();
    }

    public class MockBase : IMockBase
    {
        public virtual void ShowMsg(){}
        public virtual string ToLower(string s)
        {
            return s.ToLower();
        }
        public virtual int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }

    class MockClass
    {
        public void MockAnObject()
        {
            var mock = new Mock<MockBase>();
            mock.Setup(m => m.ShowMsg()).Callback(() => Console.Out.WriteLine("ShowMsg is called."));
            mock.Setup(m => m.ToLower(It.IsAny<string>())).Returns((string s) => s.ToLower());
            mock.Setup(m => m.AddTwoNumbers(10, 8)).Returns((int a, int b) => a + b);

            mock.Object.ShowMsg();
            Console.Out.WriteLine("Convert 'ABC' to lower case: " + mock.Object.ToLower("ABC"));
            Console.Out.WriteLine("10 + 8 = " + mock.Object.AddTwoNumbers(10, 8));

            mock.VerifyAll();
        }

        public void DoIt()
        {
            MockAnObject();
        }
    }
}
