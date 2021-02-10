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
    public partial class altsen : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();
        public void Listar()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select senha from cliente where id = '{0}';",login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                txtsenha.Text = dt.Rows[0]["senha"].ToString();
                txtsenha2.Text = dt.Rows[0]["senha"].ToString();
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public altsen()
        {
            InitializeComponent();
            Listar();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            if (txtsenha.Text == txtsenha2.Text)
            {
                sql = string.Format("update cliente set senha = '{0}' where email = '{1}';", txtsenha.Text, login.email);
                bd.alterar(sql);
                MessageBox.Show("Senha alterada com sucesso", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
            }
            else { MessageBox.Show("Senhas não conferem"); }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '\0';
            txtsenha2.PasswordChar = '\0';
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }

        private void altsen_Load(object sender, EventArgs e)
        {

        }
    }
}
