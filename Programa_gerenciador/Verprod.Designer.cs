namespace Programa_gerenciador
{
    partial class Verprod
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
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(518, 439);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 26);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Verprod
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 510);
            Controls.Add(btnSair);
            Name = "Verprod";
            Text = "Verprod";
            Load += Verprod_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnSair;
    }
}