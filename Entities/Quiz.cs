using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class Quiz : IEntity
    {
        public int ID { get; set; }

        public string Title { get; set; }

        //public int TimesPlayed { get; set; }

        public int AuthorID { get; set; }
    }
}
