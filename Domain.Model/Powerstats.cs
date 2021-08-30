using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Model
{
    public class Powerstats
    {
        [JsonProperty("intelligence")]
        public string intelligence { set; get; }
        [JsonProperty("strength")]
        public string strength { set; get; }
        [JsonProperty("speed")]
        public string speed { set; get; }
        [JsonProperty("durability")]
        public string durability { set; get; }
        [JsonProperty("power")]
        public string power { set; get; }
        [JsonProperty("combat")]
        public string combat { set; get; }
    }
}
