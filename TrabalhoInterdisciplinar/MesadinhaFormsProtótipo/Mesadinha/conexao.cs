using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mesadinha
{
    class conexao
    {
        private MySqlConnection conexaobd;

        public void funcaocon()
        {
            try
            {
                conexaobd = new MySqlConnection("Persist Security Info=false;Server=localhost;Database=trabalhointer;User=root;");
                conexaobd.Open();
            }
            catch
            {
                throw;
            }
        }
        public int alterar(string sql)
        {
            try
            {
                funcaocon();
                MySqlCommand cmd = new MySqlCommand(sql, conexaobd);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexaobd.Close();
            }
        }
        public DataTable consultar(string sql)
        {
            try
            {
                funcaocon();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexaobd);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexaobd.Close();
            }
        }
    }
}
