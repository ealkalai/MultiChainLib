using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class SignRawTransactionResponse
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }
        

        public SignRawTransactionResponse()
        {            
        }
    }
}
