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
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtnome = new TextBox();
            txtsenha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtcpf = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(394, 177);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(394, 223);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Senha:";
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
            label7.Location = new Point(487, 60);
            label7.Name = "label7";
            label7.Size = new Size(157, 32);
            label7.TabIndex = 6;
            label7.Text = "CADASTRO";
            label7.Click += label7_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(482, 223);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(213, 23);
            txtnome.TabIndex = 7;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(482, 182);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(213, 23);
            txtsenha.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(482, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(620, 326);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Avançar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(482, 269);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(213, 23);
            txtcpf.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(414, 269);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 14;
            label2.Text = "CPF:";
            // 
            // cadastrope
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 648);
            Controls.Add(txtcpf);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtsenha);
            Controls.Add(txtnome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "cadastrope";
            Text = "cadastrope";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox txtnome;
        private TextBox txtsenha;
        private Button button1;
        private Button button2;
        private TextBox txtcpf;
        private Label label2;
    }
}