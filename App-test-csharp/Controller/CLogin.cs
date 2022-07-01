using App_test_csharp;
using App_test_csharp.View;
using ClassesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace ClassesLibrary.Controller
{
    public class CLogin : IComponentsHandler
    {
        public CLogin()
        { }
        public CLogin(FrmLogin view, User model)
        {
            this.view = view;
            this.model = model;

            InitButtons();
        }

        public void InitButtons()
        {
            view.BtnSignIn.Click += (sender, e) => BtnSignIn_Click(sender, e);
            view.BtnSignUp.Click += (sender, e) => BtnSignUp_Click(sender, e);
        }            

        public void BtnSignIn_Click(object sender, EventArgs e)
        {
            string password = view.TxtPassword.Password.ToString();
            string carnet = view.TxtSignInCarnet.Text.Trim();

            if (!(password.Equals("") || carnet.Equals("-")))
            {
                if (ValidateLogin())
                {
                    CResults.Carnet = view.TxtSignInCarnet.Text;
                    FrmMenu menuView = new FrmMenu();
                    CMenu cMenu = new CMenu(menuView);
                    view.Close();
                    menuView.Show();

                    
                    users = FileStream.GetUsers();

                    if (users[carnet].Tests[0].Completed)
                    {
                        menuView.LblEstadoA1.Content = "Completado";
                    }
                    if (users[carnet].Tests[1].Completed)
                    {
                        menuView.LblEstadoA2.Content = "Completado";
                    }
                    if (users[carnet].Tests[2].Completed)
                    {
                        menuView.LblEstadoB1.Content = "Completado";
                    }
                    if (users[carnet].Tests[3].Completed)
                    {
                        menuView.LblEstadoB2.Content = "Completado";
                    }

                    view.Close();
                }
                else
                {
                    MessageBox.Show("SU CONTRASEÑA, CARNET O NOMBRE DE USUARIO SON INCORRECTOS, POR FAVOR INGRESE CORRECTAMENTE SUS DATOS PARA CONTINUAR", "SIGN IN", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                ClearFields();
            }
            else
            {
                MessageBox.Show("POR FAVOR RELLENE TODOS LOS CAMPOS", "LOG IN", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
        }

        public void BtnSignUp_Click(object sender, EventArgs e)
        {
            ValidateSingup();
            ClearFields();
        }

        public bool ValidateLogin()
        {
            String encryptedPassword = Encryption.EncryptThisString(view.TxtPassword.Password.ToString());
            String carnet = view.TxtSignInCarnet.Text;
            users = FileStream.GetUsers();

            if (users != null && users[carnet] != null)
            {
                if (users[carnet].Password.Equals(encryptedPassword))
                {
                    return true;
                }
            }

            return false;
        }

        public void ValidateSingup()
        {

            string password = PasswordProcessing(view.TxtSignUpPassword.Password.ToString());
            string name = view.TxtSignUpUsername.Text.Trim();
            string carnet = view.TxtSignUpCarnet.Text.Trim();

            if (!(name.Equals("") || password.Equals("") || carnet.Equals("-")))
            {
                User user = new User(name, carnet, password, InitTest());
                FileStream.setNewUser(user);
            }
            else
            {
                MessageBox.Show("POR FAVOR RELLENE TODOS LOS CAMPOS", "LOG IN", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        public String PasswordProcessing(String password)
        {
            if (password.Length >= 8)
            {
                return Encryption.EncryptThisString(password);
            }
            else
            {
                MessageBox.Show("SU CONTRASEÑA DEBE TENER POR LO MENOS 8 CARACTERES", "PASSWORD", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return "";
        }

        public void ClearFields()
        {
            view.TxtSignInCarnet.Text = "";
            view.TxtPassword.Password = "";
            view.TxtSignUpCarnet.Text = "";
            view.TxtSignUpUsername.Text = "";
            view.TxtSignUpPassword.Password = "";
        }

        public List<Test> InitTest()
        {
            List<Test> tests = new List<Test>();
            tests.Add(new Test());
            tests.Add(new Test());
            tests.Add(new Test());
            tests.Add(new Test());
            return tests;
        }

        FrmLogin view;
        User model;
        private Dictionary<string, User> users = new Dictionary<string, User>();
        
    }
}
