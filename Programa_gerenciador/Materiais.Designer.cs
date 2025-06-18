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
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 304);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 27);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(187, 304);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 23;
            label2.Text = "Nome do material:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(281, 124);
            label1.Name = "label1";
            label1.Size = new Size(422, 31);
            label1.TabIndex = 22;
            label1.Text = "CADASTRO DE MATERIAIS ";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(336, 348);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(114, 27);
            maskedTextBox2.TabIndex = 27;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(231, 351);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 26;
            label6.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(217, 252);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 23;
            label3.Text = "ID fornecedor:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 252);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(38, 27);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(617, 536);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 29;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(251, 408);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 30;
            label4.Text = "Validade:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(336, 401);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 27);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(481, 536);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 32;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Materiais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(btnSair);
            Controls.Add(maskedTextBox2);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}