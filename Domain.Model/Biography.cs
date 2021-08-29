using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Model
{
    public class Biography
    {
        
        [JsonProperty("full-name")]
        public string fullname {set;get;}        
        [JsonProperty("alter-egos")]
        public string alteregos { set; get; }
        [JsonProperty("aliases")]        
        public string[] aliases { set; get; }
        [JsonProperty("place-of-birth")]
        public string placeofbirth { set; get; }
        [JsonProperty("first-appearance")]
        public string firstappearance { set; get; }        
        [JsonProperty("publisher")]
        public string publisher { set; get; }        
        [JsonProperty("alignment")]
        public string alignment { set; get; }
    }
}
