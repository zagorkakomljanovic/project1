namespace konekcija
{
    partial class Form2
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardholdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mojaEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mojaEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojaEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojaEntitiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardsDataGridViewTextBoxColumn,
            this.cardholdersDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mojaEntitiesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(350, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // cardsDataGridViewTextBoxColumn
            // 
            this.cardsDataGridViewTextBoxColumn.DataPropertyName = "Cards";
            this.cardsDataGridViewTextBoxColumn.HeaderText = "Cards";
            this.cardsDataGridViewTextBoxColumn.Name = "cardsDataGridViewTextBoxColumn";
            // 
            // cardholdersDataGridViewTextBoxColumn
            // 
            this.cardholdersDataGridViewTextBoxColumn.DataPropertyName = "Cardholders";
            this.cardholdersDataGridViewTextBoxColumn.HeaderText = "Cardholders";
            this.cardholdersDataGridViewTextBoxColumn.Name = "cardholdersDataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // configurationDataGridViewTextBoxColumn
            // 
            this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
            this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
            this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
            this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mojaEntitiesBindingSource
            // 
            this.mojaEntitiesBindingSource.DataSource = typeof(konekcija.MojaEntities);
            // 
            // mojaEntitiesBindingSource1
            // 
            this.mojaEntitiesBindingSource1.DataSource = typeof(konekcija.MojaEntities);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojaEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mojaEntitiesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardholdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mojaEntitiesBindingSource;
        private System.Windows.Forms.BindingSource mojaEntitiesBindingSource1;
    }
}