namespace Projeto.jeferson
{
    partial class cadastrope
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nome = new TextBox();
            email = new TextBox();
            telefone = new TextBox();
            data = new TextBox();
            senha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(482, 204);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(481, 253);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(461, 300);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(482, 393);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(361, 347);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 4;
            label5.Text = "Data de nascimento:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(644, 326);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(585, 119);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 6;
            label7.Text = "CADASTRO";
            // 
            // nome
            // 
            nome.Location = new Point(559, 209);
            nome.Name = "nome";
            nome.Size = new Size(213, 23);
            nome.TabIndex = 7;
            // 
            // email
            // 
            email.Location = new Point(559, 253);
            email.Name = "email";
            email.Size = new Size(213, 23);
            email.TabIndex = 8;
            // 
            // telefone
            // 
            telefone.Location = new Point(559, 300);
            telefone.Name = "telefone";
            telefone.Size = new Size(213, 23);
            telefone.TabIndex = 9;
            // 
            // data
            // 
            data.Location = new Point(559, 349);
            data.Name = "data";
            data.Size = new Size(213, 23);
            data.TabIndex = 10;
            // 
            // senha
            // 
            senha.Location = new Point(559, 398);
            senha.Name = "senha";
            senha.Size = new Size(213, 23);
            senha.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(599, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Avançar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cadastrope
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 648);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(senha);
            Controls.Add(data);
            Controls.Add(telefone);
            Controls.Add(email);
            Controls.Add(nome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cadastrope";
            Text = "cadastrope";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox nome;
        private TextBox email;
        private TextBox telefone;
        private TextBox data;
        private TextBox senha;
        private Button button1;
        private Button button2;
    }
}