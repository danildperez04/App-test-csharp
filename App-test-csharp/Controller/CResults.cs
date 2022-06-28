using App_test_csharp;
using ClassesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ClassesLibrary.Controller
{
    public class CResults
    {
        public CResults() { }
        public CResults(FrmResultados view, List<Question> model)
        {
            this.view = view;
            questions = model;
            btnsHelp = new Button[] { view.Button1, view.Button2, view.Button3, view.Button4, view.Button5, view.Button6, view.Button7, view.Button8, view.Button9, view.Button10 };
            questionsLabel = new Label[] { view.Question1, view.Question2, view.Question3, view.Question4, view.Question5, view.Question6, view.Question7, view.Question8, view.Question9, view.Question10 };
            initBtnsHelp();
            initQuestionsLabel();
            initScore();
        }

        public void initScore()
        {
            float acum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (questions[i].IsCorrect)
                {
                    acum++;
                }
            }
            view.Score.Content = acum / 10 * 100 + "% |  " + Math.Round(acum) + "/10";
        }

        public void initBtnsHelp()
        {
            for (int i = 0; i < 10; i++)
            {
                Button actualButton = btnsHelp[i];
                string actualLink = questions[i].Link;
                //Falta logica de links
                actualButton.Click += actualButton_Click;

                void actualButton_Click(object sender, EventArgs e)
                {
                    System.Diagnostics.Process.Start(actualLink);
                }
            }
        }



        public void initQuestionsLabel()
        {
            for (int i = 0; i < 10; i++)
            {
                Label actualQuestionLabel = questionsLabel[i];
                actualQuestionLabel.Content = questions[i].QuestionLabel;
                Color verde = (Color)ColorConverter.ConvertFromString("#FF00C807");
                Color rojo = (Color)ColorConverter.ConvertFromString("#FF00C807");
                if (questions[i].IsCorrect)
                {
                    actualQuestionLabel.BorderBrush = new SolidColorBrush(verde);
                }
                else
                {
                    actualQuestionLabel.BorderBrush = new SolidColorBrush(rojo);
                }
            }
        }

        private FrmResultados view;
        private static string carnet;
        private Button[] btnsHelp = new Button[10];
        private Label[] questionsLabel = new Label[10];
        private List<Question> questions = null;
        private string score = null;
        private int n = 1;
    }
}
