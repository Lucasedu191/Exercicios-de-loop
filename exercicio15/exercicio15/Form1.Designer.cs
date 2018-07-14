namespace exercicio15
{
    partial class Formexercicio14
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
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.labelinforma = new System.Windows.Forms.Label();
            this.numericUpDownquanto = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(456, 32);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonmostrar.TabIndex = 0;
            this.buttonmostrar.Text = "mostra";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // labelinforma
            // 
            this.labelinforma.AutoSize = true;
            this.labelinforma.Location = new System.Drawing.Point(44, 41);
            this.labelinforma.Name = "labelinforma";
            this.labelinforma.Size = new System.Drawing.Size(230, 13);
            this.labelinforma.TabIndex = 1;
            this.labelinforma.Text = "informe o numero que deseja formar a piramede";
            // 
            // numericUpDownquanto
            // 
            this.numericUpDownquanto.Location = new System.Drawing.Point(303, 33);
            this.numericUpDownquanto.Name = "numericUpDownquanto";
            this.numericUpDownquanto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquanto.TabIndex = 2;
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 78);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(775, 360);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Formexercicio14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.numericUpDownquanto);
            this.Controls.Add(this.labelinforma);
            this.Controls.Add(this.buttonmostrar);
            this.Name = "Formexercicio14";
            this.Text = "exercicio14";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Label labelinforma;
        private System.Windows.Forms.NumericUpDown numericUpDownquanto;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

