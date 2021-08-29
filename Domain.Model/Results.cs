using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Model
{

    public class Results
    {
        [JsonProperty("id")]
        public int id { set; get; }
        [JsonProperty("response")]
        public string response { set; get; }
        [JsonProperty("error")]
        public string error { set; get; }
        [JsonProperty("name")]
        public string name { set; get; }
        [JsonProperty("powerstats")]
        public Powerstats powerstats { set; get; }
        [JsonProperty("biography")]
        public Biography biography { set; get; }
        [JsonProperty("appearance")]
        public Appearance appearance { set; get; }
        [JsonProperty("work")]
        public Work work { set; get; }
        [JsonProperty("connections")]
        public Connections connections { set; get; }
        [JsonProperty("image")]
        public Image image { set; get; }
    }
}
