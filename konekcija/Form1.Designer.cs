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
            this.BAZA = new System.Windows.Forms.Button();
            this.labela = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimeReport = new System.Windows.Forms.Button();
            this.lblTimeReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAZA
            // 
            this.BAZA.Location = new System.Drawing.Point(26, 25);
            this.BAZA.Name = "BAZA";
            this.BAZA.Size = new System.Drawing.Size(126, 46);
            this.BAZA.TabIndex = 0;
            this.BAZA.Text = "Button1";
            this.BAZA.UseVisualStyleBackColor = true;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(42, 110);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(77, 13);
            this.labela.TabIndex = 2;
            this.labela.Text = "miskova labela";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTimeReport
            // 
            this.btnTimeReport.Location = new System.Drawing.Point(181, 174);
            this.btnTimeReport.Name = "btnTimeReport";
            this.btnTimeReport.Size = new System.Drawing.Size(91, 41);
            this.btnTimeReport.TabIndex = 4;
            this.btnTimeReport.Text = "btnTimeReport";
            this.btnTimeReport.UseVisualStyleBackColor = true;
            this.btnTimeReport.Click += new System.EventHandler(this.btnTimeReport_Click);
            // 
            // lblTimeReport
            // 
            this.lblTimeReport.AutoSize = true;
            this.lblTimeReport.Location = new System.Drawing.Point(47, 191);
            this.lblTimeReport.Name = "lblTimeReport";
            this.lblTimeReport.Size = new System.Drawing.Size(72, 13);
            this.lblTimeReport.TabIndex = 5;
            this.lblTimeReport.Text = "lblTimeReport";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTimeReport);
            this.Controls.Add(this.btnTimeReport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.BAZA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAZA;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimeReport;
        private System.Windows.Forms.Label lblTimeReport;
    }
}

