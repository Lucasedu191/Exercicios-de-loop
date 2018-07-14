namespace exercicio3
{
    partial class Formreceb
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
            this.buttonler = new System.Windows.Forms.Button();
            this.numericUpDownquantos = new System.Windows.Forms.NumericUpDown();
            this.labelinforma = new System.Windows.Forms.Label();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquantos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonler
            // 
            this.buttonler.Location = new System.Drawing.Point(464, 37);
            this.buttonler.Name = "buttonler";
            this.buttonler.Size = new System.Drawing.Size(75, 23);
            this.buttonler.TabIndex = 0;
            this.buttonler.Text = "leia";
            this.buttonler.UseVisualStyleBackColor = true;
            this.buttonler.Click += new System.EventHandler(this.buttonler_Click);
            // 
            // numericUpDownquantos
            // 
            this.numericUpDownquantos.Location = new System.Drawing.Point(268, 40);
            this.numericUpDownquantos.Name = "numericUpDownquantos";
            this.numericUpDownquantos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownquantos.TabIndex = 1;
            // 
            // labelinforma
            // 
            this.labelinforma.AutoSize = true;
            this.labelinforma.Location = new System.Drawing.Point(39, 40);
            this.labelinforma.Name = "labelinforma";
            this.labelinforma.Size = new System.Drawing.Size(186, 13);
            this.labelinforma.TabIndex = 2;
            this.labelinforma.Text = "informe quantos numeros irão ser lidos";
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(13, 86);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(775, 352);
            this.richTextBoxmostra.TabIndex = 3;
            this.richTextBoxmostra.Text = "";
            // 
            // Formreceb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.labelinforma);
            this.Controls.Add(this.numericUpDownquantos);
            this.Controls.Add(this.buttonler);
            this.Name = "Formreceb";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownquantos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonler;
        private System.Windows.Forms.NumericUpDown numericUpDownquantos;
        private System.Windows.Forms.Label labelinforma;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

