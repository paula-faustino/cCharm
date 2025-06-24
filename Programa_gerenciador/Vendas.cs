using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Programa_gerenciador_DLL;


namespace Programa_gerenciador
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            // quatidade Vendas
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ID pro textBox2 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // data textBox3
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //id_cli textBox4
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod_prod = int.Parse(textBox2.Text);
                int cliente_id = int.Parse(textBox4.Text);
                decimal valor = decimal.Parse(textBox4.Text); 

                VendasDLL vendaDLL = new VendasDLL();
                vendaDLL.RegistrarVenda(cod_prod, cliente_id, valor);

                MessageBox.Show("Venda salva com sucesso!");
                LimparCamposVenda();

                VendasTotal vendasTotal = new VendasTotal();
                vendasTotal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a venda: " + ex.Message);
            }

        }
        private void LimparCamposVenda()
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox4.Clear();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

