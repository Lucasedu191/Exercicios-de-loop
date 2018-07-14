namespace exercicio2
{
    partial class Formpotencia
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
            this.numericUpDownbase = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownexpoente = new System.Windows.Forms.NumericUpDown();
            this.labelbase = new System.Windows.Forms.Label();
            this.labelexpoente = new System.Windows.Forms.Label();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.labelmostra = new System.Windows.Forms.Label();
            this.richTextBoxmostra = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexpoente)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownbase
            // 
            this.numericUpDownbase.Location = new System.Drawing.Point(189, 43);
            this.numericUpDownbase.Name = "numericUpDownbase";
            this.numericUpDownbase.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownbase.TabIndex = 0;
            // 
            // numericUpDownexpoente
            // 
            this.numericUpDownexpoente.Location = new System.Drawing.Point(189, 91);
            this.numericUpDownexpoente.Name = "numericUpDownexpoente";
            this.numericUpDownexpoente.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownexpoente.TabIndex = 1;
            this.numericUpDownexpoente.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelbase
            // 
            this.labelbase.AutoSize = true;
            this.labelbase.Location = new System.Drawing.Point(30, 43);
            this.labelbase.Name = "labelbase";
            this.labelbase.Size = new System.Drawing.Size(67, 13);
            this.labelbase.TabIndex = 2;
            this.labelbase.Text = "digite a base";
            // 
            // labelexpoente
            // 
            this.labelexpoente.AutoSize = true;
            this.labelexpoente.Location = new System.Drawing.Point(33, 91);
            this.labelexpoente.Name = "labelexpoente";
            this.labelexpoente.Size = new System.Drawing.Size(88, 13);
            this.labelexpoente.TabIndex = 3;
            this.labelexpoente.Text = "digite o expoente";
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(436, 68);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcular.TabIndex = 4;
            this.buttoncalcular.Text = "calcula";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // labelmostra
            // 
            this.labelmostra.AutoSize = true;
            this.labelmostra.Location = new System.Drawing.Point(159, 199);
            this.labelmostra.Name = "labelmostra";
            this.labelmostra.Size = new System.Drawing.Size(51, 13);
            this.labelmostra.TabIndex = 5;
            this.labelmostra.Text = "boa noite";
            // 
            // richTextBoxmostra
            // 
            this.richTextBoxmostra.Location = new System.Drawing.Point(0, 232);
            this.richTextBoxmostra.Name = "richTextBoxmostra";
            this.richTextBoxmostra.Size = new System.Drawing.Size(801, 213);
            this.richTextBoxmostra.TabIndex = 6;
            this.richTextBoxmostra.Text = "";
            // 
            // Formpotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostra);
            this.Controls.Add(this.labelmostra);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.labelexpoente);
            this.Controls.Add(this.labelbase);
            this.Controls.Add(this.numericUpDownexpoente);
            this.Controls.Add(this.numericUpDownbase);
            this.Name = "Formpotencia";
            this.Text = "potencia";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexpoente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownbase;
        private System.Windows.Forms.NumericUpDown numericUpDownexpoente;
        private System.Windows.Forms.Label labelbase;
        private System.Windows.Forms.Label labelexpoente;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.Label labelmostra;
        private System.Windows.Forms.RichTextBox richTextBoxmostra;
    }
}

