using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace Domain.Model
{
    public class Work
    {
        [JsonProperty("occupation")]        
        public string occupation { set; get; }
        [JsonProperty("base")]
        public string basee { set; get; }
    }
}
