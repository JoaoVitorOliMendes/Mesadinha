
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;

namespace trabalhointer
{
    class Conexaobd
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
        public int alterar(string sql)
        {
            try
            {
                conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
        public DataTable consultar(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
