using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.DAO
{
    class cadastrarfilmesDAO
    {
        cadastrarfilmes cadf = new cadastrarfilmes();

        string Con;//variável para string de conexão
        public cadastrarfilmesDAO()
        {

            //define string de conexao e cria a conexao
            Con = "Persist Security Info=False;server=localhost;" +
                            "database=filme;uid=root;pwd=";
        }

        public void RegistrarFilme(cadastrarfilmes cadastrarfilmes)
        {

            Con = "Persist Security Info=True;server=localhost;" +
                            "database=filme;uid=root;pwd=";

            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();



            Com.CommandText = "INSERT INTO filmes(nome, imagem, genero, diretor, sinopse, faixaetaria, duracao, anolanca) Values(?nome,?imagem,?genero,?diretor,?sinopse,?faixaetaria,?duracao,?anolanca)";

            Com.Parameters.AddWithValue("?nome", cadastrarfilmes._nome);
            Com.Parameters.AddWithValue("?imagem", cadastrarfilmes._imagem);
            Com.Parameters.AddWithValue("?genero", cadastrarfilmes._genero);
            Com.Parameters.AddWithValue("?diretor", cadastrarfilmes._diretor);
            Com.Parameters.AddWithValue("?sinopse", cadastrarfilmes._sinopse);
            Com.Parameters.AddWithValue("?faixaetaria", cadastrarfilmes._faixaetaria);
            Com.Parameters.AddWithValue("?duracao", cadastrarfilmes._duracao);
            Com.Parameters.AddWithValue("?anolanca", cadastrarfilmes._ano);

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




        public Boolean Cad(cadastrarfilmes cadf)
        {//método para verificar se o login e senha existem no banco de dados
            Boolean resp = false;
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "SELECT nome FROM filmes WHERE nome LIKE '%" + cadf.Nome + "%'";

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
        public List<cadastrarfilmes> Listarfilmes()
        {
            Con = "Persist Security Info=True;server=localhost;" +
                            "database=filme;uid=root;pwd="; 
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataReader dr;

            cmd.CommandText = "select codigofilme, nome, imagem, genero, diretor, sinopse, faixaetaria, duracao, anolanca from alunos";
            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                dr = cmd.ExecuteReader();

                List<cadastrarfilmes> cadf = new List<cadastrarfilmes>();
                // quando acabar as linhas que retornou da consulta, sai do While
                while (dr.Read())
                {
                    cadastrarfilmes cadfi = new cadastrarfilmes();
                    cadfi.Codigo = dr.GetString(dr.GetOrdinal("codigofilme"));
                    cadfi.Nome = dr.GetString(dr.GetOrdinal("nome"));
                    cadfi.Imagem = dr.GetString(dr.GetOrdinal("imagem"));
                    cadfi.Genero = dr.GetString(dr.GetOrdinal("genero"));
                    cadfi.Diretor = dr.GetString(dr.GetOrdinal("diretor"));
                    cadfi.Sinopse = dr.GetString(dr.GetOrdinal("sinopse"));
                    cadfi.Faixaetaria = dr.GetString(dr.GetOrdinal("faixaetaria"));
                    cadfi.Duracao = dr.GetString(dr.GetOrdinal("duracao"));
                    cadfi.Ano = dr.GetString(dr.GetOrdinal("anolanca"));
                    cadf.Add(cadfi);
                }
                cmd.Connection.Close();
                cmd.Dispose();
                return cadf;
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
    }
}
