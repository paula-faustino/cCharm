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
    public partial class Cadastrofunc : Form
    {
        public Cadastrofunc()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //botão salvar
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //nome
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //cpf
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sexo
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //endereço
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //numero
        }
    }
}
