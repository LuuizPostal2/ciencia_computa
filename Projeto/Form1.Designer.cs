namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtEntrada = new TextBox();
            label4 = new Label();
            txtCategoria = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtPreço = new TextBox();
            label7 = new Label();
            txtCadastrar = new Button();
            txtVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(279, 30);
            label1.Name = "label1";
            label1.Size = new Size(299, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.Grip;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(313, 103);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(346, 102);
            txtID.Name = "txtID";
            txtID.Size = new Size(196, 25);
            txtID.TabIndex = 2;
            txtID.Text = "Digite o ID.....";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(346, 151);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 25);
            txtNome.TabIndex = 4;
            txtNome.Text = "Digite o Nome.....";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Grip;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(289, 151);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(346, 200);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(196, 25);
            txtEntrada.TabIndex = 6;
            txtEntrada.Text = "Digite a Entrada.....";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Grip;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(279, 200);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Entrada:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(346, 250);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(196, 25);
            txtCategoria.TabIndex = 8;
            txtCategoria.Text = "Digite a Categoria.....";
            txtCategoria.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.Grip;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(313, 246);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(265, 251);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 9;
            label6.Text = "Categoria:";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(346, 299);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(196, 25);
            txtPreço.TabIndex = 11;
            txtPreço.Tag = "";
            txtPreço.Text = "Digite o Preço.....";
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Grip;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(289, 300);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 10;
            label7.Text = "Preço:";
            label7.Click += label7_Click;
            // 
            // txtCadastrar
            // 
            txtCadastrar.BackColor = SystemColors.Info;
            txtCadastrar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCadastrar.ForeColor = Color.DarkRed;
            txtCadastrar.Location = new Point(486, 387);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(111, 39);
            txtCadastrar.TabIndex = 12;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.UseVisualStyleBackColor = false;
            txtCadastrar.Click += txtCadastrar_Click_1;
            // 
            // txtVoltar
            // 
            txtVoltar.BackColor = SystemColors.Info;
            txtVoltar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVoltar.ForeColor = Color.DarkRed;
            txtVoltar.Location = new Point(252, 387);
            txtVoltar.Name = "txtVoltar";
            txtVoltar.Size = new Size(111, 39);
            txtVoltar.TabIndex = 13;
            txtVoltar.Text = "Voltar";
            txtVoltar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 454);
            Controls.Add(txtVoltar);
            Controls.Add(txtCadastrar);
            Controls.Add(txtPreço);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtCategoria);
            Controls.Add(label5);
            Controls.Add(txtEntrada);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEntrada;
        private Label label4;
        private TextBox txtCategoria;
        private Label label5;
        private Label label6;
        private TextBox txtPreço;
        private Label label7;
        private Button txtCadastrar;
        private Button txtVoltar;
    }
}
