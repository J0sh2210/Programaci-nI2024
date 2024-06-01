namespace Presentation
{
    partial class Calificaciones
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
            this.dataGridcali = new System.Windows.Forms.DataGridView();
            this.bton_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcali)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridcali
            // 
            this.dataGridcali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcali.Location = new System.Drawing.Point(33, 13);
            this.dataGridcali.Name = "dataGridcali";
            this.dataGridcali.Size = new System.Drawing.Size(755, 150);
            this.dataGridcali.TabIndex = 0;
            // 
            // bton_agregar
            // 
            this.bton_agregar.Location = new System.Drawing.Point(573, 344);
            this.bton_agregar.Name = "bton_agregar";
            this.bton_agregar.Size = new System.Drawing.Size(119, 42);
            this.bton_agregar.TabIndex = 1;
            this.bton_agregar.Text = "Agregar";
            this.bton_agregar.UseVisualStyleBackColor = true;
            this.bton_agregar.Click += new System.EventHandler(this.bton_agregar_Click);
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bton_agregar);
            this.Controls.Add(this.dataGridcali);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridcali;
        private System.Windows.Forms.Button bton_agregar;
    }
}