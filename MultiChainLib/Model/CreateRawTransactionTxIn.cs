using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class CreateRawTransactionTxIn
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }

        
        public CreateRawTransactionTxIn()
        {                        
        }


    }
}
