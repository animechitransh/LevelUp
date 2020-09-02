using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    /// <summary>
    /// Interface default implentations were possible sing .net2.0 times
    /// (new .net gives nices way of doing this)
    /// Used to do Com Interop as over there Interface has default Implentaion
    /// There are better ways now
    /// </summary>
    public static class DefInterface
    {
        public static void Test()
        {
            ITest test = new ITest();
            test.Do();

        }
    }

    [ComImport,Guid("78c347ed-4efd-4129-8bf5-00133e64f76e"),
    CoClass(typeof(Test))]
    public interface ITest
    {
        void Do();
    }

    public class Test : ITest
    {
        public void Do()
        {
            Console.WriteLine("Executing Do");
        }
    }
}
