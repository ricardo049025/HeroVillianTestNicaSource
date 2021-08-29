using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Domain.Model
{
    public class Image
    {
        [JsonProperty("url")]
        public string url { set; get; }
    }
}
