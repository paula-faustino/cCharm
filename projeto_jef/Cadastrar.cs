using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_jef
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro_prod cadastroProduto = new cadastro_prod();
            cadastroProduto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            relatorio relatorioForm = new relatorio();
            relatorioForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestao gestaoForm = new gestao();
            gestaoForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controle controleForm = new Controle();
            controleForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcionarios funcionariosForm = new funcionarios();
            funcionariosForm.ShowDialog();  
        }
    }
}
