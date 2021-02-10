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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        Conexaobd bd = new Conexaobd();
        string sql;

        private void btncad_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into usuario values(null, '{0}','{1}','{2}',null);", txtnome.Text, txtemail.Text, txtsenha.Text);
            bd.alterar(sql);
            MessageBox.Show("Usuario Cadastrado.");
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '\0';
        }
    }
}
