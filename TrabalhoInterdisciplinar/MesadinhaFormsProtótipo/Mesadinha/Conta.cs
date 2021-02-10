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
    public partial class Conta : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();
        public void Listarcat()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from categoria;");
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                cbxcat.DataSource = bd.consultar(sql);
                cbxcat.DisplayMember = "nome";
                cbxcat.ValueMember = "nome";
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Listarcon()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from conta;");
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                dtgcat.DataSource = bd.consultar(sql);
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public Conta()
        {
            InitializeComponent();
            Listarcat();
            Listarcon();
        }

        private void lblcadad_Click(object sender, EventArgs e)
        {
           
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from conta where descricao = '{0}';", txtcon.Text);
            bd.alterar(sql);
            MessageBox.Show("Conta deletada!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into conta(descricao,tipo,categorianome)values('{0}','{1}','{2}');", txtcon.Text, cbxtipo.SelectedItem.ToString(), cbxcat.SelectedValue.ToString());
            bd.alterar(sql);
            MessageBox.Show("Conta cadastrada!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }
    }
}
