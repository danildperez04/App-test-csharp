using System;
using System.Collections.Generic;

namespace ClassesLibrary.Model
{
    public class User
    {
        public User() { }

        public User(string name, string carnet, string password, List<Test> tests)
        {
            this.name = name;
            this.carnet = carnet;
            this.password = password;
            this.tests = tests;
        }

        public string Name { get => name; set => name = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public string Password { get => password; set => password = value; }
        public List<Test> Tests { get => tests; set => tests = value; }

        private string name;
        private string carnet;
        private string password;
        private List<Test> tests;
    }
}
