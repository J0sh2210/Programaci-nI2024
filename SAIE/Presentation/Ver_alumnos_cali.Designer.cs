namespace Presentation
{
    partial class Ver_alumnos_cali
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
            this.Boton_agregar = new System.Windows.Forms.Button();
            this.datagridalumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_agregar
            // 
            this.Boton_agregar.Location = new System.Drawing.Point(612, 389);
            this.Boton_agregar.Name = "Boton_agregar";
            this.Boton_agregar.Size = new System.Drawing.Size(152, 49);
            this.Boton_agregar.TabIndex = 4;
            this.Boton_agregar.Text = "Agregar";
            this.Boton_agregar.UseVisualStyleBackColor = true;
            this.Boton_agregar.Click += new System.EventHandler(this.Boton_agregar_Click);
            // 
            // datagridalumnos
            // 
            this.datagridalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridalumnos.Location = new System.Drawing.Point(12, 12);
            this.datagridalumnos.Name = "datagridalumnos";
            this.datagridalumnos.Size = new System.Drawing.Size(776, 351);
            this.datagridalumnos.TabIndex = 3;
            // 
            // Ver_alumnos_cali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_agregar);
            this.Controls.Add(this.datagridalumnos);
            this.Name = "Ver_alumnos_cali";
            this.Text = "ver_alumnos_cali";
            this.Load += new System.EventHandler(this.ver_alumnos_cali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridalumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Boton_agregar;
        private System.Windows.Forms.DataGridView datagridalumnos;
    }
}