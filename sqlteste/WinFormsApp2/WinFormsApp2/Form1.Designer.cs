namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridViewProvas = new DataGridView();
            textBoxDistancia = new TextBox();
            comboBoxSexo = new ComboBox();
            comboBoxEstilos = new ComboBox();
            buttonBuscar = new Button();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvas).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridViewProvas
            // 
            dataGridViewProvas.AllowUserToOrderColumns = true;
            dataGridViewProvas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProvas.Location = new Point(29, 71);
            dataGridViewProvas.Name = "dataGridViewProvas";
            dataGridViewProvas.RowTemplate.Height = 25;
            dataGridViewProvas.Size = new Size(642, 314);
            dataGridViewProvas.TabIndex = 1;
            dataGridViewProvas.CellContentClick += dataGridViewProvas_CellContentClick;
            // 
            // textBoxDistancia
            // 
            textBoxDistancia.ForeColor = SystemColors.ButtonShadow;
            textBoxDistancia.Location = new Point(29, 18);
            textBoxDistancia.Name = "textBoxDistancia";
            textBoxDistancia.Size = new Size(139, 23);
            textBoxDistancia.TabIndex = 2;
            textBoxDistancia.Text = "Distancia (m)";
            textBoxDistancia.TextAlign = HorizontalAlignment.Center;
            textBoxDistancia.Click += textBoxDistancia_Click;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Location = new Point(237, 19);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(144, 23);
            comboBoxSexo.TabIndex = 3;
            // 
            // comboBoxEstilos
            // 
            comboBoxEstilos.FormattingEnabled = true;
            comboBoxEstilos.Location = new Point(443, 19);
            comboBoxEstilos.Name = "comboBoxEstilos";
            comboBoxEstilos.Size = new Size(165, 23);
            comboBoxEstilos.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(644, 18);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(585, 403);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(134, 35);
            btnNovo.TabIndex = 6;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovo);
            Controls.Add(buttonBuscar);
            Controls.Add(comboBoxEstilos);
            Controls.Add(comboBoxSexo);
            Controls.Add(textBoxDistancia);
            Controls.Add(dataGridViewProvas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        public DataGridView dataGridViewProvas;
        private TextBox textBoxDistancia;
        private ComboBox comboBoxSexo;
        private ComboBox comboBoxEstilos;
        private Button buttonBuscar;
        private Button btnNovo;
    }
}