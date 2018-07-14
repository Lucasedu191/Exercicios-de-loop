namespace exercicio17
{
    partial class Formexercicio17
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
            this.labelinforma = new System.Windows.Forms.Label();
            this.numericUpDownquanto = new System.Windows.Forms.NumericUpDown();
            this.buttoncalcula = new System.Windows.Forms.Button();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinforma
            // 
            this.labelinforma.AutoSize = true;
            this.labelinforma.Location = new System.Drawing.Point(38, 26);
            this.labelinforma.Name = "labelinforma";
            this.labelinforma.Size = new System.Drawing.Size(98, 13);
            this.labelinforma.TabIndex = 0;
            this.labelinforma.Text = "informe os numeros";
            // 
            // numericUpDownquanto
            // 
            this.numericUpDownquanto.Location = new System.Drawing.Point(329, 18);
            this.numericUpDownquanto.Name = "numericUpDownquanto";
            this.numericUpDownquanto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquanto.TabIndex = 1;
            // 
            // buttoncalcula
            // 
            this.buttoncalcula.Location = new System.Drawing.Point(623, 18);
            this.buttoncalcula.Name = "buttoncalcula";
            this.buttoncalcula.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcula.TabIndex = 2;
            this.buttoncalcula.Text = "mostrar";
            this.buttoncalcula.UseVisualStyleBackColor = true;
            this.buttoncalcula.Click += new System.EventHandler(this.buttoncalcula_Click);
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 69);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(775, 369);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Formexercicio17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.buttoncalcula);
            this.Controls.Add(this.numericUpDownquanto);
            this.Controls.Add(this.labelinforma);
            this.Name = "Formexercicio17";
            this.Text = "exercicio17";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinforma;
        private System.Windows.Forms.NumericUpDown numericUpDownquanto;
        private System.Windows.Forms.Button buttoncalcula;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

