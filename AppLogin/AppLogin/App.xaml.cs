using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using AppLogin.View;
using AppLogin.Model;

namespace AppLogin
{
    public partial class App : Application
    {

        public List<Usuario> list_usuarios = new List<Usuario>
        {
            new Usuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new Usuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "456"
            }
        };
        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
