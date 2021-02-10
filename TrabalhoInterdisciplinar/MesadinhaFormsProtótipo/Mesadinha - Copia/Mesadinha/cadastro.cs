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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        conexao bd = new conexao();
        string sql;

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into cliente values(null, '{0}','{1}','{2}','{3}','{4}',null);", txtNome.Text,txtTel.Text,txtEnd.Text, txtEmail.Text, txtSenha.Text);
            bd.alterar(sql);
            MessageBox.Show("Usuario Cadastrado.");
            this.Visible = false;
            login log = new login();
            log.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
