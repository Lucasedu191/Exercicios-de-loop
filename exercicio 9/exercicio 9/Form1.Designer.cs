namespace exercicio_9
{
    partial class Formexercicio9
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
            this.richTextBoxmostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.Location = new System.Drawing.Point(287, 26);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonmostrar.TabIndex = 0;
            this.buttonmostrar.Text = "mostrar";
            this.buttonmostrar.UseVisualStyleBackColor = true;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // richTextBoxmostrar
            // 
            this.richTextBoxmostrar.Location = new System.Drawing.Point(13, 56);
            this.richTextBoxmostrar.Name = "richTextBoxmostrar";
            this.richTextBoxmostrar.Size = new System.Drawing.Size(775, 382);
            this.richTextBoxmostrar.TabIndex = 1;
            this.richTextBoxmostrar.Text = "";
            // 
            // Formexercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxmostrar);
            this.Controls.Add(this.buttonmostrar);
            this.Name = "Formexercicio9";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.RichTextBox richTextBoxmostrar;
    }
}

