using HiddenFeatures.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures
{
    /// <summary>
    /// Teacher: https://github.com/badamczewski?tab=repositories&q=&type=&language=
    /// Youtube: https://www.youtube.com/channel/UCw6BnEkURLprFGx_il2OyUw
    /// Video: https://www.youtube.com/watch?v=B_69UvFFyvY
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dicOptions = new Dictionary<int, string>()
            {
                { 1,"Keywords Test - SingleStep Debug" },
                { 2,"Keywords Test - ForceCast"} ,
                { 3,"Keywords Test - Arglist Example"},

                { 4,"Enumerable Emulation"},

                { 5,"Array Init"},

                { 6 ,"IndexInit"},

                { 7,"Interface object"},

                { 8,"Tuple Deconstruction"},
            };


            foreach (var kvp in dicOptions)
            {
                Console.WriteLine(kvp.Key + "......" + kvp.Value);
            }
            Console.WriteLine(new string('.', 80));

            if (int.TryParse(Console.ReadLine(), out var optionChosen))
            {
                switch (optionChosen)
                {
                    case 1: { Keywords.Test1(); break; }
                    case 2: { Keywords.Test_ForceCastEx(); break; }
                    case 3: { Keywords.Test_ArglistEx(); break; }

                    case 4: { EnumerableEmulation.Test(); break; }
                    case 5: { ArrayInit.Test(); break; }
                    case 6: { IndexInit.Test(); break; }
                    case 7: { DefInterface.Test(); break; }
                    case 8: { TupleDeconstruction.Test(); break; }
                }
            }
            Console.WriteLine(new string('.', 80));
            Console.ReadKey();
        }
    }
}
