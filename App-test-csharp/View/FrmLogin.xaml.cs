﻿using ClassesLibrary.Controller;
using ClassesLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace App_test_csharp
{
    /// <summary>
    /// Lógica de interacción para FrmLogin.xaml
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Main(object sender, RoutedEventArgs e)
        {
            User userModel = new User();
            CLogin cLogin = new CLogin(this, userModel);
            Console.WriteLine("Funciona");
        }
    }
}
