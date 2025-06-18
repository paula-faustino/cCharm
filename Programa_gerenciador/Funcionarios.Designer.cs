namespace Programa_gerenciador
{
    partial class Funcionarios
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            Ver = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(835, 536);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(132, 30);
            button1.TabIndex = 0;
            button1.Text = "Sair";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Ver
            // 
            Ver.BackColor = SystemColors.Control;
            Ver.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ver.Location = new Point(690, 536);
            Ver.Margin = new Padding(0);
            Ver.Name = "Ver";
            Ver.Size = new Size(119, 33);
            Ver.TabIndex = 2;
            Ver.Text = "Ver";
            Ver.UseVisualStyleBackColor = false;
            Ver.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSalmon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 460);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(329, 24);
            label1.Name = "label1";
            label1.Size = new Size(344, 31);
            label1.TabIndex = 4;
            label1.Text = "Funcionarios cadastrados";
            label1.Click += label1_Click;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(979, 590);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Ver);
            Controls.Add(button1);
            Name = "Funcionarios";
            Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private BindingSource bindingSource1;
        private Button Ver;
        private DataGridView dataGridView1;
        private Label label1;
    }
}