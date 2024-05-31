namespace Presentation
{
    partial class Form_alumnos
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
            this.datagridalumnos = new System.Windows.Forms.DataGridView();
            this.Boton_agregar = new System.Windows.Forms.Button();
            this.Editar_alum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridalumnos
            // 
            this.datagridalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalumnos.Location = new System.Drawing.Point(12, 12);
            this.datagridalumnos.Name = "datagridalumnos";
            this.datagridalumnos.Size = new System.Drawing.Size(776, 396);
            this.datagridalumnos.TabIndex = 0;
            // 
            // Boton_agregar
            // 
            this.Boton_agregar.Location = new System.Drawing.Point(648, 415);
            this.Boton_agregar.Name = "Boton_agregar";
            this.Boton_agregar.Size = new System.Drawing.Size(116, 23);
            this.Boton_agregar.TabIndex = 1;
            this.Boton_agregar.Text = "Agregar";
            this.Boton_agregar.UseVisualStyleBackColor = true;
            this.Boton_agregar.Click += new System.EventHandler(this.Boton_agregar_Click);
            // 
            // Editar_alum
            // 
            this.Editar_alum.Location = new System.Drawing.Point(495, 415);
            this.Editar_alum.Name = "Editar_alum";
            this.Editar_alum.Size = new System.Drawing.Size(124, 23);
            this.Editar_alum.TabIndex = 2;
            this.Editar_alum.Text = "Editar";
            this.Editar_alum.UseVisualStyleBackColor = true;
            this.Editar_alum.Click += new System.EventHandler(this.Editar_alum_Click);
            // 
            // Form_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editar_alum);
            this.Controls.Add(this.Boton_agregar);
            this.Controls.Add(this.datagridalumnos);
            this.Name = "Form_alumnos";
            this.Text = "Form_alumnos";
            this.Load += new System.EventHandler(this.Form_alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridalumnos;
        private System.Windows.Forms.Button Boton_agregar;
        private System.Windows.Forms.Button Editar_alum;
    }
}