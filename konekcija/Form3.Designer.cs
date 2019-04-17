namespace konekcija
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRadnik = new System.Windows.Forms.Label();
            this.accessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDO = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgCHECKLIST = new System.Windows.Forms.DataGridView();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardholderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardholderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxCARDHOLDER);
            this.groupBox1.Controls.Add(this.lblRadnik);
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Work time:";
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "Name";
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(77, 20);
            this.cboxCARDHOLDER.Margin = new System.Windows.Forms.Padding(2);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(185, 21);
            this.cboxCARDHOLDER.TabIndex = 2;
            this.cboxCARDHOLDER.ValueMember = "Name";
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(10, 23);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(45, 13);
            this.lblRadnik.TabIndex = 3;
            this.lblRadnik.Text = "Worker:";
            // 
            // accessLogBindingSource
            // 
            this.accessLogBindingSource.DataSource = typeof(konekcija.AccessLog);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDO);
            this.groupBox2.Controls.Add(this.lblOD);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(471, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(237, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblDO
            // 
            this.lblDO.AutoSize = true;
            this.lblDO.Location = new System.Drawing.Point(15, 56);
            this.lblDO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(20, 13);
            this.lblDO.TabIndex = 3;
            this.lblDO.Text = "To";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(15, 23);
            this.lblOD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(30, 13);
            this.lblOD.TabIndex = 2;
            this.lblOD.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(64, 53);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dgCHECKLIST
            // 
            this.dgCHECKLIST.AllowUserToAddRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgCHECKLIST.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCHECKLIST.AutoGenerateColumns = false;
            this.dgCHECKLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCHECKLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.cardCodeDataGridViewTextBoxColumn,
            this.directionDataGridViewTextBoxColumn,
            this.localTimeDataGridViewTextBoxColumn,
            this.cardholderIDDataGridViewTextBoxColumn,
            this.cardholderDataGridViewTextBoxColumn});
            this.dgCHECKLIST.DataSource = this.accessLogBindingSource;
            this.dgCHECKLIST.Location = new System.Drawing.Point(120, 163);
            this.dgCHECKLIST.Margin = new System.Windows.Forms.Padding(2);
            this.dgCHECKLIST.Name = "dgCHECKLIST";
            this.dgCHECKLIST.RowTemplate.Height = 24;
            this.dgCHECKLIST.Size = new System.Drawing.Size(526, 209);
            this.dgCHECKLIST.TabIndex = 8;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            // 
            // cardCodeDataGridViewTextBoxColumn
            // 
            this.cardCodeDataGridViewTextBoxColumn.DataPropertyName = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.HeaderText = "CardCode";
            this.cardCodeDataGridViewTextBoxColumn.Name = "cardCodeDataGridViewTextBoxColumn";
            // 
            // directionDataGridViewTextBoxColumn
            // 
            this.directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            this.directionDataGridViewTextBoxColumn.HeaderText = "Direction";
            this.directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            // 
            // localTimeDataGridViewTextBoxColumn
            // 
            this.localTimeDataGridViewTextBoxColumn.DataPropertyName = "LocalTime";
            this.localTimeDataGridViewTextBoxColumn.HeaderText = "LocalTime";
            this.localTimeDataGridViewTextBoxColumn.Name = "localTimeDataGridViewTextBoxColumn";
            // 
            // cardholderIDDataGridViewTextBoxColumn
            // 
            this.cardholderIDDataGridViewTextBoxColumn.DataPropertyName = "CardholderID";
            this.cardholderIDDataGridViewTextBoxColumn.HeaderText = "CardholderID";
            this.cardholderIDDataGridViewTextBoxColumn.Name = "cardholderIDDataGridViewTextBoxColumn";
            // 
            // cardholderDataGridViewTextBoxColumn
            // 
            this.cardholderDataGridViewTextBoxColumn.DataPropertyName = "Cardholder";
            this.cardholderDataGridViewTextBoxColumn.HeaderText = "Cardholder";
            this.cardholderDataGridViewTextBoxColumn.Name = "cardholderDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 383);
            this.Controls.Add(this.dgCHECKLIST);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDO;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource accessLogBindingSource;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.DataGridView dgCHECKLIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardholderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardholderDataGridViewTextBoxColumn;
    }
}