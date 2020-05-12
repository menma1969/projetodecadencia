using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class cadastrarfilmes
    {
        public String _nome  ;
        public String _imagem;
        public String _genero;


        //getters e setters automaticamente
        //botão direito refatorar
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Imagem
        {
            get
            {
                return _imagem;
            }
            set
            {
                _imagem = value;
            }
        }


        public string Genero
        {
            get
            {
                return _genero;
            }
            set
            {
                _genero = value;
            }
        }




       

        //construtor do objeto com valor de parametro nome, endereco, idade
        public cadastrarfilmes(string nome, string imagem, string genero)
        {
            this.Nome = nome;
            this.Imagem= imagem;
            this.Genero = genero;
        }

        public cadastrarfilmes()
        {
        }
    }
}
