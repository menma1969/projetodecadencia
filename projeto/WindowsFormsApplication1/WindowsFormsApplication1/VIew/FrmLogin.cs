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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try//botão logar
            {
                LoginDao loginBD = new LoginDao();//instanciar a classe

                Login loginReg = new Login(txtLogin.Text, txtSenha.Text);//instanciar a classe

                if (loginBD.logar(loginReg))//se o resultado do método chamado for true
                {
                    Filmes abre = new Filmes();//ABRE O FORMULARIO FORM1

                    this.Hide();//fecha a tela ativa
                    if (abre == null)//se a tela de menu já não estiver aberta
                    {
                        abre = new Filmes();
                        this.Hide();
                    }
                    else//senão abre a tela Menu
                    {
                        abre.Show();
                        this.Hide();
                    }
                    abre.Show();
                }
                else
                {
                    MessageBox.Show("Login e Senha Inválidos!");
                    txtLogin.Focus();
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }//fecha a ação clique do botão

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void botaosair(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void botaocadastrar(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastro abre = new FrmCadastro();
            abre.ShowDialog();
           

        }
    }
}
    
