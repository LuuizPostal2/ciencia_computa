namespace Luuiz
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
            txtNome = new TextBox();
            txtEndereço = new TextBox();
            label2 = new Label();
            txtCPF = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCadastrar = new Button();
            button1 = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(392, 112);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(392, 167);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(200, 27);
            txtEndereço.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 170);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            label2.Click += label2_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(392, 225);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 27);
            txtCPF.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 228);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 4;
            label4.Text = "CPF:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(392, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 282);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(333, 24);
            label6.Name = "label6";
            label6.Size = new Size(281, 46);
            label6.TabIndex = 10;
            label6.Text = "Cadastro Cliente";
            // 
            // txtCadastrar
            // 
            txtCadastrar.BackColor = SystemColors.Info;
            txtCadastrar.ForeColor = SystemColors.ControlText;
            txtCadastrar.Location = new Point(500, 424);
            txtCadastrar.Name = "txtCadastrar";
            txtCadastrar.Size = new Size(114, 46);
            txtCadastrar.TabIndex = 11;
            txtCadastrar.Text = "Cadastrar";
            txtCadastrar.UseVisualStyleBackColor = false;
            txtCadastrar.Click += txtCadastrar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(312, 424);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 12;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(392, 329);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 27);
            txtSenha.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 332);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 13;
            label3.Text = "Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 499);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtCadastrar);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtCPF);
            Controls.Add(label4);
            Controls.Add(txtEndereço);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtEndereço;
        private Label label2;
        private TextBox txtCPF;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private Button txtCadastrar;
        private Button button1;
        private TextBox txtSenha;
        private Label label3;
    }
}
