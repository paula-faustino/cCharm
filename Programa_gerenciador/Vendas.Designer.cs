namespace Programa_gerenciador
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSair = new Button();
            textBox2 = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(199, 396);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 31;
            label6.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(165, 349);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 29;
            label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(250, 58);
            label1.Name = "label1";
            label1.Size = new Size(294, 50);
            label1.TabIndex = 28;
            label1.Text = "VENDA DE PRODUTOS \r\n\r\n";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(505, 457);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 26);
            btnSair.TabIndex = 34;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 25);
            textBox2.TabIndex = 35;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(424, 457);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 26);
            btnCadastrar.TabIndex = 34;
            btnCadastrar.Text = "inserir ";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnSair_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 510);
            Controls.Add(textBox2);
            Controls.Add(btnCadastrar);
            Controls.Add(btnSair);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Vendas";
            Text = "Vendas";
            Load += Vendas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label2;
        private Label label1;
        private Button btnSair;
        private TextBox textBox2;
        private Button btnCadastrar;
    }
}