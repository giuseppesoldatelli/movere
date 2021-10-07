using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MOVERE.Screen
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_cadastro_Click(object sender, EventArgs e)
        {
            Models.Controle controle = new Models.Controle();
            String msg = controle.cadastrar(textBox_nome.Text, textBox_email.Text, textBox_senha.Text, textBox_confSenha.Text);
            
            if(controle.confirm) //msg de succes
            {
                MessageBox.Show(msg, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.msg); //msg de erro
            }

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
