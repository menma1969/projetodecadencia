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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (titulotxt.Text.Equals("") || diretortxt.Text.Equals("") || anotxt.Text.Equals("") || sinopsetxt.Text.Equals("") ||
                faixaetariatxt.Text.Equals("") || generotxt.Text.Equals("") || duracaotxt.Text.Equals("") || anotxt.Text.Equals(""))
            {
                MessageBox.Show("Informe o titulo do filme.");
                return;
            }
            try
            {
                cadastrarfilmesDAO filmeDB= new cadastrarfilmesDAO();
                cadastrarfilmes cadf = new cadastrarfilmes(titulotxt.Text, txtcaminho.Text, generotxt.Text, diretortxt.Text,
                    sinopsetxt.Text, faixaetariatxt.Text, duracaotxt.Text, anotxt.Text);
                filmeDB.RegistrarFilme(cadf);//chamada do método
                MessageBox.Show("Registro salvo com sucesso.");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrefoto.Title = "Selecione a foto";
            //Diretorio onde estão salvas as imagens na sua máquina
            abrefoto.InitialDirectory =//abaixo em vermelho é o caminho onde as imagens estao na máquina
            "C://Users//Victor//Desktop";
            abrefoto.Filter = "JPEG|*.JPG|PNG|*.png";
            abrefoto.ShowDialog();
            //fotoi é o nome da picturebox do form
            foto.Image = Image.FromFile(abrefoto.FileName);
            //txtcaminho --> Label onde aparecerá o caminho onde a foto está na maquina
            txtcaminho.Text = abrefoto.FileName.Replace(@"\", @"\\");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void anotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Filmes abre = new Filmes();
            abre.ShowDialog();
        }
    }
}
