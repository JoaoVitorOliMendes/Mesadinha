using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhointer
{
    public partial class senha : Form
    {
        string email = Login.email;
        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;
        login log = new login();

        public void Listar()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from usuario where email = '{0}';", Login.email);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                txtSENHA.Text = dt.Rows[0]["senha"].ToString();
                txtSENHA2.Text = dt.Rows[0]["senha"].ToString();
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public senha()
        {
            InitializeComponent();
            Listar();
        }

        private void lblcadad_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }

        private void btncad_Click(object sender, EventArgs e)
        {
            if (txtSENHA.Text == txtSENHA2.Text)
            {
                sql = string.Format("update usuario set senha = '{0}' where email = '{1}';", txtSENHA.Text, Login.email);
                bd.alterar(sql);
                MessageBox.Show("Senha alterada com sucesso", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
            }
            else { MessageBox.Show("Senhas não conferem"); }
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            txtSENHA.PasswordChar = '\0';
            txtSENHA2.PasswordChar = '\0';
        }
    }
}
