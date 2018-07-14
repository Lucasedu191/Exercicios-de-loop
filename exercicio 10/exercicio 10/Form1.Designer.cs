namespace exercicio_10
{
    partial class Formexercicio10
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
            this.labelinformeprimo = new System.Windows.Forms.Label();
            this.numericUpDownprimo = new System.Windows.Forms.NumericUpDown();
            this.buttoncalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprimo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinformeprimo
            // 
            this.labelinformeprimo.AutoSize = true;
            this.labelinformeprimo.Location = new System.Drawing.Point(71, 29);
            this.labelinformeprimo.Name = "labelinformeprimo";
            this.labelinformeprimo.Size = new System.Drawing.Size(216, 13);
            this.labelinformeprimo.TabIndex = 0;
            this.labelinformeprimo.Text = "informe qual numero deseja saber se é primo";
            // 
            // numericUpDownprimo
            // 
            this.numericUpDownprimo.Location = new System.Drawing.Point(380, 29);
            this.numericUpDownprimo.Name = "numericUpDownprimo";
            this.numericUpDownprimo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownprimo.TabIndex = 1;
            // 
            // buttoncalcula
            // 
            this.buttoncalcula.Location = new System.Drawing.Point(579, 29);
            this.buttoncalcula.Name = "buttoncalcula";
            this.buttoncalcula.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcula.TabIndex = 2;
            this.buttoncalcula.Text = "mostrar";
            this.buttoncalcula.UseVisualStyleBackColor = true;
            this.buttoncalcula.Click += new System.EventHandler(this.buttoncalcula_Click);
            // 
            // Formexercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncalcula);
            this.Controls.Add(this.numericUpDownprimo);
            this.Controls.Add(this.labelinformeprimo);
            this.Name = "Formexercicio10";
            this.Text = "é primo?";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinformeprimo;
        private System.Windows.Forms.NumericUpDown numericUpDownprimo;
        private System.Windows.Forms.Button buttoncalcula;
    }
}

