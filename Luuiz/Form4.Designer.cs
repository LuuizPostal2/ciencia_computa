namespace Luuiz
{
    partial class Form4
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
            txtVoltar = new Button();
            txtCadastrar = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // txtVoltar
            // 
            txtVoltar.BackColor = SystemColors.Info;
            txtVoltar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVoltar.ForeColor = Color.DarkRed;
            txtVoltar.Location = new Point(228, 384);
            txtVoltar.Name = "txtVoltar";
            txtVoltar.Size = new Size(111, 39);
            txtVoltar.TabIndex = 41;
            txtVoltar.Text = "Voltar";
            txtVoltar.UseVisualStyleBackColor = false;
            // 
            // txtCadastrar
            // 
            txtCadastrar.BackColor = SystemColors.Info;
            txtCadastrar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCadastrar.ForeColor = Color.DarkRed;
            txtCadastrar.Location = new Point(462, 384);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(111, 39);
            txtCadastrar.TabIndex = 40;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(255, 22);
            label1.Name = "label1";
            label1.Size = new Size(282, 38);
            label1.TabIndex = 28;
            label1.Text = "Cadastro de Pedidos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(354, 28);
            comboBox1.TabIndex = 42;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(228, 150);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(354, 28);
            comboBox2.TabIndex = 43;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtVoltar);
            Controls.Add(txtCadastrar);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtVoltar;
        private Button txtCadastrar;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}