using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class Question: IEntity
    {
        public int ID { get; set; }
        public string QuestionText { get; set; } /*-promijeniti u bazi*/

        public int TimeLimit { get; set; }

        public int QuizID { get; set; }

        public int QuestionOrder { get; set; }
    }
}
