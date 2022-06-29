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
            updateTest();
        }

        public static string TypeTest { get => typeTest; set => typeTest = value; }
        public static string Carnet { get => carnet; set => carnet = value; }

        public void initScore()
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (questions[i].IsCorrect)
                {
                    acum++;
                }
            }
            view.Score.Content = acum + " | " + acum + "/10";
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

        public void updateTest()
        {

            if (acum > 8)
            {
                users = FileStream.GetUsers();

                if (users != null && users[Carnet] != null)
                {
                    switch (TypeTest)
                    {
                        case "A1":
                            users[Carnet].Tests.ElementAt(0).Completed = true;
                            FileStream.verificarUser(users[Carnet]);
                            break;
                        case "A2":
                            users[Carnet].Tests.ElementAt(1).Completed = true;
                            FileStream.verificarUser(users[Carnet]);
                            break;
                        case "B1":
                            users[Carnet].Tests.ElementAt(2).Completed = true;
                            FileStream.verificarUser(users[Carnet]);
                            break;
                        case "B2":
                            users[Carnet].Tests.ElementAt(3).Completed = true;
                            FileStream.verificarUser(users[Carnet]);
                            break;
                        default:
                            Console.WriteLine("Error al validar test");
                            break;
                    }

                }
            }
        }
        private int acum = 0;
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private static String typeTest;
        private FrmResultados view;
        private static string carnet;
        private Button[] btnsHelp = new Button[10];
        private Label[] questionsLabel = new Label[10];
        private List<Question> questions = null;
        private string score = null;
        private int n = 1;

        
    }
}
