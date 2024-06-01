namespace Presentation
{
    partial class Calificaciones_menu
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
            this.bton_ver_cali = new System.Windows.Forms.Button();
            this.bton_agregar_cali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bton_ver_cali
            // 
            this.bton_ver_cali.Location = new System.Drawing.Point(156, 190);
            this.bton_ver_cali.Name = "bton_ver_cali";
            this.bton_ver_cali.Size = new System.Drawing.Size(196, 97);
            this.bton_ver_cali.TabIndex = 0;
            this.bton_ver_cali.Text = "Ver calificaciones";
            this.bton_ver_cali.UseVisualStyleBackColor = true;
            this.bton_ver_cali.Click += new System.EventHandler(this.bton_ver_cali_Click);
            // 
            // bton_agregar_cali
            // 
            this.bton_agregar_cali.Location = new System.Drawing.Point(437, 190);
            this.bton_agregar_cali.Name = "bton_agregar_cali";
            this.bton_agregar_cali.Size = new System.Drawing.Size(193, 97);
            this.bton_agregar_cali.TabIndex = 1;
            this.bton_agregar_cali.Text = "Agregar Notas";
            this.bton_agregar_cali.UseVisualStyleBackColor = true;
            this.bton_agregar_cali.Click += new System.EventHandler(this.bton_agregar_cali_Click);
            // 
            // Calificaciones_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bton_agregar_cali);
            this.Controls.Add(this.bton_ver_cali);
            this.Name = "Calificaciones_menu";
            this.Text = "Calificaciones_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bton_ver_cali;
        private System.Windows.Forms.Button bton_agregar_cali;
    }
}