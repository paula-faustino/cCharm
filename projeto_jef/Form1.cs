﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
         InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();  
            cadastrar.ShowDialog();
        }
    }
}
