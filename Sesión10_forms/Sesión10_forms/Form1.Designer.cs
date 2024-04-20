namespace Sesión10_forms
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
            textBox = new TextBox();
            Barra1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)Barra1).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.AcceptsReturn = true;
            textBox.BackColor = SystemColors.InactiveCaption;
            textBox.Location = new Point(357, 69);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(234, 153);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // Barra1
            // 
            Barra1.AllowDrop = true;
            Barra1.BackColor = SystemColors.ButtonFace;
            Barra1.Cursor = Cursors.VSplit;
            Barra1.Location = new Point(47, 347);
            Barra1.Maximum = 100;
            Barra1.Name = "Barra1";
            Barra1.Size = new Size(886, 45);
            Barra1.TabIndex = 1;
            Barra1.Scroll += Barra1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(961, 450);
            Controls.Add(Barra1);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Sesion10";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Barra1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private TrackBar Barra1;
    }
}
