using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УВ_30МКР.Test
{
    public class Quations
    {
        public string ImageSourse { get; set; }
        public string QuationSourse { get; set; }
        public Hashtable answer = new Hashtable();

        public void QuestionAndAnswerNumberOne()
        {
            answer[1] = "Сколько тебе лет?";
            answer[2] = "Как дела?";
            answer[3] = "Как тебя зовут?";
            answer[4] = "Где ты живешь?";
        }
    }
}
