namespace Programa_gerenciador
{
    partial class Fornecedores
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            Salvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(329, 35);
            label1.Name = "label1";
            label1.Size = new Size(317, 31);
            label1.TabIndex = 5;
            label1.Text = "Cadastrar Fornecedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(239, 163);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(329, 331);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 27);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(329, 160);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 27);
            textBox3.TabIndex = 25;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(239, 219);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 27;
            label3.Text = "CNPJ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(234, 338);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 28;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(214, 279);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 29;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(206, 396);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 30;
            label6.Text = "Endereço:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(329, 279);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "(99) 00 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(114, 27);
            maskedTextBox2.TabIndex = 31;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(329, 393);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 27);
            textBox4.TabIndex = 32;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(536, 497);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 33;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.Snow;
            Salvar.ForeColor = SystemColors.ActiveCaptionText;
            Salvar.Location = new Point(349, 497);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(94, 29);
            Salvar.TabIndex = 34;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click;
            // 
            // Fornecedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(1014, 554);
            Controls.Add(Salvar);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(maskedTextBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fornecedores";
            Text = "Fornecedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox4;
        private Button button2;
        private Button Salvar;
    }
}