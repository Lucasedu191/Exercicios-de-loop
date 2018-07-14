namespace Exercicio003
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
            this.labelpares = new System.Windows.Forms.Label();
            this.numpares = new System.Windows.Forms.NumericUpDown();
            this.buttonpares = new System.Windows.Forms.Button();
            this.richTextBoxpares = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numpares)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpares
            // 
            this.labelpares.AutoSize = true;
            this.labelpares.Location = new System.Drawing.Point(43, 13);
            this.labelpares.Name = "labelpares";
            this.labelpares.Size = new System.Drawing.Size(79, 13);
            this.labelpares.TabIndex = 0;
            this.labelpares.Text = "Quantos pares:";
            // 
            // numpares
            // 
            this.numpares.Location = new System.Drawing.Point(168, 13);
            this.numpares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpares.Name = "numpares";
            this.numpares.Size = new System.Drawing.Size(120, 20);
            this.numpares.TabIndex = 1;
            this.numpares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonpares
            // 
            this.buttonpares.Location = new System.Drawing.Point(114, 56);
            this.buttonpares.Name = "buttonpares";
            this.buttonpares.Size = new System.Drawing.Size(75, 23);
            this.buttonpares.TabIndex = 2;
            this.buttonpares.Text = "pares";
            this.buttonpares.UseVisualStyleBackColor = true;
            this.buttonpares.Click += new System.EventHandler(this.buttonpares_Click);
            // 
            // richTextBoxpares
            // 
            this.richTextBoxpares.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxpares.Location = new System.Drawing.Point(0, 86);
            this.richTextBoxpares.Name = "richTextBoxpares";
            this.richTextBoxpares.Size = new System.Drawing.Size(331, 201);
            this.richTextBoxpares.TabIndex = 3;
            this.richTextBoxpares.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 287);
            this.Controls.Add(this.richTextBoxpares);
            this.Controls.Add(this.buttonpares);
            this.Controls.Add(this.numpares);
            this.Controls.Add(this.labelpares);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numpares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpares;
        private System.Windows.Forms.NumericUpDown numpares;
        private System.Windows.Forms.Button buttonpares;
        private System.Windows.Forms.RichTextBox richTextBoxpares;
    }
}

