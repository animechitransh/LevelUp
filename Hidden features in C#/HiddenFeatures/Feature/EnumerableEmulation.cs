using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    public static class EnumerableEmulation
    {
        public static void Test()
        {
            System.Diagnostics.Debugger.Break();

            EnumerableClass enumerableClass = new EnumerableClass();
            foreach (var item in enumerableClass)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class EnumerableClass
    {
        public FakeEnumerator GetEnumerator()
        {
            return new FakeEnumerator();
        }
    }

    public class FakeEnumerator 
    {
        public string Current
        {
            get
            {
                return "Hello!";
            }
        }

        public void Dispose() { }
        public bool MoveNext() { return true; }

        public void Reset() { }

    }
}
