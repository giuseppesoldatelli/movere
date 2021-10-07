using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MOVERE.Screen.DAL
{
    class Login
    {
        public bool confirm = false; //começa em false
        public String msg = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verLogin(String login, String senha)
        {
            //verificar o banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            //cmd.CommandText = "select conta_id from logins";            
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            //cmd.Parameters.AddWithValue("@id", conta_id);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //confirma se tem no banco
                {
                    //string id = "select conta_id from logins";
                    confirm = true;                    
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.msg = "Erro com o banco de dados!"; //se der erro
                throw; 
            }
            return confirm;
        }
        public String cadastrar(String nome, String email, String senha, String confSenha)
        {
            confirm = false;

            //add no banco
            if (senha.Equals(confSenha))
            {               
                cmd.CommandText = "insert into logins values (@nome, @login, @senha)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@login", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.msg = "Cadastrado com sucesso!";
                    confirm = true;
                }
                catch (SqlException)
                {
                   this.msg = "Erro com Banco de Dados!";
                }
            }
            else
            {
                this.msg = "Senhas não correspondem!";
            }
            return msg;
        }
        public String saldo(String valor, String cat_gasto)
        {
            confirm = false;

            //add no banco            
                cmd.CommandText = string.Format("INSERT INTO saldo Values((Select MAX(conta_id) From logins),@saldo,@tipo)");
                cmd.Parameters.AddWithValue("@saldo", valor);
                cmd.Parameters.AddWithValue("@tipo", cat_gasto);
                
            try
                {
                    cmd.Connection = con.conectar();
                    //int id = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.msg = "Saldo cadastrado!";
                    confirm = true;
                }
                catch (SqlException)
                {
                    this.msg = "Erro com Banco de Dados!";
                }
         return msg;
        }

       // public void confirm ()
    }
}
