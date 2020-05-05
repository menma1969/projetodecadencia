using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class cadastrar
    {
        public String _usuario;
        public String _senha;
        public String _email;


        //getters e setters automaticamente
        //botão direito refatorar
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }


        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }




       

        //construtor do objeto com valor de parametro nome, endereco, idade
        public cadastrar(string usuario, string email, string senha)
        {
            this.Usuario = usuario;
            this.Email = email;
            this.Senha = senha;
        }

        public cadastrar()
        {
        }
    }
}
