using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class CreateRawTransactionAmount
    {
        public string Address { get; set; }
        public Decimal Qty { get; set; }
        
        public CreateRawTransactionAmount()
        {                        
        }

        //"1DK3fuhpAqHWAvNtbWHqsyHYxUsK38N878t3nZ":qty, 
        public virtual object StringifyAmount()
        {            
            return Qty;
        }
    }

    public class CreateRawTransactionAsset: CreateRawTransactionAmount
    {
        public string Name { get; set; }
        public CreateRawTransactionAsset() { }

        //"1DK3fuhpAqHWAvNtbWHqsyHYxUsK38N878t3nZ":{"asset":qty}, 
        public override object StringifyAmount()
        {
            dynamic flexible;
            flexible = new System.Dynamic.ExpandoObject();
            var dictionary = (IDictionary<string, object>)flexible;
            dictionary.Add(Name, Qty);
            
            return dictionary;
        }
    }
}
