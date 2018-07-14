namespace exercicio1
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
            this.labelmostra = new System.Windows.Forms.Label();
            this.buttonsoma = new System.Windows.Forms.Button();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelmostra
            // 
            this.labelmostra.AutoSize = true;
            this.labelmostra.Location = new System.Drawing.Point(104, 34);
            this.labelmostra.Name = "labelmostra";
            this.labelmostra.Size = new System.Drawing.Size(116, 13);
            this.labelmostra.TabIndex = 0;
            this.labelmostra.Text = "aperto ok para calcular";
            // 
            // buttonsoma
            // 
            this.buttonsoma.Location = new System.Drawing.Point(336, 23);
            this.buttonsoma.Name = "buttonsoma";
            this.buttonsoma.Size = new System.Drawing.Size(75, 23);
            this.buttonsoma.TabIndex = 1;
            this.buttonsoma.Text = "soma";
            this.buttonsoma.UseVisualStyleBackColor = true;
            this.buttonsoma.Click += new System.EventHandler(this.buttonsoma_Click);
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(2, 71);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(800, 382);
            this.richTextBoxmostra.TabIndex = 2;
            this.richTextBoxmostra.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.buttonsoma);
            this.Controls.Add(this.labelmostra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmostra;
        private System.Windows.Forms.Button buttonsoma;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

