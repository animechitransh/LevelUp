using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    /// <summary>
    /// cool class initilization
    /// </summary>
    public static class IndexInit
    {
        public static void Test()
        {
            System.Diagnostics.Debugger.Break();

            //this internally uses Add and Ienumerble interface
            IndexInitializer indexInitializer = new IndexInitializer()
            {
                ["a"] = 1,
                ["b"] = 2
            };
        }
    }

    public class IndexInitializer
    {

        public object this[string key]
        {
            get { return null; }
            set { Console.WriteLine($"{key}={value}"); }
        }
    }
}
