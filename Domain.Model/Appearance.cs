using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Model
{
    public class Appearance
    {
        [JsonProperty("gender")]
        public string gender { set; get; }
        [JsonProperty("race")]
        public string race { set; get; }
        [JsonProperty("height")]
        public string[] height { set; get; }
        [JsonProperty("weight")]        
        public string[] weight { set; get; }
        [JsonProperty("eye-color")]        
        public string eyecolor { set; get; }
        [JsonProperty("hair-color")]        
        public string haircolor { set; get; }
    }
}
