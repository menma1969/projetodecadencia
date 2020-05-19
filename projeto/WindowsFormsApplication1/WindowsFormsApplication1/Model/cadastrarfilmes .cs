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
        public String _diretor;
        public String _sinopse;
        public String _faixa_etaria;
        public String _duracao;
        public String _ano;


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
        public string Diretor
        {
            get
            {
                return _diretor;
            }
            set
            {
                _diretor = value;
            }
        }
        public string Sinopse
        {
            get
            {
                return _sinopse;
            }
            set
            {
                _sinopse = value;
            }
        }
        public string Faixa_etaria
        {
            get
            {
                return _faixa_etaria;
            }
            set
            {
                _faixa_etaria = value;
            }
        }
        public string Duracao
        {
            get
            {
                return _duracao;
            }
            set
            {
                _duracao = value;
            }
        }
        public string Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                _ano = value;
            }
        }






        //construtor do objeto com valor de parametro nome, endereco, idade
        public cadastrarfilmes(string nome, string imagem, string genero, string diretor, string sinopse, string faixa_etaria, string duracao, string ano)
        {
            this.Nome = nome;
            this.Imagem= imagem;
            this.Genero = genero;
            this.Diretor = diretor;
            this.Sinopse = sinopse;
            this.Ano = ano;
        }

        public cadastrarfilmes()
        {
        }
    }
}
