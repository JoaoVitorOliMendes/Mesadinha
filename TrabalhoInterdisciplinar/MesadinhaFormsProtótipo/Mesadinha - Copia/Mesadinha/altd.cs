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
    
    public partial class altd : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();

        public void Listar()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from cliente where email = '{0}';", login.email);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                txtnome.Text = dt.Rows[0]["nome"].ToString();
                txttel.Text = dt.Rows[0]["telefone"].ToString();
                txtend.Text = dt.Rows[0]["endereco"].ToString();
                txtemail.Text = dt.Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public altd()
        {
            InitializeComponent();
            Listar();
        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
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
            sql = string.Format("update cliente set nome = '{0}', telefone = '{1}', endereco = '{2}', email = '{3}' where id = '{4}';", txtnome.Text, txttel.Text, txtend.Text, txtemail.Text, login.codigo);
            bd.alterar(sql);
            login.email = txtemail.Text;
            MessageBox.Show("Dados alterados com sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }
    }
}
