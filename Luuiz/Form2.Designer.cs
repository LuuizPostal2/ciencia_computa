namespace Luuiz
{
    partial class Form2
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
            txtPreço = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtCategoria = new TextBox();
            label5 = new Label();
            txtEntrada = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            txtVoltar.TabIndex = 27;
            txtVoltar.Text = "Voltar";
            txtVoltar.UseVisualStyleBackColor = false;
            txtVoltar.Click += txtVoltar_Click;
            // 
            // txtCadastrar
            // 
            txtCadastrar.BackColor = SystemColors.Info;
            txtCadastrar.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCadastrar.ForeColor = Color.DarkRed;
            txtCadastrar.Location = new Point(462, 384);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(111, 39);
            txtCadastrar.TabIndex = 26;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.UseVisualStyleBackColor = false;
            txtCadastrar.Click += txtCadastrar_Click;
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(322, 296);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(196, 27);
            txtPreço.TabIndex = 25;
            txtPreço.Tag = "";
            txtPreço.Text = "Digite o Preço.....";
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Grip;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(265, 297);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 24;
            label7.Text = "Preço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(241, 248);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 23;
            label6.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(322, 247);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(196, 27);
            txtCategoria.TabIndex = 22;
            txtCategoria.Text = "Digite a Categoria.....";
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.Grip;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(289, 243);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 21;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(322, 197);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(196, 27);
            txtEntrada.TabIndex = 20;
            txtEntrada.Text = "Digite a Entrada.....";
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Grip;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(255, 197);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 19;
            label4.Text = "Entrada:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(322, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 27);
            txtNome.TabIndex = 18;
            txtNome.Text = "Digite o Nome.....";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Grip;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(265, 148);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 17;
            label3.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(322, 99);
            txtID.Name = "txtID";
            txtID.Size = new Size(196, 27);
            txtID.TabIndex = 16;
            txtID.Text = "Digite o ID.....";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.Grip;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(289, 100);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 15;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(255, 27);
            label1.Name = "label1";
            label1.Size = new Size(299, 38);
            label1.TabIndex = 14;
            label1.Text = "Cadastro de Produtos";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtVoltar;
        private Button txtCadastrar;
        private TextBox txtPreço;
        private Label label7;
        private Label label6;
        private TextBox txtCategoria;
        private Label label5;
        private TextBox txtEntrada;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Label label1;
    }
}