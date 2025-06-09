namespace Projeto.jeferson
{
    partial class Login
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
            textBox1 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(572, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 25);
            textBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(622, 139);
            label7.Name = "label7";
            label7.Size = new Size(96, 32);
            label7.TabIndex = 11;
            label7.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(495, 240);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 9;
            label1.Text = "Nome:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(572, 295);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 25);
            textBox5.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(495, 289);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 14;
            label4.Text = "Senha:";
            // 
            // button2
            // 
            button2.Location = new Point(710, 348);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 17;
            button2.Text = "Avançar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(612, 348);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 16;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 734);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label7;
        private Label label1;
        private TextBox textBox5;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}