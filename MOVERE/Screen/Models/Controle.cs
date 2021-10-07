using System;
using System.Collections.Generic;
using System.Text;

namespace MOVERE.Screen.Models
{
    public class Controle
    {
        public bool confirm;
        public string msg = "";
        public bool logar(String login, String senha)
        {
            DAL.Login logar = new DAL.Login();
            confirm = logar.verLogin(login, senha);
            if (!logar.msg.Equals(""))
            {
                this.msg = logar.msg; 
            }
            return confirm;
        }

        public String cadastrar(String nome, String email, String senha, String confSenha)
        {
            DAL.Login logar = new DAL.Login();
            this.msg = logar.cadastrar(nome, email, senha, confSenha);

            if (logar.confirm) //msg de sucesso
            {
                this.confirm = true;
            }
            return msg;
        }
        public String saldo(String saldo, String cat_gasto)
        {
            DAL.Login add = new DAL.Login();
            this.msg = add.saldo(saldo, cat_gasto);

            if (add.confirm) //msg de sucesso
            {
                this.confirm = true;
            }
            return msg;
        }

    }
}
