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
    public partial class conta : Form
    {
        string email = Login.email;
        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;
        login log = new login();
        public void Listarcat()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from categoria where codigo = '{0}';",Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                cbxCAT.DataSource = bd.consultar(sql);
                cbxCAT.DisplayMember = "categoria";
                cbxCAT.ValueMember = "categoria" ;
            }
            else
            {
                MessageBox.Show("Nenhuma categoria!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Listarcon()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from conta where codigo = '{0}';",Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                dtgcat.DataSource = bd.consultar(sql);
            }
            else
            {
                MessageBox.Show("Nenhuma conta!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public conta()
        {
            InitializeComponent();
            Listarcat();
            Listarcon();
        }
        private void lblcadad_Click(object sender, EventArgs e)
        {

        }

        private void cbxcat_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from conta where nome = '{0}';", txtNOME.Text);
            bd.alterar(sql);
            MessageBox.Show("Conta deletada!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into conta(nome,tipo,categoria_conta,codigo)values('{0}','{1}','{2}','{3}');", txtNOME.Text,cbxTIPO.SelectedItem.ToString(),cbxCAT.SelectedValue.ToString(),Login.codigo);
            bd.alterar(sql);
            MessageBox.Show("Conta cadastrada!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void conta_Load(object sender, EventArgs e)
        {

        }
    }
}
