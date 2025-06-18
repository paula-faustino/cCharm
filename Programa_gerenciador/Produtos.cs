using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_gerenciador
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verprod verprod = new Verprod();
            verprod.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Produtos produtos = new Produtos();
            produtos.Close();
        }
    }
}
