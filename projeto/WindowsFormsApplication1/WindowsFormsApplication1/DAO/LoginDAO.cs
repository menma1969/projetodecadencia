using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LoginDao
    {//começa aqui **********************************************
        string Con;//variável para string de conexão
        Login log = new Login();//chamada da classe Login

        //obtem a string e conexão do arquivo App.config
        public LoginDao()
        {
            //define string de conexao e cria a conexao
            Con = "Persist Security Info=False;server=localhost;" +
                            "database=filme;uid=root;pwd=";
        }

        public Boolean logar(Login login)
        {//método para verificar se o login e senha existem no banco de dados
            Boolean resp = false;
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();


            Com.CommandText = "select nome, senha from usuario WHERE"
                           + " nome='" + login.Login1 + "'"
                           + " AND " + "senha='" + login.Senha + "'";

            try
            {
                CN.Open();
                //int regitrosAfetados = Com.ExecuteNonQuery();
                bool verifica = Com.ExecuteReader().HasRows;
                if (verifica == true)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
            }
            catch (MySqlException ex)//exceção do banco de dados
            {
                resp = false;
                throw new ApplicationException(ex.ToString());//exceção no sistema
            }
            finally
            {
                CN.Close();
            }
            return resp;
        }
    }
}//termina aqui

