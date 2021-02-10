using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mesadinha
{
    class comandos
    {
        public bool testelogin(string usuario, string senha)
        {
            conexao bd = new conexao();
            DataTable resultado = new DataTable();
            string sql = string.Format("select * from cliente where email = '{0}' and senha = '{1}';", usuario, senha);
            resultado = bd.consultar(sql);
            if (resultado.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
