using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    public class Keywords
    {
        /// <summary>
        /// Possible Use:
        /// Custom Memory Allocation
        /// </summary>
        //debug this method
        public static void Test1()
        {
            System.Diagnostics.Debugger.Break();

            int i32 = 10;

            //create typedReference to object (on heap) etc.
            var typeRef = __makeref(i32);
            var type = __reftype(typeRef);
            var value = __refvalue(typeRef, int);
        }

        /// <summary>
        /// smuggling objects - making changes
        /// </summary>
        public static void Test_ForceCastEx()
        {
            var b = Cast.ForceCast<A, B>(new A());
            b.b = 100;

            Print(b);
        }

        private static void Print(B b)
        {
            Console.WriteLine(b.b);
            Console.WriteLine(b.GetType());
        }

        public static void Test_ArglistEx()
        {
            System.Diagnostics.Debugger.Break();

            Arglist(__arglist(1, "aaa", "bbbb"));

        }

        static void Arglist(__arglist)
        {
            var args = new ArgIterator(__arglist);
            var @ref = args.GetNextArg();
        }


    }

    #region ForceCastEx Material

    class A { public int a = 10; }
    class B { public int b = 20; }

    public class Cast
    {
        public static unsafe TOut ForceCast<TIn, TOut>(TIn input)
            where TIn : class
            where TOut : class
        {
            var p = new PinObj<TIn>() { TObj = input };

            var handle = __makeref(input);
            TOut obj = default;

            fixed (void* pin = &p.Pin)
            {
                TypedReference tr = __makeref(obj);
                *(IntPtr*)(&tr) = *(IntPtr*)(&handle);
                return __refvalue(tr, TOut);
            }
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    internal class PinObj<T>
    {
        public T TObj;
        public bool Pin;
    }


    #endregion
}
