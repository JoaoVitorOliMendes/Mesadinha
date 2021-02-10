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
    public partial class lanc : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();
        public void Listarcat()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from conta;");
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                cbxcon.DataSource = bd.consultar(sql);
                cbxcon.DisplayMember = "descricao";
                cbxcon.ValueMember = "descricao";
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Listarcon()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from movimentacao where clienteid = '{0}';",login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                dtgcat.DataSource = bd.consultar(sql);
            }
            else
            {
                MessageBox.Show("Nenhum lancamento!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public lanc()
        {
            InitializeComponent();
            Listarcat();
            Listarcon();
        }

        private void txtval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btncat_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into movimentacao (id,contadescricao,clienteid,dia,quantia)values(null,'{0}','{1}',curdate(),'{2}');", cbxcon.SelectedValue.ToString(), login.codigo, txtval.Text);
            bd.alterar(sql);
            MessageBox.Show("Lancamento cadastrado!", "Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from movimentacao where id = '{0}';", txtcod.Text);
            bd.alterar(sql);
            MessageBox.Show("Lancamento deletado!", "Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }

        private void lanc_Load(object sender, EventArgs e)
        {

        }
    }
}
