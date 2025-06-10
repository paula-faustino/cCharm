namespace Projeto.jeferson
{
    partial class Selecionar
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
            Carregar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 87);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(671, 49);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Carregar
            // 
            Carregar.Location = new Point(100, 171);
            Carregar.Name = "Carregar";
            Carregar.Size = new Size(187, 34);
            Carregar.TabIndex = 1;
            Carregar.Text = "Carregar";
            Carregar.UseVisualStyleBackColor = true;
            Carregar.Click += button1_Click;
            // 
            // Selecionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 864);
            Controls.Add(Carregar);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Selecionar";
            Text = "Selecionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Carregar;
    }
}