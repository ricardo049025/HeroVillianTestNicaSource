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
        public int intelligence { set; get; }
        [JsonProperty("strength")]
        public int strength { set; get; }
        [JsonProperty("speed")]
        public int speed { set; get; }
        [JsonProperty("durability")]
        public int durability { set; get; }
        [JsonProperty("power")]
        public int power { set; get; }
        [JsonProperty("combat")]
        public int combat { set; get; }
    }
}
