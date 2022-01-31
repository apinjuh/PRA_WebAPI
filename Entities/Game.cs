using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class Game: IEntity
    {

        public int ID { get; set; }
        public DateTime DatePlayed { get; set; }

        public int QuizID { get; set; }
        public string GamePIN { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
       /* public int PlayerID { get; set; }*/ /*- promijeniti u bazi iako mislim da ovaj podatak ne bi trebao biti tu, nego da se za igrača veže koje igre je igrao*/
    }
}
