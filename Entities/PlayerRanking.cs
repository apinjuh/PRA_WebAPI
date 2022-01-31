using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class PlayerRanking: IEntity

    {

        public int ID { get; set; }

        public int PlayerID { get; set; }

        public int TotalPoints { get; set; }

        public int Ranking { get; set; }
    }
}
