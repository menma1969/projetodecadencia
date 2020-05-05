using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Login//classe chamada Login
    {
        //atributos
        private String login;
        private String senha;

        //getters e setters automaticamente
        //botão direito refatorar
        public String Login1
        {
            get { return login; }
            set { login = value; }
        }


        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        //construtor do objeto com valor de parametro
        public Login(string login, string senha)
        {
            this.Login1 = login;
            this.Senha = senha;
        }

        public Login()//construtor sem parâmetro
        {

        }
    }
}

   

