using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesadinha
{
    public partial class login : Form
    {
        public static string email;
        public static int codigo;

        public login()
        {
            InitializeComponent();
        }

        conexao bd = new conexao();
        string sql;
        DateTime data;

        comandos com = new comandos();

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (com.testelogin(txtEmail.Text,txtSenha.Text))
            {
                login.email = txtEmail.Text;
                this.Visible = false;
                usuario hom = new usuario();
                hom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastro cadas = new cadastro();
            cadas.ShowDialog();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
