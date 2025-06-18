
namespace Programa_gerenciador
{
    partial class Cadastrocli
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
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnSalvar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            btnSair = new Button();
            label7 = new Label();
            txtid = new TextBox();
            nometxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(255, 68);
            label1.Name = "label1";
            label1.Size = new Size(381, 31);
            label1.TabIndex = 1;
            label1.Text = "CADASTRO DE CLIENTE \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(142, 222);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(185, 282);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(213, 330);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 4;
            label4.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(185, 380);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(182, 432);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 6;
            label6.Text = "Numero:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(264, 326);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 12;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(357, 522);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 30);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar:";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(270, 274);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(114, 27);
            maskedTextBox1.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(264, 432);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "(99) 00 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(114, 27);
            maskedTextBox2.TabIndex = 14;
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(459, 522);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 30);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(219, 168);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 2;
            label7.Text = "ID:";
            // 
            // txtid
            // 
            txtid.Location = new Point(270, 164);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(114, 27);
            txtid.TabIndex = 15;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // nometxt
            // 
            nometxt.Location = new Point(270, 218);
            nometxt.Margin = new Padding(3, 4, 3, 4);
            nometxt.Name = "nometxt";
            nometxt.Size = new Size(114, 27);
            nometxt.TabIndex = 8;
            // 
            // Cadastrocli
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(914, 600);
            Controls.Add(nometxt);
            Controls.Add(txtid);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cadastrocli";
            Text = "Cadastrocli";
            Load += Cadastrocli_Load;
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
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnSalvar;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button btnSair;
        private Label label7;
        private TextBox txtid;
        private TextBox nometxt;

        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox endtxt;
        private System.Windows.Forms.ComboBox sexotxt;
    }
}