using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ClassesLibrary.Model
{
    public class Question
    {
        //Constructors
        public Question() { }

        public Question(String questionLabel, String[] answers, String src, int idQuestion, String correctAnswer, String link)
        {
            this.questionLabel = questionLabel;
            this.answers = answers;
            this.isCorrect = false;
            this.imageLabel = imageLabel;
            this.correctAnswer = correctAnswer;
            this.link = link;
            this.idQuestion = idQuestion;
        }

        //Properties
        public string QuestionLabel { get => questionLabel; set => questionLabel = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public bool IsCorrect { get => isCorrect; set => isCorrect = value; }
        public ImageBrush ImageLabel { get => imageLabel; set => imageLabel = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string Link { get => link; set => link = value; }
        public int IdQuestion { get => idQuestion; set => idQuestion = value; }

        //Fields
        private string questionLabel;
        private string[] answers;
        private bool isCorrect;
        private ImageBrush imageLabel;
        private string correctAnswer;
        private string link;
        private int idQuestion;
    }
}
