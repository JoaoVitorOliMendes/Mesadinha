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
    public partial class usuario : Form
    {
        string email = login.email;
        conexao bd = new conexao();
        string sql;
        DateTime data;
        login log = new login();
        public double receitas = 0.0;
        public double despesas = 0.0;
        public double saldo = 0.0;

        public void codigo()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select id from cliente where email = '{0}';", login.email);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                login.codigo = Convert.ToInt32(dt.Rows[0]["id"]);
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void despesa()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select sum(quantia) as despesa,tipo from movimentacao join conta on conta.descricao = movimentacao.contadescricao join cliente on movimentacao.clienteid = cliente.id where conta.tipo = 'despesa' and cliente.id = '{0}';", login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                lbldespesa.Text = "R$ " + dt.Rows[0]["despesa"];
                if (dt.Rows[0]["despesa"] != DBNull.Value)
                {
                    despesas = Convert.ToDouble(dt.Rows[0]["despesa"]);
                }
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void receita()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select sum(quantia) as receita,tipo from movimentacao join conta on conta.descricao = movimentacao.contadescricao join cliente on movimentacao.clienteid = cliente.id where conta.tipo = 'receita' and cliente.id = '{0}';", login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                lblreceita.Text = "R$ " + dt.Rows[0]["receita"];
                if (dt.Rows[0]["receita"] != DBNull.Value)
                {
                    receitas = Convert.ToDouble(dt.Rows[0]["receita"]);
                }
            }
            else
            {
                MessageBox.Show("Aluno não cadastrado!", "Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public usuario()
        {
            InitializeComponent();
            codigo();
            despesa();
            receita();
            saldo = receitas - despesas;
            lblsaldo.Text = "R$ " + saldo.ToString();
        }

        private void btndados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            altd hom = new altd();
            hom.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblsaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cat hom = new cat();
            hom.ShowDialog();
        }

        private void btnsenha_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            altsen hom = new altsen();
            hom.ShowDialog();
        }

        private void btnconta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Conta hom = new Conta();
            hom.ShowDialog();
        }

        private void btnlancamento_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lanc hom = new lanc();
            hom.ShowDialog();
        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
