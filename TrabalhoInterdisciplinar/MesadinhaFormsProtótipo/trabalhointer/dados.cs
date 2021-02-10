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
    public partial class dados : Form
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
                txtNOME.Text = dt.Rows[0]["nome"].ToString();
                txtEMAIL.Text = dt.Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public dados()
        {
            InitializeComponent();
            Listar();
        }

        private void lblcadad_Click(object sender, EventArgs e)
        {

        }

        private void btnver_Click(object sender, EventArgs e)
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
            sql = string.Format("update usuario set nome = '{0}', email = '{1}' where usuario.codigo = '{2}';", txtNOME.Text, txtEMAIL.Text,Login.codigo);
            bd.alterar(sql);
            MessageBox.Show("Aluno alterado com sucesso", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void lblsenha_Click(object sender, EventArgs e)
        {

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dados_Load(object sender, EventArgs e)
        {

        }
    }
}
