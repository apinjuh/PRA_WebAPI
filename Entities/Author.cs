using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class Author: IEntity
    {
        public int ID { get; set; }

        public string Email { get; set; }
        public string Passw { get; set; }
       
    }
}
