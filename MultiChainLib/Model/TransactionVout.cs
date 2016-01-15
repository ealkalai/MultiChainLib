using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiChainLib
{
    public class TransactionVout
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("n")]
        public int N { get; set; }

        [JsonProperty("scriptPubKey")]
        public ScriptPubKeyResponse ScriptPubKey { get; set; }

        [JsonProperty("assets")]
        public List<AssetVout> Assets { get; set; }

        [JsonProperty("permissions")]
        public List<PermissionsResponse> Permissions { get; set; }

        public TransactionVout()
        {
            this.Assets = new List<AssetVout>();
            this.Permissions = new List<PermissionsResponse>();
        }
    }
}
