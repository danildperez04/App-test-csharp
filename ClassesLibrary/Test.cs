using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Test
    {
        public List<Question> Questions { get => questions; set => questions = value; }
        public bool Completed { get => completed; set => completed = value; }

        public void AddQuestion(Question question)
        {
            this.questions.Add(question);
        }

        private List<Question> questions = new List<Question>();
        private bool completed;
    }
}
