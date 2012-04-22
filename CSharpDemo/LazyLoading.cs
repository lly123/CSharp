using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDemo
{
    class BigArray<T>
    {
        private readonly T[] _array;

        public BigArray(int capacity)
        {
            _array = new T[capacity];
        }

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
    }

    class LazyLoading
    {
        public void DoIt()
        {
            var bigArray = new Lazy<BigArray<int>>(() => new BigArray<int>(100));
            bigArray.Value[0] = 100;
            Console.Out.WriteLine(">>> " + bigArray.Value[0]);
        }
    }
}
