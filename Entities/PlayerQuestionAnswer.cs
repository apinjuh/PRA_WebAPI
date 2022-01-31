using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class PlayerQuestionAnswer: IEntity
    {

        public int ID { get; set; }

        public int PlayerID { get; set; }

        public int QuestionID { get; set; }

        public int AnswerID { get; set; }

        public int AnswerTime { get; set; }

        public int Points { get; set; }
    }
}
