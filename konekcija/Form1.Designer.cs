namespace konekcija
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
            this.Button1 = new System.Windows.Forms.Button();
            this.labela = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(103, 78);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(168, 57);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(119, 206);
            this.labela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(46, 17);
            this.labela.TabIndex = 2;
            this.labela.Text = "label1";
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(429, 95);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(107, 40);
            this.btnForm2.TabIndex = 3;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 293);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.Button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Button btnForm2;
    }
}

