using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.DAO
{
    class vefcadastroDAO
    {//começa aqui **********************************************
        string Con;//variável para string de conexão
        vefcadastro vef = new vefcadastro();//chamada da classe vefcadastro

        //obtem a string e conexão do arquivo App.config
        public vefcadastroDAO()
        {
            //define string de conexao e cria a conexao
            Con = "Persist Security Info=False;server=localhost;" +
                            "database=filme;uid=root;pwd=";
        }

        public void RegistrarUsuario(cadastrar cadastrar) {

            Con = "Persist Security Info=False;server=localhost;" +
                            "database=filme;uid=root;pwd=";

            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();



            Com.CommandText = "INSERT INTO usuario(nome, email, senha) Values(?usuario,?email,?senha)";

            Com.Parameters.AddWithValue("?usuario", cadastrar._usuario);
            Com.Parameters.AddWithValue("?email", cadastrar._email);
            Com.Parameters.AddWithValue("?senha", cadastrar._senha);

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    

        public Boolean Cad(vefcadastro cad)
        {//método para verificar se o login e senha existem no banco de dados
            Boolean resp = false;
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "SELECT nome FROM usuario WHERE nome LIKE '%" + cad.Login1 + "%'";

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
}
