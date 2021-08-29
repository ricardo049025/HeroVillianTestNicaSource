using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Model
{
    public class Connections
    {
        
        [JsonProperty("group-affiliation")]
        public string groupaffiliation { set; get; }
        [JsonProperty("relatives")]        
        public string relatives { set; get; }
    }
}
