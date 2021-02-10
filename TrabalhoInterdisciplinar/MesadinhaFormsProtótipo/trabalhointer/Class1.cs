using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace trabalhointer
{
        class Class1
    {
        private MySqlConnection conexao;
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection("Persist Security Info=false;Server=localhost;Port=33061;Database=mesadinha2;User=root;Pwd=julimary2019;");
                conexao.Open();
            }
            catch
            {
                throw;
            }
        }
        }
    }
}
