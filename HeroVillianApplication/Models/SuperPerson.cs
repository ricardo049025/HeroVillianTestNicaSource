using Domain.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroVillianApplication.Models
{
    public class SuperPerson
    {
        public string response { set; get; }
        public List<SuperPersonDTO> superPersonDTO { set; get; }

        public SuperPerson(string response, List<SuperPersonDTO> superPersonDTOs)
        {
            this.response = response;
            this.superPersonDTO = superPersonDTOs;
        }
    }
}