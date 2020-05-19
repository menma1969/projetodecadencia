using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DAO;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1
{
    public partial class Filmes : Form
    {
        public Filmes()
        {
            InitializeComponent();
        }
        private void Filmes_Load(object sender, EventArgs e)
        {
            cadastrarfilmesDAO dao = new cadastrarfilmesDAO();
            cadastrarfilmes cadf = new cadastrarfilmes();
            List<cadastrarfilmes> cadastrarfilmes = dao.Listarfilmes();//carrega uma lista 
                                                                       //"FONTE DE DADOS (DATATABLE, DATASET, LIST, etc)";
            cbfilmes.DataSource = cadastrarfilmes;
            //"NOME DO CAMPO QUE REPRESENTA A IDENTIFICAÇÃO DE CADA ITEM DO COMBOBOX";
            cbfilmes.DisplayMember = "nome";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 abre = new Form1();
            abre.ShowDialog();
        }

        private void cbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            {//para carregar a combobox com os dados 
                cadastrarfilmes cadf = (cadastrarfilmes)cbfilmes.SelectedItem;//seleção do combobox
                titulotxt.Text = Convert.ToString(cadf.Nome);
                sinopsetxt.Text = Convert.ToString(cadf.Sinopse);
                diretortxt.Text = Convert.ToString(cadf.Diretor);
                faixaetariatxt.Text = Convert.ToString(cadf.Faixaetaria);
                generotxt.Text = Convert.ToString(cadf.Genero);
                duracaotxt.Text = Convert.ToString(cadf.Duracao);
                fotofinal.ImageLocation = cadf.Imagem;
                anotxt.Text = Convert.ToString(cadf.Ano);
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
