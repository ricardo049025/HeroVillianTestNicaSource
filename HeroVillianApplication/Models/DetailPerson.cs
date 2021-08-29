using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Model;
namespace HeroVillianApplication.Models
{
    public class DetailPerson
    {
        public string response { set; get; }
        public Results Result { set; get; }

        public DetailPerson(string response, Results Result)
        {
            this.response = response;
            this.Result = Result;
        }
    }
}