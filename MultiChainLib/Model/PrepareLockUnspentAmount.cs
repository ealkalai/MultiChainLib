using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class PrepareLockUnspentAmount
    {
        public string Name { get; set; }
        public Decimal Qty { get; set; }

        public PrepareLockUnspentAmount() { }
        public PrepareLockUnspentAmount(string name, decimal qty) { Name = name; Qty = qty; }

        public object StringifyAmount()
        {
            dynamic flexible;
            flexible = new System.Dynamic.ExpandoObject();
            var dictionary = (IDictionary<string, object>)flexible;
            dictionary.Add(Name, Qty);

            return dictionary;
        }
    }
}
