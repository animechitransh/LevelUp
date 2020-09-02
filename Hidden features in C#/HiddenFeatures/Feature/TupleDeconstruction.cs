using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenFeatures.Feature
{
    /// <summary>
    /// new C# feature
    /// 
    /// </summary>
    public static class TupleDeconstruction
    {
        public static void Test()
        {
            Transaction transaction = new Transaction();
            var (id, name) = transaction;

            Console.WriteLine(id);
            Console.WriteLine(name);

        }
    }

    internal class Transaction
    {
        public int ID;
        public string Name;
        public decimal[] PartialPayments;
        public DateTime dateTime;
        public string Note;

        /// <summary>
        /// create different signature of method Deconstruct
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void Deconstruct(out int id, out string name)
        {
            id = ID;
            name = Name;
        }

        public Transaction()
        {
            ID = 12;
            Name = "Niha";
        }
    }
}
