namespace FinalProgramación
{
    partial class Actualizar
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
            button_actualizar = new Button();
            label5 = new Label();
            textBox_grado = new TextBox();
            label3 = new Label();
            textBox_Tel = new TextBox();
            label4 = new Label();
            textBox_Nom = new TextBox();
            label2 = new Label();
            textBox_carnet = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button_actualizar
            // 
            button_actualizar.Location = new Point(516, 355);
            button_actualizar.Name = "button_actualizar";
            button_actualizar.Size = new Size(75, 23);
            button_actualizar.TabIndex = 21;
            button_actualizar.Text = "Actualizar";
            button_actualizar.UseVisualStyleBackColor = true;
            button_actualizar.Click += button_actualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 189);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 20;
            label5.Text = "Usuario";
            // 
            // textBox_grado
            // 
            textBox_grado.Location = new Point(89, 136);
            textBox_grado.Name = "textBox_grado";
            textBox_grado.Size = new Size(100, 23);
            textBox_grado.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 139);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 18;
            label3.Text = "Grado";
            // 
            // textBox_Tel
            // 
            textBox_Tel.Location = new Point(89, 95);
            textBox_Tel.Name = "textBox_Tel";
            textBox_Tel.Size = new Size(100, 23);
            textBox_Tel.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 98);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 16;
            label4.Text = "Telefono";
            // 
            // textBox_Nom
            // 
            textBox_Nom.Location = new Point(89, 53);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(100, 23);
            textBox_Nom.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // textBox_carnet
            // 
            textBox_carnet.Location = new Point(89, 12);
            textBox_carnet.Name = "textBox_carnet";
            textBox_carnet.Size = new Size(100, 23);
            textBox_carnet.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Carnet";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(195, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(593, 332);
            dataGridView2.TabIndex = 22;
            // 
            // Actualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(button_actualizar);
            Controls.Add(label5);
            Controls.Add(textBox_grado);
            Controls.Add(label3);
            Controls.Add(textBox_Tel);
            Controls.Add(label4);
            Controls.Add(textBox_Nom);
            Controls.Add(label2);
            Controls.Add(textBox_carnet);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Actualizar";
            Text = "Actualizar";
            Load += Actualizar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_actualizar;
        private Label label5;
        private TextBox textBox_grado;
        private Label label3;
        private TextBox textBox_Tel;
        private Label label4;
        private TextBox textBox_Nom;
        private Label label2;
        private TextBox textBox_carnet;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView2;
    }
}