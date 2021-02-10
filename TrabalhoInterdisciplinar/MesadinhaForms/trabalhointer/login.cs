using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace trabalhointer
{
    class login
    {
        public bool Validar(string usuario, string senha)
        {
            Conexaobd bd = new Conexaobd();
            DataTable resultado = new DataTable();
            string sql = string.Format("select * from usuario where email = '{0}' and senha = '{1}';", usuario, senha);
            resultado = bd.consultar(sql);
            if(resultado.Rows.Count > 0)
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
