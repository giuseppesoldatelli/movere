using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MOVERE.Screen.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-8J2LME6\SQLEXPRESS;Initial Catalog=ProjetoMovere;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
