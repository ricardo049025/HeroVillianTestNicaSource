using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Domain.DTO
{
    public class SuperPersonDTO
    {
        public int id { set; get; }
        public string name { set; get; }
        public string image { set; get; }
        public string gender { set; get; }
        public string publisher { set; get; }
        public string fullname { set; get; }

    }
}
