using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRA_WebAPI.Entities
{
    public class Answer : IEntity
    {
        public int ID { get; set; } /*promijeniti svaki entitet u bazi da ima isti PK (ID)*/
        public string AnswerText { get; set; } /*'promijeniti u bazi'*/
        public bool Correct { get; set; }

        public int QuestionID { get; set; }
        public int AnswerOrder { get; set; }
    }
}
