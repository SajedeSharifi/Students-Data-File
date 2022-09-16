namespace StudentsDataFile
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_dbDataSet = new StudentsDataFile.students_dbDataSet();
            this.informationTableAdapter = new StudentsDataFile.students_dbDataSetTableAdapters.InformationTableAdapter();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstScoreDataGridViewTextBoxColumn,
            this.secScoreDataGridViewTextBoxColumn,
            this.thirdScoreDataGridViewTextBoxColumn,
            this.Average});
            this.dataGridView1.DataSource = this.informationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(703, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.students_dbDataSet;
            // 
            // students_dbDataSet
            // 
            this.students_dbDataSet.DataSetName = "students_dbDataSet";
            this.students_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(156, 210);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(118, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "جستجو";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 210);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "ذخیره تغییرات";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "کد دانش آموزی";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام نام خانوادگی";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // firstScoreDataGridViewTextBoxColumn
            // 
            this.firstScoreDataGridViewTextBoxColumn.DataPropertyName = "First_Score";
            this.firstScoreDataGridViewTextBoxColumn.HeaderText = "نمره اول";
            this.firstScoreDataGridViewTextBoxColumn.Name = "firstScoreDataGridViewTextBoxColumn";
            // 
            // secScoreDataGridViewTextBoxColumn
            // 
            this.secScoreDataGridViewTextBoxColumn.DataPropertyName = "Sec_Score";
            this.secScoreDataGridViewTextBoxColumn.HeaderText = "نمره دوم";
            this.secScoreDataGridViewTextBoxColumn.Name = "secScoreDataGridViewTextBoxColumn";
            // 
            // thirdScoreDataGridViewTextBoxColumn
            // 
            this.thirdScoreDataGridViewTextBoxColumn.DataPropertyName = "Third_Score";
            this.thirdScoreDataGridViewTextBoxColumn.HeaderText = "نمره سوم";
            this.thirdScoreDataGridViewTextBoxColumn.Name = "thirdScoreDataGridViewTextBoxColumn";
            // 
            // Average
            // 
            this.Average.DataPropertyName = "Average";
            this.Average.HeaderText = "میانگین نمرات";
            this.Average.Name = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 258);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private students_dbDataSet students_dbDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private students_dbDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
    }
}

