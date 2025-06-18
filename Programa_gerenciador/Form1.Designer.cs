namespace Programa_gerenciador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            comercialToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            materiaisToolStripMenuItem = new ToolStripMenuItem();
            cadrastrarProdutosToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeFuncionariosToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(192, 255, 255);
            menuStrip1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { comercialToolStripMenuItem, estoqueToolStripMenuItem, funcionariosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // comercialToolStripMenuItem
            // 
            comercialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeClientesToolStripMenuItem, vendasToolStripMenuItem, fornecedoresToolStripMenuItem });
            comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            comercialToolStripMenuItem.Size = new Size(128, 39);
            comercialToolStripMenuItem.Text = "Comercial";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.Size = new Size(304, 40);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de clientes";
            cadastroDeClientesToolStripMenuItem.Click += cadastroDeClientesToolStripMenuItem_Click;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(304, 40);
            vendasToolStripMenuItem.Text = "Vendas ";
            vendasToolStripMenuItem.Click += vendasToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, materiaisToolStripMenuItem, cadrastrarProdutosToolStripMenuItem });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(112, 39);
            estoqueToolStripMenuItem.Text = "Estoque ";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(299, 40);
            produtosToolStripMenuItem.Text = "produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // materiaisToolStripMenuItem
            // 
            materiaisToolStripMenuItem.Name = "materiaisToolStripMenuItem";
            materiaisToolStripMenuItem.Size = new Size(299, 40);
            materiaisToolStripMenuItem.Text = "Materiais ";
            materiaisToolStripMenuItem.Click += materiaisToolStripMenuItem_Click;
            // 
            // cadrastrarProdutosToolStripMenuItem
            // 
            cadrastrarProdutosToolStripMenuItem.Name = "cadrastrarProdutosToolStripMenuItem";
            cadrastrarProdutosToolStripMenuItem.Size = new Size(299, 40);
            cadrastrarProdutosToolStripMenuItem.Text = "Cadastrar produtos";
            cadrastrarProdutosToolStripMenuItem.Click += cadrastrarProdutosToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeFuncionariosToolStripMenuItem, funcionariosToolStripMenuItem1 });
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(153, 39);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // cadastroDeFuncionariosToolStripMenuItem
            // 
            cadastroDeFuncionariosToolStripMenuItem.Name = "cadastroDeFuncionariosToolStripMenuItem";
            cadastroDeFuncionariosToolStripMenuItem.Size = new Size(351, 40);
            cadastroDeFuncionariosToolStripMenuItem.Text = "Cadastro de funcionarios";
            cadastroDeFuncionariosToolStripMenuItem.Click += cadastroDeFuncionariosToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem1
            // 
            funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            funcionariosToolStripMenuItem1.Size = new Size(351, 40);
            funcionariosToolStripMenuItem1.Text = "Funcionarios";
            funcionariosToolStripMenuItem1.Click += funcionariosToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(73, 39);
            sairToolStripMenuItem.Text = "sair ";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(304, 40);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Menu principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem comercialToolStripMenuItem;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeFuncionariosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem materiaisToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem cadrastrarProdutosToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
    }
}
