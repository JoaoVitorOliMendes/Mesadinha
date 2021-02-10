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
    public partial class cat : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();
        public void Listar()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from categoria;");
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

        public cat()
        {
            InitializeComponent();
            Listar();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into categoria(nome) value('{0}');", txtcat.Text);
            bd.alterar(sql);
            MessageBox.Show("Categoria cadastrada!", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from categoria where nome = '{0}';", txtcat.Text);
            bd.alterar(sql);
            MessageBox.Show("Categoria deletada!", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void dtgcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }
    }
}
