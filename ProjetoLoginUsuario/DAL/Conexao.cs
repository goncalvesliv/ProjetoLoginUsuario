using System;
using System.Configuration; 
using System.Data.SqlClient;

namespace ProjetoLoginUsuario.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;
            con.ConnectionString = connectionString;
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
