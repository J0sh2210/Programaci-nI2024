namespace FinalProgramación
{
    partial class Crear
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
            cB_user = new ComboBox();
            textBox_Carnet = new TextBox();
            textBox_Nom = new TextBox();
            label2 = new Label();
            textBox_Grado = new TextBox();
            label3 = new Label();
            textBox_Tel = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button_crear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 46);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Carnet";
            // 
            // cB_user
            // 
            cB_user.FormattingEnabled = true;
            cB_user.Location = new Point(546, 56);
            cB_user.Name = "cB_user";
            cB_user.Size = new Size(121, 23);
            cB_user.TabIndex = 1;
            // 
            // textBox_Carnet
            // 
            textBox_Carnet.Location = new Point(208, 43);
            textBox_Carnet.Name = "textBox_Carnet";
            textBox_Carnet.Size = new Size(100, 23);
            textBox_Carnet.TabIndex = 2;
            // 
            // textBox_Nom
            // 
            textBox_Nom.Location = new Point(208, 84);
            textBox_Nom.Name = "textBox_Nom";
            textBox_Nom.Size = new Size(100, 23);
            textBox_Nom.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 92);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // textBox_Grado
            // 
            textBox_Grado.Location = new Point(208, 167);
            textBox_Grado.Name = "textBox_Grado";
            textBox_Grado.Size = new Size(100, 23);
            textBox_Grado.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 170);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Grado";
            // 
            // textBox_Tel
            // 
            textBox_Tel.Location = new Point(208, 126);
            textBox_Tel.Name = "textBox_Tel";
            textBox_Tel.Size = new Size(100, 23);
            textBox_Tel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 129);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 64);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Usuario";
            // 
            // button_crear
            // 
            button_crear.Location = new Point(518, 326);
            button_crear.Name = "button_crear";
            button_crear.Size = new Size(75, 23);
            button_crear.TabIndex = 10;
            button_crear.Text = "Crear";
            button_crear.UseVisualStyleBackColor = true;
            button_crear.Click += button_crear_Click;
            // 
            // Crear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_crear);
            Controls.Add(label5);
            Controls.Add(textBox_Grado);
            Controls.Add(label3);
            Controls.Add(textBox_Tel);
            Controls.Add(label4);
            Controls.Add(textBox_Nom);
            Controls.Add(label2);
            Controls.Add(textBox_Carnet);
            Controls.Add(cB_user);
            Controls.Add(label1);
            Name = "Crear";
            Text = "Crear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cB_user;
        private TextBox textBox_Carnet;
        private TextBox textBox_Nom;
        private Label label2;
        private TextBox textBox_Grado;
        private Label label3;
        private TextBox textBox_Tel;
        private Label label4;
        private Label label5;
        private Button button_crear;
    }
}