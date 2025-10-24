namespace Luuiz
{
    partial class Form3
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
            TxtCastpro = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(327, 65);
            label1.Name = "label1";
            label1.Size = new Size(123, 49);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // TxtCastpro
            // 
            TxtCastpro.BackColor = SystemColors.Info;
            TxtCastpro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCastpro.ForeColor = SystemColors.ControlText;
            TxtCastpro.Location = new Point(460, 268);
            TxtCastpro.Name = "TxtCastpro";
            TxtCastpro.Size = new Size(128, 54);
            TxtCastpro.TabIndex = 1;
            TxtCastpro.Text = "Cadastre-se o Produto";
            TxtCastpro.UseVisualStyleBackColor = false;
            TxtCastpro.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(172, 268);
            button2.Name = "button2";
            button2.Size = new Size(128, 54);
            button2.TabIndex = 2;
            button2.Text = "Cadastra-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(TxtCastpro);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button TxtCastpro;
        private Button button2;
    }
}