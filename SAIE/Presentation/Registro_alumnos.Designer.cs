namespace Presentation
{
    partial class Registro_alumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_alumnos));
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_apellido = new System.Windows.Forms.TextBox();
            this.textCarnet = new System.Windows.Forms.TextBox();
            this.text_Nombre_Encargado = new System.Windows.Forms.TextBox();
            this.text_Num_encargado = new System.Windows.Forms.TextBox();
            this.text_Seccion = new System.Windows.Forms.TextBox();
            this.text_Grado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boton_Confirmar = new System.Windows.Forms.Button();
            this.dt_fecha_ins = new System.Windows.Forms.DateTimePicker();
            this.dt_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.comboB_Pago = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(213, 27);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(100, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_apellido
            // 
            this.text_apellido.Location = new System.Drawing.Point(213, 69);
            this.text_apellido.Name = "text_apellido";
            this.text_apellido.Size = new System.Drawing.Size(100, 20);
            this.text_apellido.TabIndex = 2;
            // 
            // textCarnet
            // 
            this.textCarnet.Location = new System.Drawing.Point(213, 111);
            this.textCarnet.Name = "textCarnet";
            this.textCarnet.Size = new System.Drawing.Size(100, 20);
            this.textCarnet.TabIndex = 3;
            // 
            // text_Nombre_Encargado
            // 
            this.text_Nombre_Encargado.Location = new System.Drawing.Point(641, 158);
            this.text_Nombre_Encargado.Name = "text_Nombre_Encargado";
            this.text_Nombre_Encargado.Size = new System.Drawing.Size(100, 20);
            this.text_Nombre_Encargado.TabIndex = 9;
            // 
            // text_Num_encargado
            // 
            this.text_Num_encargado.Location = new System.Drawing.Point(641, 111);
            this.text_Num_encargado.Name = "text_Num_encargado";
            this.text_Num_encargado.Size = new System.Drawing.Size(100, 20);
            this.text_Num_encargado.TabIndex = 8;
            // 
            // text_Seccion
            // 
            this.text_Seccion.Location = new System.Drawing.Point(641, 69);
            this.text_Seccion.Name = "text_Seccion";
            this.text_Seccion.Size = new System.Drawing.Size(100, 20);
            this.text_Seccion.TabIndex = 7;
            // 
            // text_Grado
            // 
            this.text_Grado.Location = new System.Drawing.Point(641, 27);
            this.text_Grado.Name = "text_Grado";
            this.text_Grado.Size = new System.Drawing.Size(100, 20);
            this.text_Grado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha Inscripcion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Carnet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pago realizado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre encargado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Número telefónico encargado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Grado";
            // 
            // boton_Confirmar
            // 
            this.boton_Confirmar.Location = new System.Drawing.Point(522, 320);
            this.boton_Confirmar.Name = "boton_Confirmar";
            this.boton_Confirmar.Size = new System.Drawing.Size(158, 78);
            this.boton_Confirmar.TabIndex = 20;
            this.boton_Confirmar.Text = "Confirmar";
            this.boton_Confirmar.UseVisualStyleBackColor = true;
            this.boton_Confirmar.Click += new System.EventHandler(this.boton_Confirmar_Click);
            // 
            // dt_fecha_ins
            // 
            this.dt_fecha_ins.Location = new System.Drawing.Point(202, 158);
            this.dt_fecha_ins.Name = "dt_fecha_ins";
            this.dt_fecha_ins.Size = new System.Drawing.Size(197, 20);
            this.dt_fecha_ins.TabIndex = 22;
            // 
            // dt_fecha_nac
            // 
            this.dt_fecha_nac.Location = new System.Drawing.Point(202, 203);
            this.dt_fecha_nac.Name = "dt_fecha_nac";
            this.dt_fecha_nac.Size = new System.Drawing.Size(197, 20);
            this.dt_fecha_nac.TabIndex = 23;
            // 
            // comboB_Pago
            // 
            this.comboB_Pago.FormattingEnabled = true;
            this.comboB_Pago.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboB_Pago.Location = new System.Drawing.Point(645, 205);
            this.comboB_Pago.Name = "comboB_Pago";
            this.comboB_Pago.Size = new System.Drawing.Size(105, 21);
            this.comboB_Pago.TabIndex = 24;
            // 
            // Registro_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboB_Pago);
            this.Controls.Add(this.dt_fecha_nac);
            this.Controls.Add(this.dt_fecha_ins);
            this.Controls.Add(this.boton_Confirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_Nombre_Encargado);
            this.Controls.Add(this.text_Num_encargado);
            this.Controls.Add(this.text_Seccion);
            this.Controls.Add(this.text_Grado);
            this.Controls.Add(this.textCarnet);
            this.Controls.Add(this.text_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_alumnos";
            this.Text = "Registrar alumnos";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Registro_alumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_apellido;
        private System.Windows.Forms.TextBox textCarnet;
        private System.Windows.Forms.TextBox text_Nombre_Encargado;
        private System.Windows.Forms.TextBox text_Num_encargado;
        private System.Windows.Forms.TextBox text_Seccion;
        private System.Windows.Forms.TextBox text_Grado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button boton_Confirmar;
        private System.Windows.Forms.DateTimePicker dt_fecha_ins;
        private System.Windows.Forms.DateTimePicker dt_fecha_nac;
        private System.Windows.Forms.ComboBox comboB_Pago;
    }
}