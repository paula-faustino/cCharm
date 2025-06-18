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
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(257, 267);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 31;
            label6.Text = "Quantidade:";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(262, 202);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 29;
            label2.Text = "ID produto:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(286, 68);
            label1.Name = "label1";
            label1.Size = new Size(356, 62);
            label1.TabIndex = 28;
            label1.Text = "VENDA DE PRODUTOS \r\n\r\n";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(577, 538);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 34;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(362, 195);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(41, 27);
            textBox2.TabIndex = 35;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 264);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(362, 406);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(41, 27);
            textBox4.TabIndex = 38;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(238, 345);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 39;
            label3.Text = "Data de venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(270, 413);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 40;
            label4.Text = "ID Cliente:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(362, 340);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 27);
            dateTimePicker1.TabIndex = 41;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(455, 538);
            button1.Name = "button1";
            button1.Size = new Size(82, 27);
            button1.TabIndex = 42;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(btnSair);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}