using MOVERE.Screen.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOVERE.Screen
{
    public partial class Adicionar : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public Adicionar()
        {
            InitializeComponent();
        }

        private void label_saldo_Click(object sender, EventArgs e)
        {

        }

        private void button_addSaldo_Click(object sender, EventArgs e)
        {
            Models.Controle controle = new Models.Controle();
            String msg = controle.saldo(textBox_valor.Text, textBox1.Text);

            if (controle.confirm) //msg de succes
            {
                MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.msg); //msg de erro
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label_contaID_Click(object sender, EventArgs e)
        {

        }
    }
}
