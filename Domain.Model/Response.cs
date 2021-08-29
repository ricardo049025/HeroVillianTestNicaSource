
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Domain.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Response
    {
        [JsonProperty("response")]
        public string response { set; get; }

        [JsonProperty("results-for")]
        public string resultfor { set; get; }

        [JsonProperty("error")]
        public string error { set; get; }

        [JsonProperty("results")]
        public List<Results> results { set; get; }
    }
}
