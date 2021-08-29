using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Main.Helpers
{
    /// <summary>
    /// Ricardo Martinez.
    /// Helper utility generic methods
    /// </summary>
    public static class HelperUtility<TEntity> where TEntity : class
    {
        /// <summary>
        /// Ricardo Martinez. Method for parse a json format
        /// to object 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static TEntity convertJsonToObject(string json)
        {
            return JsonConvert.DeserializeObject<TEntity>(json);
        }
    }
}
