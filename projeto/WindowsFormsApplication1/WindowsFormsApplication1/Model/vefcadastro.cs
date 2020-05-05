using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
        class vefcadastro //classe chamada Login
        {
            //atributos
            private String login;
            private String senha;
            private String email;

        //getters e setters automaticamente
        //botão direito refatorar

        public String Email1
        {
            get { return email; }
            set { email = value; }
        }

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
            public vefcadastro(string login, string senha, string email)
            {
                this.Login1 = login;
                this.Senha = senha;
                this.Email1 = email;
            }

            public vefcadastro()//construtor sem parâmetro
            {

            }
        }
    }




