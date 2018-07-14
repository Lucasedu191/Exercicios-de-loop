namespace exercicio_13
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
            this.labelinforma = new System.Windows.Forms.Label();
            this.numericUpDowntermos = new System.Windows.Forms.NumericUpDown();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.labelmostraresul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntermos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinforma
            // 
            this.labelinforma.AutoSize = true;
            this.labelinforma.Location = new System.Drawing.Point(36, 22);
            this.labelinforma.Name = "labelinforma";
            this.labelinforma.Size = new System.Drawing.Size(193, 13);
            this.labelinforma.TabIndex = 0;
            this.labelinforma.Text = "informe quantos termos deseja calcular:";
            // 
            // numericUpDowntermos
            // 
            this.numericUpDowntermos.Location = new System.Drawing.Point(319, 14);
            this.numericUpDowntermos.Name = "numericUpDowntermos";
            this.numericUpDowntermos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDowntermos.TabIndex = 1;
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(523, 12);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonmostrar.TabIndex = 2;
            this.buttonmostrar.Text = "mostrar";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // labelmostraresul
            // 
            this.labelmostraresul.AutoSize = true;
            this.labelmostraresul.Location = new System.Drawing.Point(113, 185);
            this.labelmostraresul.Name = "labelmostraresul";
            this.labelmostraresul.Size = new System.Drawing.Size(51, 13);
            this.labelmostraresul.TabIndex = 3;
            this.labelmostraresul.Text = "boa noite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelmostraresul);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.numericUpDowntermos);
            this.Controls.Add(this.labelinforma);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntermos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinforma;
        private System.Windows.Forms.NumericUpDown numericUpDowntermos;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Label labelmostraresul;
    }
}

