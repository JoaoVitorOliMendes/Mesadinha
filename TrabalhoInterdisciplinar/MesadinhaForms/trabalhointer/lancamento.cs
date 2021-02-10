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
    public partial class lancamento : Form
    {
        string email = Login.email;
        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;
        login log = new login();
        public void Listarcat()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from conta where codigo = '{0}';",Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                cbxNOME.DataSource = bd.consultar(sql);
                cbxNOME.DisplayMember = "nome";
                cbxNOME.ValueMember = "nome";
            }
            else
            {
                MessageBox.Show("Nenhuma conta!", "Lancamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Listarcon()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from lancamento where lancamento.codigo = '{0}';", Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                dtgLANC.DataSource = bd.consultar(sql);
            }
            else
            {
                MessageBox.Show("Nenhum lançamento!", "Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void codigo()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select codigo from usuario where email = '{0}';",Login.email);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                Login.codigo = Convert.ToInt32(dt.Rows[0]["codigo"]);
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public lancamento()
        {
            InitializeComponent();
            Listarcat();
            Listarcon();
            codigo();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            usuario das = new usuario();
            das.ShowDialog();
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from lancamento where codigolanc = '{0}';", txtCODIGO.Text);
            bd.alterar(sql);
            MessageBox.Show("Lançamento excluido!", "Lancamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into lancamento (codigolanc,datalanc,valor,nome,codigo)values(null,curdate(),'{0}','{1}','{2}');", txtVALOR.Text, cbxNOME.SelectedValue.ToString(), Login.codigo);
            bd.alterar(sql);
            MessageBox.Show("Lançameento salvo!", "lancamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listarcat();
            Listarcon();
        }

        private void lancamento_Load(object sender, EventArgs e)
        {

        }

        private void cbxcon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
