namespace WinFormsApp3
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxRua = new TextBox();
            textBoxCEP = new TextBox();
            textBoxNumero = new TextBox();
            textBoxBairro = new TextBox();
            textBoxCidade = new TextBox();
            textBoxEstado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "CEP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Rua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 109);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 152);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 152);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado:";
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(91, 67);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(640, 23);
            textBoxRua.TabIndex = 6;
            // 
            // textBoxCEP
            // 
            textBoxCEP.Location = new Point(91, 29);
            textBoxCEP.Name = "textBoxCEP";
            textBoxCEP.Size = new Size(176, 23);
            textBoxCEP.TabIndex = 7;
            textBoxCEP.TextChanged += textBoxCEP_TextChanged;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(91, 106);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 8;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(303, 106);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(232, 23);
            textBoxBairro.TabIndex = 9;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(91, 149);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(100, 23);
            textBoxCidade.TabIndex = 10;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(304, 150);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(51, 23);
            textBoxEstado.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxCEP);
            Controls.Add(textBoxRua);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox textBoxRua;
        private TextBox textBoxCEP;
        private TextBox textBoxNumero;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private TextBox textBoxEstado;
    }
}