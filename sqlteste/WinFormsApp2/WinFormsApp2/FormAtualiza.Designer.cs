namespace WinFormsApp2
{
    partial class FormAtualiza
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
            textBoxDistancia = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxSexo = new ComboBox();
            comboBoxEstilo = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 98);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Distancia:";
            // 
            // textBoxDistancia
            // 
            textBoxDistancia.Location = new Point(180, 95);
            textBoxDistancia.Name = "textBoxDistancia";
            textBoxDistancia.Size = new Size(167, 23);
            textBoxDistancia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 187);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 273);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo de Prova:";
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Location = new Point(180, 184);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(167, 23);
            comboBoxSexo.TabIndex = 4;
            // 
            // comboBoxEstilo
            // 
            comboBoxEstilo.FormattingEnabled = true;
            comboBoxEstilo.Location = new Point(180, 270);
            comboBoxEstilo.Name = "comboBoxEstilo";
            comboBoxEstilo.Size = new Size(167, 23);
            comboBoxEstilo.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(622, 375);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(140, 45);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormAtualiza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(comboBoxEstilo);
            Controls.Add(comboBoxSexo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxDistancia);
            Controls.Add(label1);
            Name = "FormAtualiza";
            Text = "FormAtualiza";
            Load += FormAtualiza_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBoxDistancia;
        private Label label2;
        private Label label3;
        public ComboBox comboBoxSexo;
        public ComboBox comboBoxEstilo;
        public Button btnSalvar;
        public int IdProva { get; set; }
        public string Sexo { get; set; }
        public string Estilo { get; set; }
    }
}