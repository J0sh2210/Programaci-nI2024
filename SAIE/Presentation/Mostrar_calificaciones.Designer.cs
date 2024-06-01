namespace Presentation
{
    partial class Mostrar_calificaciones
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
            this.dg_ver_cali = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ver_cali)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ver_cali
            // 
            this.dg_ver_cali.BackgroundColor = System.Drawing.Color.White;
            this.dg_ver_cali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ver_cali.Location = new System.Drawing.Point(12, 12);
            this.dg_ver_cali.Name = "dg_ver_cali";
            this.dg_ver_cali.Size = new System.Drawing.Size(762, 409);
            this.dg_ver_cali.TabIndex = 0;
            // 
            // Mostrar_calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_ver_cali);
            this.Name = "Mostrar_calificaciones";
            this.Text = "Mostrar_calificaciones";
            this.Load += new System.EventHandler(this.Mostrar_calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ver_cali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ver_cali;
    }
}