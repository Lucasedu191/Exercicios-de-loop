namespace exercicio_6
{
    partial class Formexercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownquanto = new System.Windows.Forms.NumericUpDown();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "quantos termos deseja?";
            // 
            // numericUpDownquanto
            // 
            this.numericUpDownquanto.Location = new System.Drawing.Point(257, 5);
            this.numericUpDownquanto.Name = "numericUpDownquanto";
            this.numericUpDownquanto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquanto.TabIndex = 1;
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(504, 13);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcular.TabIndex = 2;
            this.buttoncalcular.Text = "mostrar";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 65);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(775, 373);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Formexercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.numericUpDownquanto);
            this.Controls.Add(this.label1);
            this.Name = "Formexercicio6";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownquanto;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

