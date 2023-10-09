using Microsoft.Data.SqlClient;

namespace WinFormsApp1
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
            btnBuscaEstilos = new Button();
            listBox1 = new ListBox();
            btnBuscaEstiloID = new Button();
            btnCriaEstilo = new Button();
            btnAtualizaEstilo = new Button();
            textBoxBuscaEstilo = new TextBox();
            textBoxCriaEstilo = new TextBox();
            textBoxAlteraEstiloEstilo = new TextBox();
            textBoxExcluiEstilo = new TextBox();
            btnExcluiEstilo = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxAlteraEstiloID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            listBox3 = new ListBox();
            textBoxCriaTipoTelefone = new TextBox();
            textBoxAlteraTipoTelefoneID = new TextBox();
            textBoxExcluiTipoTelefone = new TextBox();
            textBoxAlteraTipoTelefoneTipo = new TextBox();
            textBoxBuscaTipoTelefone = new TextBox();
            btnAtualizaTipoTelefone = new Button();
            btnExcluirTipoTelefone = new Button();
            btnBuscaTipoTelefoneID = new Button();
            btnBuscaTipoTelefone = new Button();
            btnCriaTipoTelefone = new Button();
            SuspendLayout();
            // 
            // btnBuscaEstilos
            // 
            btnBuscaEstilos.Location = new Point(148, 226);
            btnBuscaEstilos.Name = "btnBuscaEstilos";
            btnBuscaEstilos.Size = new Size(75, 23);
            btnBuscaEstilos.TabIndex = 0;
            btnBuscaEstilos.Text = "Buscar";
            btnBuscaEstilos.UseVisualStyleBackColor = true;
            btnBuscaEstilos.Click += btnBuscaEstilos_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 263);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(340, 289);
            listBox1.TabIndex = 1;
            // 
            // btnBuscaEstiloID
            // 
            btnBuscaEstiloID.Location = new Point(197, 173);
            btnBuscaEstiloID.Name = "btnBuscaEstiloID";
            btnBuscaEstiloID.Size = new Size(75, 23);
            btnBuscaEstiloID.TabIndex = 3;
            btnBuscaEstiloID.Text = "Buscar";
            btnBuscaEstiloID.UseVisualStyleBackColor = true;
            btnBuscaEstiloID.Click += btnBuscaEstiloID_Click;
            // 
            // btnCriaEstilo
            // 
            btnCriaEstilo.Location = new Point(285, 12);
            btnCriaEstilo.Name = "btnCriaEstilo";
            btnCriaEstilo.Size = new Size(75, 23);
            btnCriaEstilo.TabIndex = 4;
            btnCriaEstilo.Text = "Criar";
            btnCriaEstilo.UseVisualStyleBackColor = true;
            btnCriaEstilo.Click += btnCriaEstilo_Click;
            // 
            // btnAtualizaEstilo
            // 
            btnAtualizaEstilo.Location = new Point(379, 61);
            btnAtualizaEstilo.Name = "btnAtualizaEstilo";
            btnAtualizaEstilo.Size = new Size(75, 23);
            btnAtualizaEstilo.TabIndex = 5;
            btnAtualizaEstilo.Text = "Alterar";
            btnAtualizaEstilo.UseVisualStyleBackColor = true;
            btnAtualizaEstilo.Click += btnAtualizaEstilo_Click;
            // 
            // textBoxBuscaEstilo
            // 
            textBoxBuscaEstilo.Location = new Point(133, 173);
            textBoxBuscaEstilo.Name = "textBoxBuscaEstilo";
            textBoxBuscaEstilo.Size = new Size(48, 23);
            textBoxBuscaEstilo.TabIndex = 6;
            // 
            // textBoxCriaEstilo
            // 
            textBoxCriaEstilo.Location = new Point(88, 12);
            textBoxCriaEstilo.Name = "textBoxCriaEstilo";
            textBoxCriaEstilo.Size = new Size(191, 23);
            textBoxCriaEstilo.TabIndex = 7;
            // 
            // textBoxAlteraEstiloEstilo
            // 
            textBoxAlteraEstiloEstilo.Location = new Point(273, 61);
            textBoxAlteraEstiloEstilo.Name = "textBoxAlteraEstiloEstilo";
            textBoxAlteraEstiloEstilo.Size = new Size(100, 23);
            textBoxAlteraEstiloEstilo.TabIndex = 8;
            // 
            // textBoxExcluiEstilo
            // 
            textBoxExcluiEstilo.Location = new Point(133, 120);
            textBoxExcluiEstilo.Name = "textBoxExcluiEstilo";
            textBoxExcluiEstilo.Size = new Size(50, 23);
            textBoxExcluiEstilo.TabIndex = 9;
            // 
            // btnExcluiEstilo
            // 
            btnExcluiEstilo.Location = new Point(197, 120);
            btnExcluiEstilo.Name = "btnExcluiEstilo";
            btnExcluiEstilo.Size = new Size(75, 23);
            btnExcluiEstilo.TabIndex = 10;
            btnExcluiEstilo.Text = "Excluir";
            btnExcluiEstilo.UseVisualStyleBackColor = true;
            btnExcluiEstilo.Click += btnExcluiEstilo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 11;
            label1.Text = "Novo estilo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 12;
            label2.Text = "Alterar Estilo:";
            // 
            // textBoxAlteraEstiloID
            // 
            textBoxAlteraEstiloID.Location = new Point(133, 62);
            textBoxAlteraEstiloID.Name = "textBoxAlteraEstiloID";
            textBoxAlteraEstiloID.Size = new Size(50, 23);
            textBoxAlteraEstiloID.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 65);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 14;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 65);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 15;
            label4.Text = "Novo Estilo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 16;
            label5.Text = "Excluir Estilo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 123);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 17;
            label6.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 176);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 18;
            label7.Text = "Buscar Estilo por ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 226);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 19;
            label8.Text = "Buscar Todos os Estilos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 16);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 20;
            label9.Text = "Novo Tipo de Telefone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(529, 65);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 21;
            label10.Text = "Alterar Tipo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(614, 65);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 22;
            label11.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(706, 64);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 23;
            label12.Text = "Novo Tipo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(529, 123);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 24;
            label13.Text = "Excluir Tipo:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(614, 123);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 25;
            label14.Text = "ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(529, 176);
            label15.Name = "label15";
            label15.Size = new Size(106, 15);
            label15.TabIndex = 26;
            label15.Text = "Buscar Tipo por ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(529, 226);
            label16.Name = "label16";
            label16.Size = new Size(125, 15);
            label16.TabIndex = 27;
            label16.Text = "Buscar Todos os Tipos:";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(529, 263);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(330, 289);
            listBox3.TabIndex = 28;
            // 
            // textBoxCriaTipoTelefone
            // 
            textBoxCriaTipoTelefone.Location = new Point(663, 13);
            textBoxCriaTipoTelefone.Name = "textBoxCriaTipoTelefone";
            textBoxCriaTipoTelefone.Size = new Size(166, 23);
            textBoxCriaTipoTelefone.TabIndex = 30;
            // 
            // textBoxAlteraTipoTelefoneID
            // 
            textBoxAlteraTipoTelefoneID.Location = new Point(641, 61);
            textBoxAlteraTipoTelefoneID.Name = "textBoxAlteraTipoTelefoneID";
            textBoxAlteraTipoTelefoneID.Size = new Size(48, 23);
            textBoxAlteraTipoTelefoneID.TabIndex = 31;
            // 
            // textBoxExcluiTipoTelefone
            // 
            textBoxExcluiTipoTelefone.Location = new Point(641, 120);
            textBoxExcluiTipoTelefone.Name = "textBoxExcluiTipoTelefone";
            textBoxExcluiTipoTelefone.Size = new Size(48, 23);
            textBoxExcluiTipoTelefone.TabIndex = 32;
            // 
            // textBoxAlteraTipoTelefoneTipo
            // 
            textBoxAlteraTipoTelefoneTipo.Location = new Point(777, 61);
            textBoxAlteraTipoTelefoneTipo.Name = "textBoxAlteraTipoTelefoneTipo";
            textBoxAlteraTipoTelefoneTipo.Size = new Size(100, 23);
            textBoxAlteraTipoTelefoneTipo.TabIndex = 33;
            // 
            // textBoxBuscaTipoTelefone
            // 
            textBoxBuscaTipoTelefone.Location = new Point(641, 168);
            textBoxBuscaTipoTelefone.Name = "textBoxBuscaTipoTelefone";
            textBoxBuscaTipoTelefone.Size = new Size(48, 23);
            textBoxBuscaTipoTelefone.TabIndex = 34;
            // 
            // btnAtualizaTipoTelefone
            // 
            btnAtualizaTipoTelefone.Location = new Point(883, 60);
            btnAtualizaTipoTelefone.Name = "btnAtualizaTipoTelefone";
            btnAtualizaTipoTelefone.Size = new Size(75, 23);
            btnAtualizaTipoTelefone.TabIndex = 35;
            btnAtualizaTipoTelefone.Text = "Alterar";
            btnAtualizaTipoTelefone.UseVisualStyleBackColor = true;
            btnAtualizaTipoTelefone.Click += btnAtualizaTipoTelefone_Click;
            // 
            // btnExcluirTipoTelefone
            // 
            btnExcluirTipoTelefone.Location = new Point(706, 119);
            btnExcluirTipoTelefone.Name = "btnExcluirTipoTelefone";
            btnExcluirTipoTelefone.Size = new Size(75, 23);
            btnExcluirTipoTelefone.TabIndex = 36;
            btnExcluirTipoTelefone.Text = "Excluir";
            btnExcluirTipoTelefone.UseVisualStyleBackColor = true;
            btnExcluirTipoTelefone.Click += btnExcluirTipoTelefone_Click;
            // 
            // btnBuscaTipoTelefoneID
            // 
            btnBuscaTipoTelefoneID.Location = new Point(706, 168);
            btnBuscaTipoTelefoneID.Name = "btnBuscaTipoTelefoneID";
            btnBuscaTipoTelefoneID.Size = new Size(75, 23);
            btnBuscaTipoTelefoneID.TabIndex = 37;
            btnBuscaTipoTelefoneID.Text = "Buscar";
            btnBuscaTipoTelefoneID.UseVisualStyleBackColor = true;
            btnBuscaTipoTelefoneID.Click += btnBuscaTipoTelefoneID_Click;
            // 
            // btnBuscaTipoTelefone
            // 
            btnBuscaTipoTelefone.Location = new Point(660, 222);
            btnBuscaTipoTelefone.Name = "btnBuscaTipoTelefone";
            btnBuscaTipoTelefone.Size = new Size(75, 23);
            btnBuscaTipoTelefone.TabIndex = 38;
            btnBuscaTipoTelefone.Text = "Buscar";
            btnBuscaTipoTelefone.UseVisualStyleBackColor = true;
            btnBuscaTipoTelefone.Click += btnBuscaTipoTelefone_Click;
            // 
            // btnCriaTipoTelefone
            // 
            btnCriaTipoTelefone.Location = new Point(835, 11);
            btnCriaTipoTelefone.Name = "btnCriaTipoTelefone";
            btnCriaTipoTelefone.Size = new Size(75, 23);
            btnCriaTipoTelefone.TabIndex = 39;
            btnCriaTipoTelefone.Text = "Criar";
            btnCriaTipoTelefone.UseVisualStyleBackColor = true;
            btnCriaTipoTelefone.Click += btnCriaTipoTelefone_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1039, 564);
            Controls.Add(btnCriaTipoTelefone);
            Controls.Add(btnBuscaTipoTelefone);
            Controls.Add(btnBuscaTipoTelefoneID);
            Controls.Add(btnExcluirTipoTelefone);
            Controls.Add(btnAtualizaTipoTelefone);
            Controls.Add(textBoxBuscaTipoTelefone);
            Controls.Add(textBoxAlteraTipoTelefoneTipo);
            Controls.Add(textBoxExcluiTipoTelefone);
            Controls.Add(textBoxAlteraTipoTelefoneID);
            Controls.Add(textBoxCriaTipoTelefone);
            Controls.Add(listBox3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxAlteraEstiloID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExcluiEstilo);
            Controls.Add(textBoxExcluiEstilo);
            Controls.Add(textBoxAlteraEstiloEstilo);
            Controls.Add(textBoxCriaEstilo);
            Controls.Add(textBoxBuscaEstilo);
            Controls.Add(btnAtualizaEstilo);
            Controls.Add(btnCriaEstilo);
            Controls.Add(btnBuscaEstiloID);
            Controls.Add(listBox1);
            Controls.Add(btnBuscaEstilos);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscaEstilos;
        private ListBox listBox1;
        private Button btnBuscaEstiloID;
        private Button btnCriaEstilo;
        private Button btnAtualizaEstilo;
        private TextBox textBoxBuscaEstilo;
        private TextBox textBoxCriaEstilo;
        private TextBox textBoxAlteraEstiloEstilo;
        private TextBox textBoxExcluiEstilo;
        private Button btnExcluiEstilo;
        private Label label1;
        private Label label2;
        private TextBox textBoxAlteraEstiloID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private ListBox listBox3;
        private TextBox textBoxCriaTipoTelefone;
        private TextBox textBoxAlteraTipoTelefoneID;
        private TextBox textBoxExcluiTipoTelefone;
        private TextBox textBoxAlteraTipoTelefoneTipo;
        private TextBox textBoxBuscaTipoTelefone;
        private Button btnAtualizaTipoTelefone;
        private Button btnExcluirTipoTelefone;
        private Button btnBuscaTipoTelefoneID;
        private Button btnBuscaTipoTelefone;
        private Button btnCriaTipoTelefone;
    }
}