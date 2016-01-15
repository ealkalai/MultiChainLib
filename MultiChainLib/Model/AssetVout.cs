using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class AssetVout
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("issuetxid")]
        public string IssueTxId { get; set; }

        [JsonProperty("assetref")]
        public string AssetRef { get; set; }
        
        [JsonProperty("qty")]
        public decimal Qty { get; set; }

        [JsonProperty("raw")]
        public long Raw { get; set; }
    }
}
