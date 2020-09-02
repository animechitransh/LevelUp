using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    /// <summary>
    /// Beautiful collection initialization
    /// </summary>
   public static class ArrayInit
    {
        public static void Test()
        {
            //this internally uses Add and Ienumerble interface
            ArrayInitializer arrayInitializer = new ArrayInitializer()
            {
                1,2,3
            };
        }
    }

    public class ArrayInitializer : IEnumerable
    {
        public void Add(int a) { }
        public IEnumerator GetEnumerator()
        {
            return null;
        }
    }
}
