using App_test_csharp;
using ClassesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClassesLibrary.Controller
{
    public class CQuestion
    {

        public void pressButton(string textBtn)
        {
            if (n < questions.Count)
            {
                answerIsCorrect(textBtn);
                updateQuestion(questions[sequenceQuestions[n]]);
                n++;
            }
            else
            {
                FrmResultados frmResults = new FrmResultados();
                CResults cResults = new CResults(frmResults, questions);
                frmResults.Show();
                view.Close();
            }
        }

        public void answerIsCorrect(string textBtn)
        {
            Question question = questions[sequenceQuestions[n - 1]];
            Console.WriteLine(textBtn + " == " + question.CorrectAnswer);
            if (textBtn.Equals(question.CorrectAnswer))
            {
                question.IsCorrect = true;
            }
        }

        public void updateQuestion(Question nextQuestion)
        {
            Console.WriteLine(nextQuestion);
            int i = 0;
            foreach (string answers in nextQuestion.Answers)
            {//Recorre todas las preguntas
                btnAnswers[i].Content = answers;
                i++;
            }
            view.LblPregunta.Content = nextQuestion.QuestionLabel;
            view.LblImagenPregunta.Background = nextQuestion.ImageLabel;
            Console.WriteLine("Question updated\n\n");
        }

        public void getSequence(int max)
        {
            //Generate a random sequence for questions in test
            Random rnd = new Random();
            for (int i = 0; i < max; i++)
            {
                int aleatorio = -1;
                bool generado = false;

                while (!generado)
                {
                    int number = rnd.Next(max);
                    if (!sortedQuestions.Contains(number))
                    {
                        sortedQuestions.Add(number);
                        aleatorio = number;
                        generado = true;
                    }
                }
                sequenceQuestions.Add(aleatorio);
            }
            Console.WriteLine(sequenceQuestions.ToString());
        }

        private FrmQuestions view;
        private Question model;
        private Test testModel = new Test();
        private Button[] btnAnswers = new Button[4];
        private List<Question> questions = null;
        private HashSet<int> sortedQuestions = new HashSet<int>();
        private List<int> sequenceQuestions = new List<int>();
        private int n = 1;
    }
}
