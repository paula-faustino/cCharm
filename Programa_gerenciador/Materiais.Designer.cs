namespace Programa_gerenciador
{
    partial class Materiais
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
            label2 = new Label();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            btnSair = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 341);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(176, 344);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 23;
            label2.Text = "Nome do material:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(250, 91);
            label1.Name = "label1";
            label1.Size = new Size(350, 25);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO DE MATERIAIS ";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(288, 370);
            maskedTextBox2.Mask = "000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(210, 373);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 26;
            label6.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(161, 315);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 23;
            label3.Text = "Nome do fornecedor:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 23);
            textBox2.TabIndex = 24;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(540, 402);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 29;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Materiais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(maskedTextBox2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Materiais";
            Text = "Materiais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label3;
        private TextBox textBox2;
        private Button btnSair;
    }
}