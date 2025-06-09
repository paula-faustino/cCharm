namespace Projeto.jeferson
{
    partial class Cadastrarpro
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
            label7 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtsenha = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(484, 94);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 7;
            label7.Text = "CADASTRO";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(344, 165);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 8;
            label1.Text = "Nome do produto:";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(344, 206);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 9;
            label4.Text = "Especificações:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(344, 242);
            label2.Name = "label2";
            label2.Size = new Size(313, 25);
            label2.TabIndex = 15;
            label2.Text = "Empresa proprietaria do produto:";
            label2.Click += label2_Click;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(530, 170);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(346, 23);
            txtsenha.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(530, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(663, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(467, 295);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 19;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(588, 295);
            button2.Name = "button2";
            button2.Size = new Size(92, 23);
            button2.TabIndex = 20;
            button2.Text = "Avançar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cadastrarpro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 648);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtsenha);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "Cadastrarpro";
            Text = "Cadastrarpro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox txtsenha;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}