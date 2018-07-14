namespace exercicio12
{
    partial class Form1
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
            this.labelinforme = new System.Windows.Forms.Label();
            this.numericUpDownguardaN = new System.Windows.Forms.NumericUpDown();
            this.buttoncalcula = new System.Windows.Forms.Button();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownguardaN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinforme
            // 
            this.labelinforme.AutoSize = true;
            this.labelinforme.Location = new System.Drawing.Point(64, 52);
            this.labelinforme.Name = "labelinforme";
            this.labelinforme.Size = new System.Drawing.Size(55, 13);
            this.labelinforme.TabIndex = 0;
            this.labelinforme.Text = "informe N:";
            // 
            // numericUpDownguardaN
            // 
            this.numericUpDownguardaN.Location = new System.Drawing.Point(217, 52);
            this.numericUpDownguardaN.Name = "numericUpDownguardaN";
            this.numericUpDownguardaN.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownguardaN.TabIndex = 1;
            // 
            // buttoncalcula
            // 
            this.buttoncalcula.Location = new System.Drawing.Point(504, 48);
            this.buttoncalcula.Name = "buttoncalcula";
            this.buttoncalcula.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcula.TabIndex = 2;
            this.buttoncalcula.Text = "calcula";
            this.buttoncalcula.UseVisualStyleBackColor = true;
            this.buttoncalcula.Click += new System.EventHandler(this.buttoncalcula_Click);
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 101);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(744, 297);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 410);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.buttoncalcula);
            this.Controls.Add(this.numericUpDownguardaN);
            this.Controls.Add(this.labelinforme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownguardaN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinforme;
        private System.Windows.Forms.NumericUpDown numericUpDownguardaN;
        private System.Windows.Forms.Button buttoncalcula;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

