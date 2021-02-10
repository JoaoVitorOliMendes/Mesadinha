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
    public partial class usuario : Form
    {
        string email = Login.email;
        Conexaobd bd = new Conexaobd();
        string sql;
        DateTime data;
        login log = new login();
        public double receitas = 0.0;
        public double despesas = 0.0;
        public double saldos = 0.0;

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

        public void despesa()
        {
            DataTable dt = new DataTable();
            sql = string.Format("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'despesa' and usuario.codigo = '{0}';", Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                lblDESPESA.Text = "R$"  + dt.Rows[0]["valor"].ToString();
                if (dt.Rows[0]["valor"] != DBNull.Value)
                {
                    despesas = Convert.ToDouble(dt.Rows[0]["valor"]);
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
            sql = string.Format("select sum(valor) as valor,tipo,lancamento.codigo,usuario.email from lancamento join conta join usuario on lancamento.nome = conta.nome and lancamento.codigo = usuario.codigo where conta.tipo = 'receita' and usuario.codigo = '{0}';", Login.codigo);
            dt = bd.consultar(sql);
            if (dt.Rows.Count > 0)
            {
                lblRECEITA.Text = "R$" + dt.Rows[0]["valor"].ToString();
                if (dt.Rows[0]["valor"] != DBNull.Value)
                {
                    receitas = Convert.ToDouble(dt.Rows[0]["valor"]);
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
            receita();
            despesa();
            saldos = receitas - despesas;
            lblSALDO.Text = "R$ " + saldos.ToString();
        }

        private void btndados_Click(object sender, EventArgs e)
        {
                this.Visible = false;
                dados das = new dados();
                das.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            senha das = new senha();
            das.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            categoria das = new categoria();
            das.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            conta das = new conta();
            das.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            lancamento das = new lancamento();
            das.ShowDialog();
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

        private void lblreceita_Click(object sender, EventArgs e)
        {

        }
    }
}
