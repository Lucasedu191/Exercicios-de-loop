namespace exercicio002
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
            this.labelbase = new System.Windows.Forms.Label();
            this.labelexpoente = new System.Windows.Forms.Label();
            this.numbase = new System.Windows.Forms.NumericUpDown();
            this.numexpo = new System.Windows.Forms.NumericUpDown();
            this.buttoncalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numexpo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelbase
            // 
            this.labelbase.AutoSize = true;
            this.labelbase.Location = new System.Drawing.Point(47, 49);
            this.labelbase.Name = "labelbase";
            this.labelbase.Size = new System.Drawing.Size(79, 13);
            this.labelbase.TabIndex = 0;
            this.labelbase.Text = "informe a base:";
            // 
            // labelexpoente
            // 
            this.labelexpoente.AutoSize = true;
            this.labelexpoente.Location = new System.Drawing.Point(50, 87);
            this.labelexpoente.Name = "labelexpoente";
            this.labelexpoente.Size = new System.Drawing.Size(100, 13);
            this.labelexpoente.TabIndex = 1;
            this.labelexpoente.Text = "informe o expoente:";
            // 
            // numbase
            // 
            this.numbase.Location = new System.Drawing.Point(167, 49);
            this.numbase.Name = "numbase";
            this.numbase.Size = new System.Drawing.Size(120, 20);
            this.numbase.TabIndex = 2;
            // 
            // numexpo
            // 
            this.numexpo.Location = new System.Drawing.Point(167, 79);
            this.numexpo.Name = "numexpo";
            this.numexpo.Size = new System.Drawing.Size(120, 20);
            this.numexpo.TabIndex = 3;
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.Location = new System.Drawing.Point(143, 135);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(75, 23);
            this.buttoncalcular.TabIndex = 4;
            this.buttoncalcular.Text = "Calcular";
            this.buttoncalcular.UseVisualStyleBackColor = true;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.numexpo);
            this.Controls.Add(this.numbase);
            this.Controls.Add(this.labelexpoente);
            this.Controls.Add(this.labelbase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numexpo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbase;
        private System.Windows.Forms.Label labelexpoente;
        private System.Windows.Forms.NumericUpDown numbase;
        private System.Windows.Forms.NumericUpDown numexpo;
        private System.Windows.Forms.Button buttoncalcular;
    }
}

