using MySql.Data.MySqlClient;
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
    public partial class FrmCadastro : Form
    {
        public object This { get; private set; }

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           FrmLogin abre = new FrmLogin();
            abre.ShowDialog();
            this.Close();
        } 
        cadastrar cada = new cadastrar();

        private void button3_Click(object sender, EventArgs e)

        {
                      

                vefcadastroDAO vefBD = new vefcadastroDAO();//instanciar a classe

                vefcadastro vefcadastroReg = new vefcadastro(formnome.Text, formemail.Text, formsenha.Text);//instanciar a classe

            if (vefBD.Cad(vefcadastroReg))//se o resultado do método chamado for true
            {
                MessageBox.Show("Login, Senha ou Email Já Existentes!");
                formnome.Focus();
            }
            else
            {
                try
                {
                    vefcadastroDAO cadBD = new vefcadastroDAO();
                    cadastrar cadastrarReg = new cadastrar(formnome.Text, formemail.Text, formsenha.Text);

                    cadBD.RegistrarUsuario(cadastrarReg);
                    MessageBox.Show("Usuário registrado com sucesso");
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.ToString());
                }

            }

        }

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
