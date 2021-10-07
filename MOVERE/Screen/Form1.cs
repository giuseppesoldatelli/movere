using MOVERE.Screen;
using MOVERE.Screen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVERE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.logar(textBox_login.Text, textBox_senha.Text);
            if (controle.msg.Equals("")){
                if (controle.confirm)
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    movimentacao bv = new movimentacao();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else{
                MessageBox.Show(controle.msg);
            }



        }
    }
}
