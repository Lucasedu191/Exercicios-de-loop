namespace exercicio14
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
            this.labelinforma = new System.Windows.Forms.Label();
            this.numericUpDownquanto = new System.Windows.Forms.NumericUpDown();
            this.buttonpirame = new System.Windows.Forms.Button();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinforma
            // 
            this.labelinforma.AutoSize = true;
            this.labelinforma.Location = new System.Drawing.Point(13, 24);
            this.labelinforma.Name = "labelinforma";
            this.labelinforma.Size = new System.Drawing.Size(241, 13);
            this.labelinforma.TabIndex = 0;
            this.labelinforma.Text = "informe o numero de * que deseja ter na piramede";
            // 
            // numericUpDownquanto
            // 
            this.numericUpDownquanto.Location = new System.Drawing.Point(328, 16);
            this.numericUpDownquanto.Name = "numericUpDownquanto";
            this.numericUpDownquanto.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquanto.TabIndex = 1;
            // 
            // buttonpirame
            // 
            this.buttonpirame.Location = new System.Drawing.Point(551, 16);
            this.buttonpirame.Name = "buttonpirame";
            this.buttonpirame.Size = new System.Drawing.Size(75, 23);
            this.buttonpirame.TabIndex = 2;
            this.buttonpirame.Text = "mostra";
            this.buttonpirame.UseVisualStyleBackColor = true;
            this.buttonpirame.Click += new System.EventHandler(this.buttonpirame_Click);
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 102);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(775, 336);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Formexercicio14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.buttonpirame);
            this.Controls.Add(this.numericUpDownquanto);
            this.Controls.Add(this.labelinforma);
            this.Name = "Formexercicio14";
            this.Text = "exercicio14";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquanto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinforma;
        private System.Windows.Forms.NumericUpDown numericUpDownquanto;
        private System.Windows.Forms.Button buttonpirame;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

