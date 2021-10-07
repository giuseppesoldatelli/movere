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
    public partial class movimentacao : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8J2LME6\SQLEXPRESS;Initial Catalog=ProjetoMovere;Integrated Security=True");
        SqlDataAdapter adpt;
        DataTable dt;

        public movimentacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void movimentacao_Load(object sender, EventArgs e)
        {

        }

        private void button_addSaldo_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.Show();
        }
        public void showdata()
        {
            cmd.CommandText = "select valor from saldo";
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }
    }
}
