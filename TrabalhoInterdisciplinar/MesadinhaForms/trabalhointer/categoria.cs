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
    public partial class categoria : Form
    {
        string email = Login.email;
        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;
        login log = new login();

        public categoria()
        {
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from categoria where codigo = '{0}';",Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                dtgCAT.DataSource = bd.consultar(sql);
            }
            else
            {
                MessageBox.Show("Nenhuma categoria!", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            sql = string.Format("insert into categoria(categoria,codigo) values('{0}','{1}');", txtCAT.Text,Login.codigo);
            bd.alterar(sql);
            MessageBox.Show("Categoria cadastrada!", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from categoria where categoria = '{0}';", txtCAT.Text);
            bd.alterar(sql);
            MessageBox.Show("Categoria deletada!", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
